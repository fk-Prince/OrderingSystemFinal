using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Payment
{
    public interface IPayment
    {
        string PaymentName { get; }

        InvoiceModel finalizeOrder(OrderModel order, double fee = 0, string type = null);
        InvoiceModel processPayment(OrderModel order, string type);
    }
}
