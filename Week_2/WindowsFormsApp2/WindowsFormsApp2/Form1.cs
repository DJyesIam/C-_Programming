using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xprev, yprev;

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            xprev = e.X;
            yprev = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics grp = pictureBox.CreateGraphics();
                Color col = Color.Black;
                if (radRed.Checked) col = Color.Red;
                if (radBlue.Checked) col = Color.Blue;
                // grp.DrawEllipse(new Pen(col), e.X, e.Y, 1, 1);
                grp.DrawLine(new Pen(col), xprev, yprev, e.X, e.Y);
                xprev = e.X;
                yprev = e.Y;
            }
        }
    }
}
