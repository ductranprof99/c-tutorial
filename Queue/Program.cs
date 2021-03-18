using System;
using System.Collections.Generic;
using Queue;
using System.Linq;
namespace Omaewa
{
    class Program
    {
        public static void Main(string[] args)
        {
            var movies = new List<Movie>{
                new Movie{title = "The bat man",rating=6.0f, year= 2069},
                new Movie{title = "Casablance"  , rating=6.1f, year= 1968},
                new Movie{title = " The fucker 3", rating=6.2f, year= 2096},
                new Movie{title = "The fucker 4", rating=6.3f, year= 3218}
            };
            var query1 = from movie in movies where movie.year > 2000
                         where movie.year < 3000 select movie;

                         
            foreach (var item in query1)
            {
                Console.WriteLine(item.title + " || " + item.rating + " || " + item.year );
            }
            var query2 = movies.Filter(x => search(x));
            foreach (var item in query2)
            {
                Console.WriteLine(item.title + " || " + item.rating + " || " + item.year );
            }
        }
        public static bool search(Movie item)
        {
            if(item.year > 2000 && item.year < 3000) return true;
            return false;
        }
    }
}