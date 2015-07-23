namespace Icm.Drinks.Domain.Ingredients
{
    public interface IIngredientRepository
    {
        void Add(Ingredient ingredient);
        Ingredient GetById(IngredientId id);
        Ingredient GetByName(string name);
        void Remove(Ingredient ingredient);
    }
}