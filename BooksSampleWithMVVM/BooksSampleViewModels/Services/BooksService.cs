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
                new Book(1, "Professional C# 6", "Wrox Press", "Christian Nagel"),
                new Book(2, "Professional C# 5.0", "Wrox Press", "Christian Nagel", "Jay Glynn", "Morgan Skinner"),
                new Book(3, "Beginning Visual C# 2013", "Wrox Press", "Karli Watson", "Christian Nagel"),
                new Book(4, "Enterprise Services", "AWL", "Christian Nagel")
            };
        }

        public IEnumerable<Book> GetBooks() => _books;

        public Book GetBookById(int id) => _books.SingleOrDefault(b => b.BookId == id);
    }
}
