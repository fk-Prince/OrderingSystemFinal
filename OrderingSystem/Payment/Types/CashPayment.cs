using OrderingSystem.Exceptions;
using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Payment
{
    public class CashPayment : Payment, ICashHandling
    {
        private double cashReceived;
        public override string PaymentName => "Cash";

        public virtual void validateCashAmount(double cashReceived, double totalAmount)
        {
            if (cashReceived <= 0)
                throw new InvalidPayment("Cash amount must be greater than zero.");

            if (totalAmount > cashReceived)
                throw new InsuffiecientAmount("The cash amount is insufficient to process the payment.");
        }

        public override InvoiceModel processPayment(OrderModel order, string type)
        {
            validateOrder(order);

            double totalAmount = type.ToLower() == "regular" ? order.GetTotalWithVAT() : order.getTotalDiscount() - (order.getTotalDiscount() * 0.20);
            validateCashAmount(cashReceived, totalAmount);
            return finalizeOrder(order, 0, type);
        }
        public void setCashReceieved(double cashReceived)
        {
            this.cashReceived = cashReceived;
        }
        public double calculateChage(double total)
        {
            return cashReceived - total;
        }
    }
}
