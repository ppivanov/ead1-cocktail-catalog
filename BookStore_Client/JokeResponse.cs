using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cocktail_Catalog
{
    public class ChuckNorrisJokeResponse
    {
        public string Type { get; set; }

        public TheJoke Value { get; set; }
    }

    public class TheJoke
    {
        public string Joke { get; set; }
    }
}
