using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexii_Zaretski
{
    public abstract class Item
    {
        int id;
        int yearPublished;
        string title;
        string sellerPesel;
        string sellerName;
        string sellerEmail;
        string country;
        string city;
        float price;
        bool isAvailable;

        DateTime sellerBirthDate;
        Bitmap itemPicture;

        static int amountOfItems = 0;

        //Default constructor
        public Item()
        {
            amountOfItems++;
            this.id = amountOfItems;
            this.id = 0;
            this.yearPublished = 0;
            this.title = "null";
            this.sellerPesel = "null";
            this.sellerName = "null";
            this.sellerEmail = "null";
            this.country = "null";
            this.city = "null";
            this.price = 0f;
            this.isAvailable = false;
            this.sellerBirthDate = new DateTime(0);
            this.itemPicture = new Bitmap(32, 32);
        }

        //Parametrized constructor
        public Item(int yearPublished, string title, string sellerPesel, string sellerName, string sellerEmail, string country, string city, float price, bool isAvailable, DateTime sellerBirthDate, Bitmap itemPicture)
        {
            amountOfItems++;
            this.id = amountOfItems;
            this.yearPublished = yearPublished;
            this.title = title;
            this.sellerPesel = sellerPesel;
            this.sellerName = sellerName;
            this.sellerEmail = sellerEmail;
            this.country = country;
            this.city = city;
            this.price = price;
            this.isAvailable = isAvailable;
            this.sellerBirthDate = sellerBirthDate;
            this.itemPicture = itemPicture;
        }

        //Duplicating constructor
        public Item(Item item)
        {
            amountOfItems++;
            this.id = amountOfItems;
            this.yearPublished = item.yearPublished;
            this.title = item.title;
            this.sellerPesel = item.sellerPesel;
            this.sellerName = item.sellerName;
            this.sellerEmail = item.sellerEmail;
            this.country = item.country;
            this.city = item.city;
            this.price = item.price;
            this.isAvailable = item.isAvailable;
            this.sellerBirthDate = item.sellerBirthDate;
            this.itemPicture = item.itemPicture;
        }

        //Destructor
        ~Item()
        {
            MessageBox.Show("Destruction of the object");
        }

        public virtual void Write(ListBox lb)
        {
            lb.Items.Add("ID:\t" + id);
            lb.Items.Add("Year published:\t" + yearPublished);
            lb.Items.Add("Title:\t" + title);
            lb.Items.Add("Seller's pesel:\t" + sellerPesel);
            lb.Items.Add("Seller's name:\t" + sellerName);
            lb.Items.Add("Seller's email:\t" + sellerEmail);
            lb.Items.Add("Seller's birth date:\t" + sellerBirthDate.ToString("dd/MM/yyyy"));
            lb.Items.Add("Location:\t" + ReturnItemLocation());
            lb.Items.Add("Price:\t" + price);
            lb.Items.Add("Is available:\t" + isAvailable);
        }

        public virtual void Write(ListBox lb, PictureBox pb)
        {
            lb.Items.Add("ID:\t" + id);
            lb.Items.Add("Year published:\t" + yearPublished);
            lb.Items.Add("Title:\t" + title);
            lb.Items.Add("Seller's pesel:\t" + sellerPesel);
            lb.Items.Add("Seller's name:\t" + sellerName);
            lb.Items.Add("Seller's email:\t" + sellerEmail);
            lb.Items.Add("Seller's birth date:\t" + sellerBirthDate.ToString("dd/MM/yyyy"));
            lb.Items.Add("Location:\t" + ReturnItemLocation());
            lb.Items.Add("Price:\t" + price);
            lb.Items.Add("Is available:\t" + isAvailable);
            pb.Image = itemPicture;
        }

        private int yearsOnShowcase()
        {
            return DateTime.Now.Year - yearPublished;
        }

        private string ReturnItemLocation()
        {
            return city + ", " + country;
        }
    }
}
