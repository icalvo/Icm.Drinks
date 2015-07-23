using Icm.Drinks.Domain.Drinks;
using Icm.Drinks.Domain.Ingredients;

namespace Icm.Drinks.Domain.Query
{
    public interface IDrinksByIngredientRepository
    {
        DrinksByIngredient GetById(IngredientId ingredientId);
        void Save(Drink drink);
    }
}