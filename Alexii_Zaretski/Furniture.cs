using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexii_Zaretski
{
    class Furniture : Item
    {
        float height;
        float width;
        float length;
        string material;

        //Default constructor
        public Furniture() : base()
        {
            this.height = 0f;
            this.width = 0f;
            this.length = 0f;
            this.material = "null";
        }

        //Parametrized constructor
        public Furniture(int yearPublished, string title, string sellerPesel, string sellerName, string sellerEmail, string country, string city, float price, bool isAvailable, DateTime sellerBirthDate, Bitmap itemPicture, float height, float width, float length, string material) : base(yearPublished, title, sellerPesel, sellerName, sellerEmail, country, city, price, isAvailable, sellerBirthDate, itemPicture)
        {
            this.height = height;
            this.width = width;
            this.length = length;
            this.material = material;
        }

        //Duplicating constructor
        public Furniture(Furniture furniture) : base(furniture)
        {
            this.height = furniture.height;
            this.width = furniture.width;
            this.length = furniture.length;
            this.material = furniture.material;
        }

        override public void Write(ListBox lb)
        {
            base.Write(lb);
            lb.Items.Add("Dimensions:\t" + ReturnDimensions());
            lb.Items.Add("Estimated volume:\t" + ReturnVolume());
        }

        private string ReturnDimensions()
        {
            return height + "mm X " + width + "mm X " + length + "mm";
        }

        private float ReturnVolume()
        {
            return height * width * length;
        }
    }
}
