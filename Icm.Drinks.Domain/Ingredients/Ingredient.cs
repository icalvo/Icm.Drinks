namespace Icm.Drinks.Domain.Ingredients
{
    public class Ingredient
    {
        public Ingredient(string name, string description)
        {
            Id = new IngredientId();
            Name = name;
            Description = description;
        }

        public IngredientId Id { get; }
        public string Name { get; }
        public string Description { get; }
    }
}