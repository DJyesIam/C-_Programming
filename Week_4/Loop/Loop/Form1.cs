using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;

            //while (a > 0);    NULL문(무한반복)
            //    Console.WriteLine(a--);

            while (a > 0)
                Console.WriteLine(a--);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach(int a in arr)
                Console.WriteLine(a);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
