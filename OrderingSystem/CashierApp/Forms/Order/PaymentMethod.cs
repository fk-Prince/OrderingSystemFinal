using System;
using System.Windows.Forms;
using OrderingSystem.CashierApp.Payment;
using OrderingSystem.Exceptions;
using OrderingSystem.KioskApplication.Services;
using OrderingSystem.Model;
using OrderingSystem.Services;

namespace OrderingSystem.CashierApp.Forms.Order
{
    public partial class PaymentMethod : Form
    {
        private OrderModel om;
        private readonly OrderServices orderServices;

        public double Cash;
        public Payment.Payment paymentT;
        public InvoiceModel inv;

        public PaymentMethod(OrderServices orderServices)
        {
            InitializeComponent();
            this.orderServices = orderServices;

            var payments = orderServices.getAvailablePayments();
            payments.ForEach(payment => cb.Items.Add(payment));

            var sp = orderServices.getSpecialDiscount();
            sp.ForEach(p => cd.Items.Add(p.discountName));

            if (payments.Count > 0)
                cb.SelectedIndex = 0;

            if (payments.Contains("Cash"))
                cb.SelectedIndex = payments.IndexOf("Cash");

            if (sp.Count > 0)
                cd.SelectedIndex = 0;


            cb_SelectedIndexChanged(this, EventArgs.Empty);
        }

        public void setOrder(OrderModel om)
        {
            this.om = om;
            updateTotal();
        }

        private void updateTotal()
        {
            if (om == null) return;

            double baseTotal = om.GetTotalWithVAT();
            IPayment payment = createPayment();

            if (payment is IFeeCalculator feeCalc)
            {
                double fee = feeCalc.calculateFee(baseTotal);
                double totalWithFee = feeCalc.getTotalWithFee(baseTotal);
                total.Text = $"{totalWithFee:N2} (Fee: ₱{fee:N2})";
            }
            else
            {
                total.Text = baseTotal.ToString("N2");
            }
        }

        private IPayment createPayment()
        {
            IPaymentFactory factory = new PaymentFactory(orderServices);
            return factory.paymentType(cb.SelectedItem?.ToString() ?? "Cash");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cb.SelectedIndex == -1)
                    throw new InvalidPayment("No payment method selected.");

                IPayment payment = createPayment();

                if (payment is ICashHandling cashPayment)
                {
                    if (!double.TryParse(t1.Text, out double cashAmount) && cashAmount > 0)
                        throw new InvalidPayment("Invalid cash amount.");

                    cashPayment.setCashReceieved(cashAmount);
                }

                InvoiceModel invoice = payment.processPayment(om, cd.SelectedItem.ToString());
                bool success = orderServices.payOrder(invoice);
                if (success)
                {
                    MessageBox.Show("Payment successful!", "Payment Method",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    paymentT = (Payment.Payment)payment;
                    inv = invoice;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to process payment.", "Payment Method",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                StripeService s = new StripeService();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Payment Method",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryParseCash(string input, out double amount)
        {
            return double.TryParse(input?.Trim(), out amount) && amount > 0;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == -1) return;
            if (cb.Text.ToLower() != "cash")
            {
                cb.SelectedItem = "Cash";
                MessageBox.Show("This method is not supported yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IPayment payment = createPayment();
            bool isCash = cb.SelectedItem?.ToString()?.Equals("Cash",
                StringComparison.OrdinalIgnoreCase) ?? false;

            t1.Visible = isCash;
            l1.Visible = isCash;
            t2.Visible = isCash;
            l2.Visible = isCash;

            if (payment is IFeeCalculator f)
            {
                double percent = f.feePercent * 100;
                fee.Text = $"{percent}% fee";
                fee.Visible = true;
            }
            else
            {
                fee.Text = "";
                fee.Visible = false;
            }

            updateTotal();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            if (TryParseCash(t1.Text, out double cash) && om != null)
            {
                IPayment payment = createPayment();

                if (payment is ICashHandling cashPayment)
                {
                    double total = cd.SelectedItem.ToString().ToLower() == "regular" ? om.GetTotalWithVAT() : (om.getTotalDiscount() - (om.getTotalDiscount() * 0.20));
                    double change = cash >= total ? cash - total : 0;
                    Cash = cash;
                    t2.Text = change.ToString("N2");
                }
            }
            else
            {
                t2.Text = "0.00";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (om == null) return;

            if (cd.SelectedItem.ToString().ToLower() != "regular")
            {
                IPayment payment = createPayment();

                if (payment is ICashHandling cashPayment)
                {
                    total.Text = (om.getTotalDiscount() - (om.getTotalDiscount() * 0.20)).ToString("N2");
                }
                else if (payment is IFeeCalculator f)
                {
                    total.Text = (om.getTotalDiscount() + (1 * f.feePercent)).ToString();
                }
                t1_TextChanged(t1, EventArgs.Empty);
            }
            else
            {
                total.Text = om.GetTotalWithVAT().ToString("N2");
                t1_TextChanged(t1, EventArgs.Empty);
            }
        }
    }
}