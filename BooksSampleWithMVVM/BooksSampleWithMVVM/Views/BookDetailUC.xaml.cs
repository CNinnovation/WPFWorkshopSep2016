using BooksSampleWithMVVM.ViewModels;
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
using Microsoft.Extensions.DependencyInjection;

namespace BooksSampleWithMVVM.Views
{
    /// <summary>
    /// Interaction logic for BookDetailUC.xaml
    /// </summary>
    public partial class BookDetailUC : UserControl
    {
        public BookDetailUC()
        {

            ViewModel = (Application.Current as App).Container.GetService<BookDetailViewModel>();
            InitializeComponent();

        }

        public BookDetailViewModel ViewModel { get;  }
    }
}
