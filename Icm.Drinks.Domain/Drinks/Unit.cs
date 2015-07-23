namespace Icm.Drinks.Domain.Drinks
{
    public class Unit
    {
        private Unit(string name, bool requiresIntegerAmount)
        {
            Name = name;
            RequiresIntegerAmount = requiresIntegerAmount;
        }

        public string Name { get; }

        public static Unit Fractional(string name) => new Unit(name, false);
        public static Unit Integer(string name) => new Unit(name, true);
        public static Unit Ounce { get; } = Fractional("oz");
        public static Unit Drop { get; } = Integer("drop");
        public bool RequiresIntegerAmount { get; }
    }
}