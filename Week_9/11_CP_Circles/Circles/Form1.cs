using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        private TCanvas canvas = null;
        private List<Circle> circles = new List<Circle>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            if (canvas == null) canvas = new TCanvas(picDraw, 0, 100, 0, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkMove.Checked == false) return;

            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].move(0, 100, 0, 100);
            }

            if (chkDelIncluded.Checked == true)     // 만약 포함되는 원 지우기가 체크되어 있다면
            {
                List<Circle> cdel = new List<Circle>();     // 지울 원 리스트 생성

                // 이중 반복문 실행
                for (int i = 0; i < circles.Count; i++)     // 지울지 말지 테스트하는 객체
                {
                    for (int j = 0; j < circles.Count; j++)     // 나머지 원들과의 포함관계를 테스트
                    {
                        if (circles[i].isInsidedCircle(circles[j]))  // 만약 포함된다면
                        {
                            cdel.Add(circles[i]);   // 지울 원 리스트에 추가
                            break;  // 해당 객체는 더 이상 검사할 필요가 없으므로 탈출
                        }
                    }
                }
                for (int i = 0; i < cdel.Count; i++) circles.Remove(cdel[i]);   // 지울 원 리스트의 원들을 다 지운다.
            }
            DrawCircles();
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                double xc = rnd.Next(100);
                double yc = rnd.Next(100);
                Circle cir = new Circle(xc, yc);
                circles.Add(cir);
            }

            DrawCircles();
        }

        private void DrawCircles()
        {
            // 화면지우기
            canvas.ClearDrawing(Color.White);

            // 모든 원 그리기
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].draw(canvas);
            }

            lblNCir.Text = "원의개수 : " + Convert.ToString(circles.Count);
        }

        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (radAdd.Checked)
            {
                Circle cir = new Circle(canvas.xposD(e.X), canvas.yposD(e.Y));
                circles.Add(cir);
                DrawCircles();
            }
            else if (radDel.Checked)
            {
                List<Circle> cdel = new List<Circle>();
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].isinside(canvas.xposD(e.X), canvas.yposD(e.Y))) cdel.Add(circles[i]);
                }

                for (int i = 0; i < cdel.Count; i++) circles.Remove(cdel[i]);
                DrawCircles();
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            circles.Clear();
            DrawCircles();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
