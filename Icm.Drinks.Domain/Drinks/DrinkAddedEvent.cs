namespace Icm.Drinks.Domain.Drinks
{
    public class DrinkAddedEvent
    {
        public DrinkAddedEvent(Drink drink)
        {
            Drink = drink;
        }

        public Drink Drink { get; }
    }
}