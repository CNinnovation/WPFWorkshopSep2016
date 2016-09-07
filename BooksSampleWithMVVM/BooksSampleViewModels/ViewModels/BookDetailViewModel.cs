using BooksSampleViewModels.Events;
using BooksSampleWithMVVM.Events;
using BooksSampleWithMVVM.Models;
using BooksSampleWithMVVM.Services;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

            CreateCommand = new DelegateCommand(OnCreateBook);
            CancelCommand = new DelegateCommand(OnCancel);
            SaveCommand = new DelegateCommand(OnSave);
        }



        public ICommand CreateCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand SaveCommand { get; }

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
        private bool _createdNew = false;
        public void OnCreateBook()
        {
            _createdNew = true;
            SelectedBook = new Book(_booksService.NextId(), string.Empty, string.Empty);
        }

        public void OnCancel()
        {
            SelectedBook = null;
            _createdNew = false;
        }

        public void OnSave()
        {
            if (_createdNew)
            {
                _booksService.AddBook(SelectedBook);
                _createdNew = false;
                _eventAggregator.GetEvent<RefreshBooksEvent>().Publish();
            }
            else
            {
                _booksService.UpdateBook(SelectedBook);
            }
        }
    }
}
