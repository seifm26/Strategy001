using System;

namespace Strategy001
{
    public class NullDiscountStrategy:IMyStrategy
    {
        public void MyMethod()
        {
            Console.WriteLine("Do nothing");
        }
    }
}
