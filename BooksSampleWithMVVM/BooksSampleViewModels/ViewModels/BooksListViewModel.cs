using BooksSampleWithMVVM.Events;
using BooksSampleWithMVVM.Models;
using BooksSampleWithMVVM.Services;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BooksSampleWithMVVM.ViewModels
{
    public class BooksListViewModel : BindableBase
    {
        private readonly IBooksService _booksService;
        private readonly IMessageService _messageService;
        private readonly IEventAggregator _eventAggregator;

        // Dependency Injection
        public BooksListViewModel(IBooksService booksService, IEventAggregator eventAggregator, IMessageService messageService)
        {
            _booksService = booksService;
            _eventAggregator = eventAggregator;
            _messageService = messageService;

            var books = _booksService.GetBooks();
            Books = new ObservableCollection<Book>(books);

            ShowMessageCommand = new DelegateCommand(OnShowMessage);

        }

        private IEnumerable<Book> _books;
        public IEnumerable<Book> Books
        {
            private set
            {
                SetProperty(ref _books, value);
            }
            get
            {
                return _books;
            }
        }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set {
                if (SetProperty(ref _selectedBook, value))
                {
                    _eventAggregator.GetEvent<SelectBookEvent>().Publish(_selectedBook.BookId);
                }
            }
        }


        public ICommand ShowMessageCommand { get; }

        public void OnShowMessage()
        {
            _messageService.ShowMessage("message from the view-model");
        }
    }
}
