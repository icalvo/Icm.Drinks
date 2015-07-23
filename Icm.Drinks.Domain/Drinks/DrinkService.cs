namespace Icm.Drinks.Domain.Drinks
{
    public class DrinkService
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly IEventBus _eventBus;

        public DrinkService(IDrinkRepository drinkRepository, IEventBus eventBus)
        {
            _drinkRepository = drinkRepository;
            _eventBus = eventBus;
        }

        public void AddDrink(Drink drink)
        {
            _drinkRepository.Add(drink);
            _eventBus.Send(new DrinkAddedEvent(drink));
        }
    }
}
