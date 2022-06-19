using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexii_Zaretski
{
    public partial class FurnitureForm : Form
    {
        public FurnitureForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Furniture furniture = new Furniture(Convert.ToInt32(Math.Round(yearNumeric.Value, 0)), titleTextBox.Text, peselMasked.Text, nameTextBox.Text, emailTextBox.Text, countryTextBox.Text, cityTextBox.Text, Convert.ToSingle(priceNumeric.Value), isAvailableCheck.Checked, dateTimePicker.Value, new Bitmap(pictureBox1.Image), Convert.ToSingle(heightNumeric.Value), Convert.ToSingle(widthNumeric.Value), Convert.ToSingle(lengthNumeric.Value), materialText.Text);
            furniture.Write(listBox1);
            Form1.listI.Add(furniture);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                Bitmap bitmapPh;
                bitmapPh = new Bitmap(fileName);
                pictureBox1.Image = bitmapPh;
            }
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            yearNumeric.Value = 2014;
            titleTextBox.Text = "Wooden Regal";
            peselMasked.Text = "87268863452";
            nameTextBox.Text = "Hassan Ji Cobelle";
            emailTextBox.Text = "hassan@japan.com";
            countryTextBox.Text = "Japan";
            cityTextBox.Text = "Tokyo";
            priceNumeric.Value = 999;
            isAvailableCheck.Checked = true;
            dateTimePicker.Value = DateTime.Now;
            heightNumeric.Value = 489;
            widthNumeric.Value = 599;
            lengthNumeric.Value = 123;
            materialText.Text = "wood";

            MessageBox.Show("Don't forget to add picture!");
        }
    }
}
