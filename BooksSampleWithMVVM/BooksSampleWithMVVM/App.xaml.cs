using BooksSampleWithMVVM.Services;
using BooksSampleWithMVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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

            // view-models
            services.AddTransient<BooksListViewModel>();


            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
