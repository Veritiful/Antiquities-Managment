using System;
using System.Collections.Generic;
using System.Drawing;
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
        List<string> chapters;

        //Default constructor
        public Book() : base()
        {
            this.amountOfPages = 0;
            this.contentLanguage = "null";
            this.author = "null";
            this.hardCover = false;
            this.chapters = new List<string>();
        }

        //Parametrized constructor
        public Book(int yearPublished, string title, string sellerPesel, string sellerName, string sellerEmail, string country, string city, float price, bool isAvailable, DateTime sellerBirthDate, Bitmap itemPicture, int amountOfPages, string contentLanguage, string author, bool hardCover, string chapters) : base(yearPublished, title, sellerPesel, sellerName, sellerEmail, country, city, price, isAvailable, sellerBirthDate, itemPicture)
        {
            this.amountOfPages = amountOfPages;
            this.contentLanguage = contentLanguage;
            this.author = author;
            this.hardCover = hardCover;
            this.chapters = chapters.Split('#').ToList();
        }

        //Duplicating constructor
        public Book(Book book) : base(book)
        {
            this.amountOfPages = book.amountOfPages;
            this.contentLanguage = book.contentLanguage;
            this.author = book.author;
            this.hardCover = book.hardCover;
        }

        override public void Write(ListBox lb)
        {
            base.Write(lb);
            lb.Items.Add("Offer:\t" + ReturnBookType() + " " + ReturnBookContent());
            lb.Items.Add("Chapters:\t" + String.Join(" -> ", chapters));
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
