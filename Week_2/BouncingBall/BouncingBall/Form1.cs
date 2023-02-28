using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        int dx = 3, dy = 3;
        int xdir = 1, ydir = 1;

        private void timer_Tick(object sender, EventArgs e)
        {
            picBall.Left += xdir * dx;
            picBall.Top += ydir * dy;

            if (picBall.Left <= 0 || picBall.Right >= this.Width - 10) xdir = -xdir;
            if (picBall.Top <= 0 || picBall.Bottom >= this.Height - 35) ydir = -ydir;

            if (xdir > 0 && ydir > 0) picBall.BackColor = Color.Red;
            else if (xdir < 0 && ydir < 0) picBall.BackColor = Color.Blue;

            if (radFast.Checked)
            {
                dx = 3;
                dy = 3;
            }

            if (radSlow.Checked)
            {
                dx = 1;
                dy = 1;
            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

    }
}
