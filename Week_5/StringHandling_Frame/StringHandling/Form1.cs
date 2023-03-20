using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;  // t에 현재 시각을 기록(컴퓨터 시각)
            lblTime.Text = t.ToString();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = st.Trim().Length;
            txtOUT.Text = Convert.ToString(len);    // Convert.ToString -> ToString이 static 메소드임을 알 수 있다.
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.Substring(0, len);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.Substring(st.Length - len, len);
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.Substring(1,3);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            txtOUT.Text = st.ToLower();
        }


        private void btnCompare_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            //if (st1 == st2) txtOUT.Text = "같다";       <비추천 코드>
            //else txtOUT.Text = "다르다";

            if (st1.CompareTo(st2) == 0) txtOUT.Text = "같다";
            else txtOUT.Text = "다르다";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            int idx = st1.IndexOf(st2);
            txtOUT.Text = Convert.ToString(idx);
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.PadLeft(len);
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            string st = txtIN1.Text;
            int len = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.PadRight(len);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            char[] delim = new char[] { ' ', '-', ':' };
            string[] word = st.Split(delim);
            txtOUT.Text = word[4] + "시 입니다.";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string st = lblTime.Text;
            st = st.Replace(' ', '/');
            txtOUT.Text = st.Replace('-', '/');
        }
    }
}
