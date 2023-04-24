using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private double xcen, ycen;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xcen += 1; ycen += 2;
            this.pictureBox1.Invalidate();  // Paint 이벤트를 호출!!(직접 Paint를 호출하는 것은 아님)
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Blue, 5);   // 파란색 두께 5 펜을 생성
            //Brush brush = Brushes.Red;  // 빨간색 브러쉬 생성
            //e.Graphics.DrawEllipse(pen, 10, 10, 100, 100);
            //e.Graphics.DrawRectangle(pen, 120, 10, 100, 100);
            //e.Graphics.FillEllipse(brush, 10, 120, 100, 100);
            //e.Graphics.FillRectangle(brush, 120, 120, 100, 100);

            //Font F1 = new Font("궁서", 20);
            //e.Graphics.DrawString("대한민국", F1, Brushes.Black, 10, 10);

            //Font F2 = new Font("궁서", 20, FontStyle.Italic |
            //                                       FontStyle.Underline);
            //e.Graphics.DrawString("대한민국", F2, Brushes.Black, 10, 40);

            //FontFamily Fm = new FontFamily("궁서");
            //Font F3 = new Font(Fm, 20);
            //e.Graphics.DrawString("대한민국", F3, Brushes.Black, 10, 70);

            e.Graphics.DrawEllipse(new Pen(Color.Blue), (int)xcen, (int)ycen, 20, 20);

        }
    }
}
