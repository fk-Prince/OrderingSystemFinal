namespace OrderingSystem.util
{
    public class TaxHelper
    {
        public static double TAX = 0.12;
        public static double TAX_F = 1.12;
        public static double VatCalulator(double totalPrice)
        {
            return totalPrice + (totalPrice * TAX);
        }
    }
}
