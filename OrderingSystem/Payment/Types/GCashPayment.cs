using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Payment
{
    public class GCashPayment : Payment
    {
        public override string PaymentName => "G-Cash";

        public override InvoiceModel processPayment(OrderModel order, string type)
        {
            validateOrder(order);
            return finalizeOrder(order, 0, type);
        }
    }
}
