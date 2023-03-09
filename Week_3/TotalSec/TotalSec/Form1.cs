using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotalSec_Click(object sender, EventArgs e)
        {
            int totalSec = 0;
            totalSec += Convert.ToInt32(txtHour.Text) * 3600;
            totalSec += Convert.ToInt32(txtMinute.Text) * 60;
            totalSec += Convert.ToInt32(txtSecond.Text);

            txtTotalSec .Text = totalSec.ToString();
        }

        private void btnHMS_Click(object sender, EventArgs e)
        {
            int totalSec = Convert.ToInt32(txtTotalSec.Text);

            int hour = totalSec / 3600;
            totalSec %= 3600;
            int minute = totalSec / 60;
            totalSec %= 60;
            int second = totalSec;

            txtHour.Text = hour.ToString();
            txtMinute.Text = minute.ToString();
            txtSecond.Text = second.ToString();
        }
    }
}
