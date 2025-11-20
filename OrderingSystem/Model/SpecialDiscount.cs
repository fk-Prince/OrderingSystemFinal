namespace OrderingSystem.Model
{
    public class SpecialDiscount
    {
        public SpecialDiscount(int specialDiscountId, string discountName, double discountRate)
        {
            this.specialDiscountId = specialDiscountId;
            this.discountName = discountName;
            this.discountRate = discountRate;
        }

        public int specialDiscountId { get; set; }
        public string discountName { get; set; }
        public double discountRate { get; set; }
    }
}
