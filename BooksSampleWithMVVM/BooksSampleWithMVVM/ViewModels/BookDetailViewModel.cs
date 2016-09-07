using BooksSampleWithMVVM.Events;
using BooksSampleWithMVVM.Models;
using BooksSampleWithMVVM.Services;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSampleWithMVVM.ViewModels
{
    public class BookDetailViewModel : BindableBase
    {
        private readonly IBooksService _booksService;
        private readonly IEventAggregator _eventAggregator;


        public BookDetailViewModel(IBooksService booksService, IEventAggregator eventAggregator)
        {
            _booksService = booksService;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<SelectBookEvent>().Subscribe(SetSelectedBook);


        }

        private Book _selectedBook;
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set { SetProperty(ref _selectedBook, value); }
        }


        public void SetSelectedBook(int id)
        {
            SelectedBook = _booksService.GetBookById(id);
        }
    }
}
