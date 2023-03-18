using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckGrade_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtInput.Text);
            string st = "";

            if (num >= 90)
                st = "A";
            else if (num >= 80)
                st = "B";
            else if (num >= 70)
                st = "C";
            else
                st = "F";

            lblOutput.Text = st + " 학점입니다.";
        }
    }
}
