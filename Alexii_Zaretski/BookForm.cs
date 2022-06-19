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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(Convert.ToInt32(Math.Round(yearNumeric.Value, 0)), titleTextBox.Text, peselMasked.Text, nameTextBox.Text, emailTextBox.Text, countryTextBox.Text, cityTextBox.Text, Convert.ToSingle(priceNumeric.Value), isAvailableCheck.Checked, dateTimePicker.Value, new Bitmap(pictureBox1.Image), Convert.ToInt32(Math.Round(pagesNumeric.Value, 0)), languageTextBox.Text, authorTextBox.Text, hardCoverCheckBox.Checked, chaptersTextBox.Text);
            book.Write(listBox1);
            Form1.listI.Add(book);
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
            yearNumeric.Value = 2004;
            titleTextBox.Text = "Golden Fool";
            peselMasked.Text = "87268863452";
            nameTextBox.Text = "Hassan Ji Cobelle";
            emailTextBox.Text = "hassan@japan.com";
            countryTextBox.Text = "Japan";
            cityTextBox.Text = "Tokyo";
            priceNumeric.Value = 999;
            isAvailableCheck.Checked = true;
            dateTimePicker.Value = DateTime.Now;
            pagesNumeric.Value = 634;
            languageTextBox.Text = "english";
            authorTextBox.Text = "Robin Hobb";
            hardCoverCheckBox.Checked = true;
            chaptersTextBox.Text = "Palace#Dreaming in Arles#Demonstration#Who's Joe?#The Starcourt Battle";
            MessageBox.Show("Don't forget to add picture!");

        }
    }
}
