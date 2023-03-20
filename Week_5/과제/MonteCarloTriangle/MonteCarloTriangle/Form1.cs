using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloTriangle
{
    public partial class Form1 : Form
    {
        const int nPoint = 10000;
        Random rnd = new Random();

        int[] P1 = new int[2] { 160, 70 };
        int[] P2 = new int[2] { 50, 410 };
        int[] P3 = new int[2] { 340, 290 };

        private double getAbsTriangleArea(int[] P1, int[] P2, int[] P3)
        {
            return 0.5 * Math.Abs(((P1[0] * P2[1] + P2[0] * P3[1] + P3[0] * P1[1]) - (P1[0] * P3[1] + P3[0] * P2[1] + P2[0] * P1[1])));
        }

        private double getTriangleArea(int[] P1, int[] P2, int[] P3)
        {
            return 0.5 * ((P1[0] * P2[1] + P2[0] * P3[1] + P3[0] * P1[1]) - (P1[0] * P3[1] + P3[0] * P2[1] + P2[0] * P1[1]));
        }

        private bool inTriangle(double area1, double area2, double area3)
        {
            if (area1 > 0 && area2 > 0 && area3 > 0) return true;
            if (area1 < 0 && area2 < 0 && area3 < 0) return true;
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            // 실제 비율 얻기
            int wd = picArea.ClientSize.Width;
            int ht = picArea.ClientSize.Height;
            int area = wd * ht;

            double triArea = getAbsTriangleArea(P1, P2, P3);

            lblRatioReal.Text = Convert.ToString(triArea / (double)area);

            Graphics grp = picArea.CreateGraphics();

            // 랜덤점 발생
            int nIN = 0, nOUT = 0;
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);
                int[] P0 = new int[2] {xp, yp};

                // 내부, 외부 판단
                Color col;
                if (inTriangle(getTriangleArea(P0, P1, P2), getTriangleArea(P0, P2, P3), getTriangleArea(P0, P3, P1)))
                {
                    nIN++;
                    col = Color.Black;
                }
                else
                {
                    nOUT++;
                    col = Color.FromArgb(0xC0, 0xC0, 0xC0);
                }

                grp.DrawEllipse(new Pen(col), P0[0], P0[1], 1, 1);
                lblIN.Text = Convert.ToString(nIN);
                lblOUT.Text = Convert.ToString(nOUT);
                lblRatioMonte.Text = Convert.ToString(nIN / (double)(nOUT + nIN));
            }
            btnStart.Enabled = true;
        }
    }
}
