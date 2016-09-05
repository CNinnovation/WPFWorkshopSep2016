using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleEditor
{
    public static class MyCustomCommands
    {
        private static ICommand _action1;
        public static ICommand Action1
        {
            get
            {
                return _action1 ?? (_action1 = new RoutedUICommand(nameof(Action1), nameof(Action1), typeof(MyCustomCommands)));
            }
        }
    }
}
