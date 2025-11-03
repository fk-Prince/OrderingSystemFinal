namespace OrderingSystem.Model
{
    public class OrderItemModel
    {

        public int OrderItemId { get; protected set; }
        public int PurchaseQty { get; set; }
        public MenuModel PurchaseMenu { get; protected set; }

        public double getTotal()
        {
            return PurchaseMenu.getPriceAfterDiscount() * PurchaseQty;
        }
        public double getSubtotal()
        {
            return PurchaseMenu.getPriceAfterVatWithDiscount() * PurchaseQty;
        }

        public static OrderItemBuilder Builder() => new OrderItemBuilder();
        public interface IOrderItemBuilder
        {
            OrderItemBuilder WithOrderItemId(int id);
            OrderItemBuilder WithPurchaseMenu(MenuModel meni);
            OrderItemBuilder WithPurchaseQty(int qty);
            OrderItemModel Build();
        }

        public class OrderItemBuilder : IOrderItemBuilder
        {
            public OrderItemModel oim;
            public OrderItemBuilder()
            {
                oim = new OrderItemModel();
            }

            public OrderItemModel Build()
            {
                return oim;
            }
            public OrderItemBuilder WithOrderItemId(int id)
            {
                oim.OrderItemId = id;
                return this;
            }
            public OrderItemBuilder WithPurchaseMenu(MenuModel meni)
            {
                oim.PurchaseMenu = meni;
                return this;
            }
            public OrderItemBuilder WithPurchaseQty(int qty)
            {
                oim.PurchaseQty = qty;
                return this;
            }

        }
    }
}

