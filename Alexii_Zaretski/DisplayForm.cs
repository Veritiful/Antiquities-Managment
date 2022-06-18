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
    public partial class DisplayForm : Form
    {

        private int currentPos = 0;

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPos > 0)
            {
                listBox1.Items.Clear();
                currentPos--;
                Form1.listI[currentPos].Write(listBox1, pictureBox1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPos < Form1.listI.Count() - 1)
            {
                listBox1.Items.Clear();
                currentPos++;
                Form1.listI[currentPos].Write(listBox1, pictureBox1);
            }
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if (Form1.listI.ElementAtOrDefault(0) != null)
            {
                Form1.listI[currentPos].Write(listBox1, pictureBox1);
            }
        }
    }
}
