namespace OrderingSystem.Model
{
    public class IngredientStockModel : IngredientModel
    {
        public int IngredientStockId { get; set; }

        public interface IIngredientStockModel
        {
            IngredientStockBuilder WithIngredientName(string ingredientName);
            IngredientStockBuilder WithIngredientStockId(int id);
            IngredientStockBuilder SetIngredientQuantity(int ingredientQuantity);
            IngredientStockModel Build();
        }

        public static new IngredientStockBuilder Builder() => new IngredientStockBuilder();


        public class IngredientStockBuilder : IIngredientStockModel
        {
            private IngredientStockModel ingredientStock = new IngredientStockModel();
            public IngredientStockBuilder WithIngredientName(string ingredientName)
            {
                ingredientStock.ingredientName = ingredientName;
                return this;
            }

            public IngredientStockModel Build()
            {
                return ingredientStock;
            }
            public IngredientStockBuilder SetIngredientQuantity(int ingredientQuantity)
            {
                ingredientStock.ingredientQuantity = ingredientQuantity;
                return this;
            }
            public IngredientStockBuilder WithIngredientStockId(int id)
            {
                ingredientStock.IngredientStockId = id;
                return this;
            }
        }
    }
}
