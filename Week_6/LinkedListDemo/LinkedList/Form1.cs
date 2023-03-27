using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            list.printAll();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            Node newNode = new Node(Convert.ToInt32(txtNum.Text));
            list.append(newNode);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            list.pop();
        }
    }
}
