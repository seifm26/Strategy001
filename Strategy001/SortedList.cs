using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy001
{
    public class SortedList
    {
        private readonly IMyStrategy _myStrategy;

        public SortedList(IMyStrategy myStrategy)
        {
            this._myStrategy = myStrategy;
        }
        public void MyMethod()
        {
            _myStrategy.MyMethod();
        }
    }
}
