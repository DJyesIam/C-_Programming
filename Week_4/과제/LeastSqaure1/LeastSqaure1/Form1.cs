using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSqaure1
{
    public partial class Form1 : Form
    {
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;

        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin)));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 데이터 세팅
            const int ndat = 6;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[ndat] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

            // 좌표계 그리기
            Graphics grp = picDraw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));

            // 데이터 점 그리기
            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }

            // Least-Square 풀이
            double sumX = 0, sumX2 = 0, sumX3 = 0, sumX4 = 0, sumY = 0, sumXY = 0, sumX2Y = 0;
            for (int i = 0; i < ndat; i++)
            {
                sumX += xw[i];
                sumX2 += xw[i] * xw[i];
                sumX3 += xw[i] * xw[i] * xw[i];
                sumX4 += xw[i] * xw[i] * xw[i] * xw[i];
                sumY += yw[i];
                sumXY += xw[i] * yw[i];
                sumX2Y += xw[i] * xw[i] * yw[i];
            }

            double D = ndat * (sumX2 * sumX4 - sumX3 * sumX3) 
                       - sumX * (sumX * sumX4 - sumX2 * sumX3) 
                       + sumX2 * (sumX * sumX3 - sumX2 * sumX2);

            double D1 = sumY * (sumX2 * sumX4 - sumX3 * sumX3)
                       - sumX * (sumXY * sumX4 - sumX2Y * sumX3)
                       + sumX2 * (sumXY * sumX3 - sumX2 * sumX2Y);

            double D2 = ndat * (sumXY * sumX4 - sumX3 * sumX2Y)
                       - sumY * (sumX * sumX4 - sumX2 * sumX3)
                       + sumX2 * (sumX * sumX2Y - sumXY * sumX2);

            double D3 = ndat * (sumX2 * sumX2Y - sumXY * sumX3)
                       - sumX * (sumX * sumX2Y - sumX2 * sumXY)
                       + sumY * (sumX * sumX3 - sumX2 * sumX2);

            double a0 = D1 / D;
            double a1 = D2 / D;
            double a2 = D3 / D;

            // 구해진 직선 그리기
            double dx = 0.01;
            int arrlen = (int)(xmax - xmin) * (int)(1 / dx);
            double[] x = new double[arrlen];
            for (int i = 0; i < arrlen; i++) x[i] = xmin + dx * i;

            for (int i = 0; i < arrlen - 1; i++)
                grp.DrawLine(new Pen(Color.Blue),
                             xpixel(x[i]), ypixel(a0 + a1 * x[i] + a2 * x[i] * x[i]),
                             xpixel(x[i + 1]), ypixel(a0 + a1 * x[i + 1] + a2 * x[i + 1] * x[i + 1]));
        }
    }
}
