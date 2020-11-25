using System.Collections.Generic;

namespace Cocktail_Catalog
{
    public class CocktailDbResponse
    {
        public CocktailDrink[] Drinks { get; set; }
    }

    public class CocktailDrink
    {
        public string IdDrink { get; set; }
        public string StrDrink { get; set; }
        public string StrAlchoholic { get; set; }
        public string StrGlass { get; set; }
        public string StrInstructions { get; set; }
        public string StrDrinkThumb { get; set; }
        public string StrIngredient1 { get; set; }
        public string StrIngredient2 { get; set; }
        public string StrIngredient3 { get; set; }
        public string StrIngredient4 { get; set; }
        public string StrIngredient5 { get; set; }
        public string StrIngredient6 { get; set; }
        public string StrIngredient7 { get; set; }
        public string StrIngredient8 { get; set; }
        public string StrIngredient9 { get; set; }
        public string StrIngredient10 { get; set; }
        public string StrIngredient11 { get; set; }
        public string StrIngredient12 { get; set; }
        public string StrIngredient13 { get; set; }
        public string StrIngredient14 { get; set; }
        public string StrIngredient15 { get; set; }

        public string StrMeasure1 { get; set; }
        public string StrMeasure2 { get; set; }
        public string StrMeasure3 { get; set; }
        public string StrMeasure4 { get; set; }
        public string StrMeasure5 { get; set; }
        public string StrMeasure6 { get; set; }
        public string StrMeasure7 { get; set; }
        public string StrMeasure8 { get; set; }
        public string StrMeasure9 { get; set; }
        public string StrMeasure10 { get; set; }
        public string StrMeasure11 { get; set; }
        public string StrMeasure12 { get; set; }
        public string StrMeasure13 { get; set; }
        public string StrMeasure14 { get; set; }
        public string StrMeasure15 { get; set; }

        public List<IngredientAndMeasure> Ingredients
        {
            get
            {
                List<IngredientAndMeasure> ingredients = GetIngredientsAndMeasuresAsList();

                return ingredients;
            }
        }

        private List<IngredientAndMeasure> GetIngredientsAndMeasuresAsList()
        {
            List<IngredientAndMeasure> ingredients = new List<IngredientAndMeasure>();
            if (!string.IsNullOrEmpty(StrIngredient1))
                AddIngredientAndMeasure(ingredients, StrIngredient1, StrMeasure1);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient2))
                AddIngredientAndMeasure(ingredients, StrIngredient2, StrMeasure2);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient3))
                AddIngredientAndMeasure(ingredients, StrIngredient3, StrMeasure3);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient4))
                AddIngredientAndMeasure(ingredients, StrIngredient4, StrMeasure4);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient5))
                AddIngredientAndMeasure(ingredients, StrIngredient5, StrMeasure5);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient6))
                AddIngredientAndMeasure(ingredients, StrIngredient6, StrMeasure6);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient7))
                AddIngredientAndMeasure(ingredients, StrIngredient7, StrMeasure7);
            else return ingredients;
            
            if (!string.IsNullOrEmpty(StrIngredient8))
                AddIngredientAndMeasure(ingredients, StrIngredient8, StrMeasure8);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient9))
                AddIngredientAndMeasure(ingredients, StrIngredient9, StrMeasure9);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient10))
                AddIngredientAndMeasure(ingredients, StrIngredient10, StrMeasure10);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient11))
                AddIngredientAndMeasure(ingredients, StrIngredient11, StrMeasure11);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient12))
                AddIngredientAndMeasure(ingredients, StrIngredient12,StrMeasure12);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient13))
                AddIngredientAndMeasure(ingredients, StrIngredient13,StrMeasure13);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient14))
                AddIngredientAndMeasure(ingredients, StrIngredient14,StrMeasure14);
            else return ingredients;

            if (!string.IsNullOrEmpty(StrIngredient15))
                AddIngredientAndMeasure(ingredients, StrIngredient15,StrMeasure15);

            return ingredients;
        }
        private void AddIngredientAndMeasure(List<IngredientAndMeasure> list, string ingredient, string measure)
        {
            list.Add(new IngredientAndMeasure
            {
                Ingredient = ingredient,
                Measure = measure
            });
        }
    }

    public class IngredientAndMeasure
    {
        public string Ingredient { get; set; }
        public string Measure { get; set; }
    }
}
