using Icm.Drinks.Domain.Ingredients;

namespace Icm.Drinks.Domain.Drinks
{
    public class IngredientLine
    {


        public IngredientLine(Quantity quantity, IngredientId ingredientId)
        {
            Quantity = quantity;
            IngredientId = ingredientId;
        }

        public Quantity Quantity { get; }
        public IngredientId IngredientId { get; }
    }
}