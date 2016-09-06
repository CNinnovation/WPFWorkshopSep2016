using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriorityBindingSample
{
    public class SomeInfo
    {
        public string Info1
        {
            get
            {
                return "Please wait...";
            }
        }

        public string Info2
        {
            get
            {
                Thread.Sleep(2000);
                return "still waiting...";
            }
        }
    }
}
