using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Services
{
    public class BooksService
    {
        public Book GetTheBook() =>
            new Book { Title = "Professional C# 6", Publisher = "Wrox Press" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book { Title = "Professional C# 6", Publisher = "Wrox Press" },
                new Book { Title = "Beginning Visual C# 6", Publisher = "Wrox Press" },
                new Book { Title = "Enterprise Services", Publisher = "AWL" }
            };
    }
}
