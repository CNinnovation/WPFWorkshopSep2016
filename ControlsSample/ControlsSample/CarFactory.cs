using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsSample
{
    public delegate void CarInfo(string car);

    public class CarFactory
    {
        //public event CarInfo CarCreated;

        private CarInfo _carCreated;
        public event CarInfo CarCreated
        {
            add
            {
                _carCreated += value;
            }
            remove
            {
                _carCreated -= value;
            }
        }

        public void CreateACar(string car)
        {

        }

        public int MyProperty { get; set; }
    }
}
