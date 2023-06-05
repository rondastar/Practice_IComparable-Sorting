using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace Practice_IComparable_Sorting
{
    internal class Program
    {
        static List<CoffeeMug> _mugs = new List<CoffeeMug>();
        static void Main(string[] args)
        {
            Preload();
            // Displays items in _mugs once without sorting
            Console.WriteLine("--NO SORTING--");
            DisplayMugs();
            // Sorts items in _mugs by size using the .Sort() method
            SortBySize();
            Console.WriteLine("--SORTED BY SIZE--");
            DisplayMugs();
            // Sorts items in _mugs by color alphabetically
            _mugs.Sort(new CoffeeMugSortColor());
            Console.WriteLine("--SORTED BY COLOR--");
            DisplayMugs();
            // Sorts items in _mugs by price, descending
            _mugs.Sort(new CoffeeMugSortPriceDesc());
            Console.WriteLine("--SORTED BY PRICE, HIGHEST TO LOWEST--");
            DisplayMugs();
        }
        public static void Preload()
        { // Populates the _mugs list with 5 mugs
            _mugs.Add(new CoffeeMug("classic", "maroon", 12, "classic", "ceramic", (decimal)9.99));
            _mugs.Add(new CoffeeMug("2 separate fingers", "green", 8, "short", "ceramic", (decimal)12.99));
            _mugs.Add(new CoffeeMug("classic", "blue", 10, "tumbler", "metal", (decimal)19.99));
            _mugs.Add(new CoffeeMug("classic", "grey", 8, "camping mug", "tin", (decimal)10.99));
            _mugs.Add(new CoffeeMug("handwarmer", "black", 18, "tumbler", "ceramic", (decimal)16.99));
            
        }
        public static void DisplayMugs()
        {
            // Displays each item in _mugs in order
            foreach(CoffeeMug mug in _mugs)
            {
                Console.WriteLine(mug.ToString());
            }
            Console.WriteLine("");
        }
        public static void SortBySize()
        {
            // Sorts _mugs by size, ascending
            _mugs.Sort();
        }
    }
}
