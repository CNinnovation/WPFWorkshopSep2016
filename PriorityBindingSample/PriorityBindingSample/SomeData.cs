using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriorityBindingSample
{
    public class SomeData
    {
        public string Value1
        {
            get
            {
                Thread.Sleep(5000);
                return "the result is here";
            }
        }
    }
}
