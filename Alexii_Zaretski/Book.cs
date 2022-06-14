using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexii_Zaretski
{
    class Book : Item
    {
        int amountOfPages;
        string contentLanguage;
        string author;
        bool hardCover;

        //Default constructor
        public Book() : base()
        {
            this.amountOfPages = 0;
            this.contentLanguage = "null";
            this.author = "null";
            this.hardCover = false;
        }

        //Parametrized constructor
        public Book(int yearPublished, string title, string sellerPesel, string sellerName, string sellerEmail, string country, string city, float price, bool isAvailable, int amountOfPages, string contentLanguage, string author, bool hardCover) : base(yearPublished, title, sellerPesel, sellerName, sellerEmail, country, city, price, isAvailable)
        {
            this.amountOfPages = amountOfPages;
            this.contentLanguage = contentLanguage;
            this.author = author;
            this.hardCover = hardCover;
        }

        //Duplicating constructor
        public Book(Book book) : base(book)
        {
            this.amountOfPages = book.amountOfPages;
            this.contentLanguage = book.contentLanguage;
            this.author = book.author;
            this.hardCover = book.hardCover;
        }

        public void Write(ListBox lb)
        {
            base.Write(lb);
            lb.Items.Add("Offer:\t" + ReturnBookType() + " " + ReturnBookContent());
        }

        private string ReturnBookType()
        {
            if (hardCover) return amountOfPages + " pages with hard cover";
            else return amountOfPages + " pages with hard cover";
        }

        private string ReturnBookContent()
        {
            return "book in " + contentLanguage + " by " + author;
        }
    }
}
