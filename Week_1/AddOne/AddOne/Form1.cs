using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Number.Text = "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Number.Text);
            n++;
            Number.Text = Convert.ToString(n);
        }
    }
}
