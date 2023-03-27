using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeCat_Click(object sender, EventArgs e)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
        }

        private void btnNCat_Click(object sender, EventArgs e)
        {
            lblNCat.Text = Cat.nCat.ToString();
        }
    }
}
