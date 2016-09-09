using AzureBooks.Models;
using BooksSampleViewModels.Events;
using BooksSampleViewModels.Services;
using BooksSampleWithMVVM.Events;
using BooksSampleWithMVVM.Services;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BooksSampleWithMVVM.ViewModels
{
    public class AzureBooksListViewModel : BindableBase
    {
        private readonly IMyAsyncBooksService _booksService;
        private readonly IMessageService _messageService;
        private readonly IEventAggregator _eventAggregator;

        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();

        // Dependency Injection
        public AzureBooksListViewModel(IMyAsyncBooksService booksService, IEventAggregator eventAggregator, IMessageService messageService)
        {
            _booksService = booksService;
            _eventAggregator = eventAggregator;
            _messageService = messageService;

            RefreshBooks();

            _eventAggregator.GetEvent<RefreshBooksEvent>().Subscribe(RefreshBooks);

            ShowMessageCommand = new DelegateCommand(OnShowMessage);

        }

        public async void RefreshBooks()
        {
            _books.Clear();
            var books = await _booksService.GetBooksAsync();
            foreach (var b in books)
            {
                _books.Add(b);
            }
        }

        public IEnumerable<Book> Books => _books;


        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set {
                if (SetProperty(ref _selectedBook, value))
                {
                    _eventAggregator.GetEvent<SelectBookEvent>().Publish(_selectedBook.Id.Value);
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
