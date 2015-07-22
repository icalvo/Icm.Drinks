namespace Icm.Drinks.Domain.Drinks
{
    public class IngredientLine
    {


        public IngredientLine(Quantity quantity, int ingredientId)
        {
            Quantity = quantity;
            IngredientId = ingredientId;
        }

        public Quantity Quantity { get; }
        public int IngredientId { get; }
    }
}