using BooksSampleWithMVVM.Models;
using BooksSampleWithMVVM.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TheBestMVVMFrameworkInTown;

namespace BooksSampleWithMVVM.ViewModels
{
    public class BooksListViewModel : BindableBase
    {
        private readonly IBooksService _booksService;
        private readonly IMessageService _messageService;

        // Dependency Injection
        public BooksListViewModel(IBooksService booksService, IMessageService messageService)
        {
            _booksService = booksService;
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

        public ICommand ShowMessageCommand { get; }

        public void OnShowMessage()
        {
            _messageService.ShowMessage("message from the view-model");
        }
    }
}
