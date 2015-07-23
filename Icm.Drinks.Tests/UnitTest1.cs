using System;
using Icm.Drinks.Domain;
using Icm.Drinks.Domain.Drinks;
using Icm.Drinks.Domain.Ingredients;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Icm.Drinks.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dryVermouth = new Ingredient("Dry Vermouth", "Dry white wine infused with herbs.");
            var gin = new Ingredient("Gin", "Genever fruit distillation");
            var bitters = new Ingredient("Orange bitters", "Preparation of orange and bitter herbs");

            var dryMartini = new Drink("Dry Martini", DrinkType.Cocktail, "asf");
            dryMartini.AddIngredient(dryVermouth, new Quantity(Unit.Ounce, 3, 4));
            dryMartini.AddIngredient(gin, new Quantity(Unit.Ounce, 2));
            dryMartini.AddIngredient(bitters, new Quantity(Unit.Drop, 4));

            
        }
    }
}
