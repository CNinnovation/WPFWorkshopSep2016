using BooksSampleViewModels.Services;
using BooksSampleWithMVVM.Services;
using BooksSampleWithMVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BooksSampleWithMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RegisterServices();
        }

        private void RegisterServices()
        {
            var services = new ServiceCollection();
            // services
            services.AddSingleton<IBooksService, BooksService>();
            services.AddSingleton<IMessageService, WPFMessageService>();
            services.AddSingleton<IEventAggregator, EventAggregator>();
            services.AddSingleton<IMyAsyncBooksService, MyAsyncBooksService>();

            // view-models
            services.AddTransient<BooksListViewModel>();
            services.AddTransient<BookDetailViewModel>();
            services.AddTransient<AzureBooksListViewModel>();


            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
