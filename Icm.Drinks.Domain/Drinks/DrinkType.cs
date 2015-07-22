using System;

namespace Icm.Drinks.Domain.Drinks
{
    public class DrinkType
    {
        public DrinkType(string name, string shortDescription, string fullDescription)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(shortDescription))
            {
                throw new ArgumentNullException(nameof(shortDescription));
            }

            if (string.IsNullOrWhiteSpace(fullDescription))
            {
                throw new ArgumentNullException(nameof(fullDescription));
            }

            Name = name;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
        }

        public string Name { get; }
        public string ShortDescription { get; }
        public string FullDescription { get; }
    }
}