using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy001
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = StrategyFactory.GetDiscountStrategyFor(
                StrategyType.QuickSortType);
            ms.MyMethod();
            var sl = new SortedList(
                StrategyFactory.GetDiscountStrategyFor(
                    StrategyType.QuickSortType));
            sl.MyMethod();
            Console.ReadKey();
        }
    }
}
