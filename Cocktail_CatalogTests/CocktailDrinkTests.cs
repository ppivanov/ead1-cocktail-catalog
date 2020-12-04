using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Cocktail_Catalog.Tests
{
    [TestClass()]
    [ExcludeFromCodeCoverage]
    public class CocktailDrinkTests
    {
        [TestMethod()]
        public void IgredientsList_NoIngredients_EmptyList()
        {
            CocktailDrink testDrink = new CocktailDrink();

            int expectedElementCount = 0;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_OneIngredients_OneListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a"
            };

            int expectedElementCount = 1;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_TwoIngredients_TwoListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a"
            };

            int expectedElementCount = 2;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_ThreeIngredients_ThreeListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a"
            };

            int expectedElementCount = 3;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_FourIngredients_FourListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a"
            };

            int expectedElementCount = 4;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_FiveIngredients_FiveListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a"
            };

            int expectedElementCount = 5;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_SixIngredients_SixListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a"
            };

            int expectedElementCount = 6;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_SevenIngredients_SevenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a"
            };

            int expectedElementCount = 7;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_EightIngredients_EightListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a"
            };

            int expectedElementCount = 8;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_NineIngredients_NineListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a"
            };

            int expectedElementCount = 9;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_TenIngredients_TenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a"
            };

            int expectedElementCount = 10;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_ElevenIngredients_ElevenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a",
                StrIngredient11 = "a"
            };

            int expectedElementCount = 11;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_TwelveIngredients_TwelveListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a",
                StrIngredient11 = "a",
                StrIngredient12 = "a"
            };

            int expectedElementCount = 12;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_ThirteenIngredients_ThirteenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a",
                StrIngredient11 = "a",
                StrIngredient12 = "a",
                StrIngredient13 = "a"
            };

            int expectedElementCount = 13;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_FourteenIngredients_FourteenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a",
                StrIngredient11 = "a",
                StrIngredient12 = "a",
                StrIngredient13 = "a",
                StrIngredient14 = "a"
            };

            int expectedElementCount = 14;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }

        [TestMethod()]
        public void IgredientsList_FifteenIngredients_FifteenListElements()
        {
            CocktailDrink testDrink = new CocktailDrink()
            {
                StrIngredient1 = "a",
                StrIngredient2 = "a",
                StrIngredient3 = "a",
                StrIngredient4 = "a",
                StrIngredient5 = "a",
                StrIngredient6 = "a",
                StrIngredient7 = "a",
                StrIngredient8 = "a",
                StrIngredient9 = "a",
                StrIngredient10 = "a",
                StrIngredient11 = "a",
                StrIngredient12 = "a",
                StrIngredient13 = "a",
                StrIngredient14 = "a",
                StrIngredient15 = "a"
            };

            int expectedElementCount = 15;
            int actualElementCount = testDrink.Ingredients.Count;

            Assert.AreEqual(expectedElementCount, actualElementCount);
        }
    }
}