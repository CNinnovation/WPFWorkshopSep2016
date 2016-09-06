using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayBindingSample
{
    public class SomeData
    {
        private ObservableCollection<string> _coll1 = new ObservableCollection<string>();

        private string _value1;

        public string Value1
        {
            get { return _value1; }
            set { _value1 = value;
                _coll1.Add(value);
            }
        }

        private string _value2;

        public string Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }

        public IEnumerable<string> Info => _coll1;


    }
}
