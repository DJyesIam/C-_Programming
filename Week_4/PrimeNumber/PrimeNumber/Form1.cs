using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class PrimeNumber10000th : Form
    {
        public PrimeNumber10000th()
        {
            InitializeComponent();
        }

        bool isPrimeNumber(int n)
        {
            bool isprime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtInput.Text);

            bool isprime = isPrimeNumber(n);
            if (isprime)
                lblOutput.Text = "소수입니다.";
            else
                lblOutput.Text = "소수가 아닙니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 2; i <= 10000; i++)
            {
                if (isPrimeNumber(i)) cnt++;
            }
            lblOutput.Text = cnt.ToString() + "개 입니다.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int n = 2;
            while (true)
            {
                if (isPrimeNumber(n)) cnt++;
                if (cnt == 10000)
                {
                    lblOutput.Text = n.ToString();
                    break;
                }
                n++;
            }
        }
    }
}
