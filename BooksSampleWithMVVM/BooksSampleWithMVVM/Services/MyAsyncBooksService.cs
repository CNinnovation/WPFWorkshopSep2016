using BooksSampleViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureBooks.Models;
using AzureBooks;

namespace BooksSampleWithMVVM.Services
{
    public class MyAsyncBooksService : IMyAsyncBooksService
    {
        public Task AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            Unknowntype proxy = new Unknowntype();
            IEnumerable<Book> books = await proxy.Books.GetBooksAsync();
            return books;
        }

        public Task UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
