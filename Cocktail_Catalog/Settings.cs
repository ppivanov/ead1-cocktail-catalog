namespace Cocktail_Catalog
{
    public class Settings
    {
        public BaseURLs BaseURLs { get; set; }
    }

    public class BaseURLs
    {
        public string CocktailDb { get; set; }
        public string JokeDb { get; set; }
    }
}
