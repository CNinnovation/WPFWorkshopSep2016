using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSample
{
    public class SomeData : IDataErrorInfo
    {
        private int _val1;

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Val2":
                        if (Val2 > 50)
                        {
                            return "Val2 has a bad value";
                        }
                        break;
                    default:
                        break;
                }
                return null;
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Val1
        {
            get { return _val1; }
            set
            {
                if (value > 50)
                    throw new Exception("bad bad value");
                _val1 = value;
            }
        }

        public int Val2 { get; set; }

    }
}
