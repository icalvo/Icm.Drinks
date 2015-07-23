namespace Icm.Drinks.Domain.Drinks
{
    public interface IDrinkRepository
    {
        void Add(Drink drink);
        Drink GetByName(string name);
        void Remove(Drink drink);
    }
}