using BooksSampleWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSampleWithMVVM.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books;

        public BooksService()
        {
            _books = new List<Book>()
            {
                new Book("Professional C# 6", "Wrox Press", "Christian Nagel"),
                new Book("Professional C# 5.0", "Wrox Press", "Christian Nagel", "Jay Glynn", "Morgan Skinner"),
                new Book("Beginning Visual C# 2013", "Wrox Press", "Karli Watson", "Christian Nagel"),
                new Book("Enterprise Services", "AWL", "Christian Nagel")
            };
        }

        public IEnumerable<Book> GetBooks() => _books;
    }
}
