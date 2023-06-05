using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable_Sorting
{
    internal class CoffeeMugSortColor : IComparer<CoffeeMug>
    {
        public int Compare(CoffeeMug x, CoffeeMug y)
        {
            return x.Color.CompareTo(y.Color);
        }
    }
}
