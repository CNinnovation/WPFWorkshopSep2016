﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AzureBooks;
using AzureBooks.Models;
using Microsoft.Rest;

namespace AzureBooks
{
    public static partial class BooksExtensions
    {
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Book DeleteBook(this IBooks operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBooks)s).DeleteBookAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Book> DeleteBookAsync(this IBooks operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<AzureBooks.Models.Book> result = await operations.DeleteBookWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Book GetBook(this IBooks operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBooks)s).GetBookAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Book> GetBookAsync(this IBooks operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<AzureBooks.Models.Book> result = await operations.GetBookWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        public static IList<Book> GetBooks(this IBooks operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBooks)s).GetBooksAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Book>> GetBooksAsync(this IBooks operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<AzureBooks.Models.Book>> result = await operations.GetBooksWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='book'>
        /// Required.
        /// </param>
        public static Book PostBook(this IBooks operations, Book book)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBooks)s).PostBookAsync(book);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='book'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Book> PostBookAsync(this IBooks operations, Book book, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<AzureBooks.Models.Book> result = await operations.PostBookWithOperationResponseAsync(book, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='book'>
        /// Required.
        /// </param>
        public static object PutBook(this IBooks operations, int id, Book book)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBooks)s).PutBookAsync(id, book);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureBooks.IBooks.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='book'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutBookAsync(this IBooks operations, int id, Book book, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutBookWithOperationResponseAsync(id, book, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
