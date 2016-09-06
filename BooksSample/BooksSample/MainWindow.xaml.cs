using BooksSample.Models;
using BooksSample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> somestrings = new ObservableCollection<string>() { "one", "two" };
        private Book _theBook;
        private ObservableCollection<Book> _booksList;

        public MainWindow()
        {
            InitializeComponent();
            //list1.Items.Add("one");
            //list1.Items.Add("two");
            //list2.ItemsSource = somestrings;

            _theBook = new BooksService().GetTheBook();
            _booksList = new ObservableCollection<Book>(new BooksService().GetBooks());
            this.DataContext = _booksList;
        }

        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_theBook?.Title, _theBook?.Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            // _theBook.Title = "Professional C# 7.0";
            _booksList.First().Title = "Professional C# 7.0";
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            _booksList.Add(new Book { Title = "Programming Universal Apps", Publisher = "Self" });
        }
    }
}
