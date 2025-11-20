using System;
using OrderingSystem.CashierApp.SessionData;
using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Payment
{
    public abstract class Payment : IPayment
    {
        public abstract string PaymentName { get; }

        public virtual InvoiceModel processPayment(OrderModel order, string type)
        {
            validateOrder(order);
            return finalizeOrder(order, 0, type);
        }
        public virtual void validateOrder(OrderModel order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            if (string.IsNullOrWhiteSpace(order.OrderId))
                throw new ArgumentException("Invalid order ID.");
        }
        public virtual InvoiceModel finalizeOrder(OrderModel order, double fee = 0, string type = "")
        {
            double total;

            if (type.ToLower() == "pwd" && type.ToLower() == "senior citizen")
                total = order.getTotalDiscount();
            else
                total = order.GetTotalWithVAT() + (1 * fee);

            InvoiceModel i = new InvoiceModel(order.OrderId, order, SessionStaffData.StaffData, this, total, type);
            return i;
        }
    }
}
