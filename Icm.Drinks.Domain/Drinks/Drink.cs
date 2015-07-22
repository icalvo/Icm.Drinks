using System.Collections.Generic;

namespace Icm.Drinks.Domain.Drinks
{
    public class Drink
    {
        public Drink(string name, DrinkType drinkType, IEnumerable<IngredientLine> ingredients, string instructions)
        {
            Name = name;
            DrinkType = drinkType;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public string Name { get; }
        public DrinkType DrinkType { get; }
        public IEnumerable<IngredientLine> Ingredients { get; }
        public string Instructions { get; }
    }
}