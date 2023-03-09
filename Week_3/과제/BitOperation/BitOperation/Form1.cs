using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetCheckBox(int gB)
        {
            chk0.Checked = (gB & (0x01 << 0)) != 0;
            chk1.Checked = (gB & (0x01 << 1)) != 0;
            chk2.Checked = (gB & (0x01 << 2)) != 0;
            chk3.Checked = (gB & (0x01 << 3)) != 0;
            chk4.Checked = (gB & (0x01 << 4)) != 0;
            chk5.Checked = (gB & (0x01 << 5)) != 0;
            chk6.Checked = (gB & (0x01 << 6)) != 0;
            chk7.Checked = (gB & (0x01 << 7)) != 0;
        }

        private int getCheckBox()
        {
            int gB = 0;

            if (chk0.Checked) gB |= 0x01;
            if (chk1.Checked) gB |= 0x02;
            if (chk2.Checked) gB |= 0x04;
            if (chk3.Checked) gB |= 0x08;
            if (chk4.Checked) gB |= 0x10;
            if (chk5.Checked) gB |= 0x20;
            if (chk6.Checked) gB |= 0x40;
            if (chk7.Checked) gB |= 0x80;

            return gB;
        }

        private void btnToBit_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);
            SetCheckBox(gB);
        }

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            int gB = getCheckBox();

            txtNumber.Text = gB.ToString();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);
            int idx = Convert.ToInt32(txtIndex.Text);

            gB |= (0x01 << idx);
            txtNumber.Text = gB.ToString();

            SetCheckBox(gB);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);
            int idx = Convert.ToInt32(txtIndex.Text);

            gB &= ~(0x01 << idx);
            txtNumber.Text = gB.ToString();

            SetCheckBox(gB);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);
            int idx = Convert.ToInt32(txtIndex.Text);
            
            if ((gB | (0x01 << idx)) == gB) gB &= ~(0x01 << idx);
            else gB |= (0x01 << idx);

            txtNumber.Text = gB.ToString();
            SetCheckBox(gB);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);

            gB = gB << 1;

            txtNumber.Text = gB.ToString();
            SetCheckBox(gB);

            if (gB > 255) gB = getCheckBox();
            txtNumber.Text = gB.ToString();
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            int gB = Convert.ToInt32(txtNumber.Text);

            gB = gB >> 1;

            txtNumber.Text = gB.ToString();
            SetCheckBox(gB);
        }
    }
}
