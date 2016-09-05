using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAMLAttachedProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas.SetTop(button1, 100);
        }

        public int Val1 { get; set; }

        private int val2;

        public int Val2
        {
            get { return val2; }
            set { val2 = value; }
        }



        public int Val3
        {
            get { return (int)GetValue(Val3Property); }
            set { SetValue(Val3Property, value); }
        }

        // Using a DependencyProperty as the backing store for Val3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Val3Property =
            DependencyProperty.Register("Val3", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



    }
}
