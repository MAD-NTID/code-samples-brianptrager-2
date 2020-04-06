using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBinding
{
    class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string author;
        public string Author
        {
            get { return author; }
            set
            {
                if (value != author)
                {
                    author = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
                }
            }
        }
        
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

    }
}
