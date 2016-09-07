using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSampleWithMVVM.Models
{
    public class Book : BindableBase
    {
        //public string Title { get; set; }
        //public string Publisher { get; set; }

        public Book()
        {

        }

        public Book(int id, string title, string publisher, params string[] authors)
        {
            BookId = id;
            Title = title;
            Publisher = publisher;
            Authors = authors;
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set
            {
                SetProperty(ref _publisher, value);
            }
        }

        public int BookId { get;  }

        public string[] Authors { get; set; }



        public override string ToString() => Title;

    }
}
