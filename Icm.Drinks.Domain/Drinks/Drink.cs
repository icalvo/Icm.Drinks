using System.Collections.Generic;
using Icm.Drinks.Domain.Ingredients;

namespace Icm.Drinks.Domain.Drinks
{
    public class Drink
    {
        private readonly HashSet<IngredientLine> _ingredients;

        public Drink(string name, DrinkType drinkType, string instructions)
        {
            Name = name;
            DrinkType = drinkType;
            _ingredients = new HashSet<IngredientLine>();
            Instructions = instructions;
        }

        public string Name { get; }
        public DrinkType DrinkType { get; }

        public IEnumerable<IngredientLine> Ingredients => _ingredients;

        public void AddIngredient(IngredientLine ingredientLine)
        {
            _ingredients.Add(ingredientLine);
        }

        public void AddIngredient(Ingredient ingredient, Quantity quantity)
            => AddIngredient(new IngredientLine(quantity, ingredient.Id));

        public string Instructions { get; }
    }
}