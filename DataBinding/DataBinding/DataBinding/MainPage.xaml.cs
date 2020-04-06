using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Book book = new Book() { Author = "John Grisham", Title = "A Time To Kill", Year = 1992, ISBN = "978-1033043294" };
            InitializeComponent();
            BindingContext = book;

            //Binding authorBinding = new Binding();
            //authorBinding.Source = book;
            //authorBinding.Path = "Author";
            //Author.SetBinding(Entry.TextProperty, authorBinding);

            //Binding titleBinding = new Binding();
            //titleBinding.Source = book;
            //titleBinding.Path = "Title";
            //Title.SetBinding(Entry.TextProperty, titleBinding);

            //Author.Text = book.Author;
            //Title.Text = book.Title;
            //Year.Text = book.Year.ToString();
            //ISBN.Text = book.ISBN;
        }
    }
}
