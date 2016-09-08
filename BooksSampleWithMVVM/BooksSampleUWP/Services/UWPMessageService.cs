using BooksSampleWithMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BooksSampleUWP.Services
{
    public class UWPMessageService : IMessageService
    {
        public async void ShowMessage(string message)
        {
            await new MessageDialog(message).ShowAsync();
        }
    }
}
