using BooksSampleWithMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Extensions.DependencyInjection;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace BooksSampleUWP.Views
{
    public sealed partial class BooksListUC : UserControl
    {
        public BooksListUC()
        {
            ViewModel = (Application.Current as App).Container.GetService<BooksListViewModel>();

            this.InitializeComponent();


        }

        public BooksListViewModel ViewModel { get; }
    }
}
