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
    public partial class Form1 : Form
    {
        public static List<Item> listI = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void btnFurn_Click(object sender, EventArgs e)
        {
            FurnitureForm furnitureForm = new FurnitureForm();
            furnitureForm.ShowDialog();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.ShowDialog();
        }
    }
}
