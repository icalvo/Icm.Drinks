using System.Collections.Generic;
using System.Linq;
using Icm.Drinks.Domain.Drinks;
using Icm.Drinks.Domain.Ingredients;

namespace Icm.Drinks.Domain.Query
{
    public class DrinkAddedEventHandler
    {
        private readonly IDrinksByIngredientRepository _drinksByIngredientRepository;

        public DrinkAddedEventHandler(IEventBus eventBus, IDrinksByIngredientRepository drinksByIngredientRepository)
        {
            _drinksByIngredientRepository = drinksByIngredientRepository;
            eventBus.Register<DrinkAddedEvent>(Handle);
        }

        private void Handle(DrinkAddedEvent eventToHandle)
        {
            Drink drink = eventToHandle.Drink;
            foreach (IngredientId ingredientId in drink.Ingredients.Select(x => x.IngredientId))
            {
                DrinksByIngredient drinksByIngredient = _drinksByIngredientRepository.GetById(ingredientId);
                drinksByIngredient.AddDrink(drink);
                _drinksByIngredientRepository.Save(drink);

            }
        }
    }

    public class DrinksByIngredient
    {
        private readonly HashSet<Drink> _drinks;

        public DrinksByIngredient(IngredientId ingredientId)
        {
            IngredientId = ingredientId;
            _drinks = new HashSet<Drink>();
        }

        public IngredientId IngredientId { get; }

        public IEnumerable<Drink> Drinks => _drinks;

        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
        }
    }
}