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
    public partial class CompareForm : Form
    {
        public CompareForm()
        {
            InitializeComponent();
            for (int i = 0; i < Form1.listI.Count; i++)
            {
                if (Form1.listI[i] is Furniture)
                {
                    firstCombo.Items.Add(i);
                    secondCombo.Items.Add(i);
                }
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            bool result = false;

            int fc = Convert.ToInt32(firstCombo.Items[firstCombo.SelectedIndex].ToString());
            int sc = Convert.ToInt32(secondCombo.Items[secondCombo.SelectedIndex].ToString());

            Furniture fn1 = (Furniture)Form1.listI[fc];
            Furniture fn2 = (Furniture)Form1.listI[sc];
            if (operatorCombo.SelectedIndex == 0) result = fn1 == fn2;
            if (operatorCombo.SelectedIndex == 1) result = fn1 != fn2;
            if (operatorCombo.SelectedIndex == 2) result = fn1 > fn2;
            if (operatorCombo.SelectedIndex == 3) result = fn1 < fn2;
            res.Text = result.ToString();
        }
    }
}
