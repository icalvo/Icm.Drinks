using System;

namespace Icm.Drinks.Domain.Ingredients
{
    public class IngredientId
    {
        public IngredientId()
        {
            Value = new Guid();
        }

        public IngredientId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }
    }
}