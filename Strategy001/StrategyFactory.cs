using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy001
{
    public static class StrategyFactory
    {
        public static IMyStrategy GetDiscountStrategyFor
            (StrategyType? strategyType)
        {
            switch (strategyType)
            {
                case StrategyType.QuickSortType:
                    return new QuickSort();
                case StrategyType.ShellSortType:
                    return new ShellSort();
                case StrategyType.MergeSortType:
                    return new MergeSort();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}
