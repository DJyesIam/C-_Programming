using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Circles
{
    class Circle
    {
        private static Random rnd = new Random();
        private double xcen, ycen, radius;
        private int red, green, blue;
        private double xmov, ymov;

        // 생성자 - 주어진 위치에 랜덤 크기, 랜덤 색의 원 생성
        public Circle(double xcen, double ycen)
        {
            this.xcen = xcen;
            this.ycen = ycen;
            this.radius = rnd.Next(10) + 2;
            this.red = rnd.Next(200);
            this.green = rnd.Next(200);
            this.blue = rnd.Next(200);  // 너무밝지않게
            while (true) { this.xmov = rnd.Next(-3, 3); if (xmov != 0) break; }
            while (true) { this.ymov = rnd.Next(-3, 3); if (ymov != 0) break; }
        }

        // 움직임
        public void move(double xmin, double xmax, double ymin, double ymax)
        {
            if (xcen <= xmin + radius) xmov = Math.Abs(xmov);
            if (xcen >= xmax - radius) xmov = -Math.Abs(xmov);

            if (ycen <= ymin + radius) ymov = Math.Abs(ymov);
            if (ycen >= ymax - radius) ymov = -Math.Abs(ymov);

            xcen += xmov;
            ycen += ymov;
        }

        // 그리기
        public void draw(TCanvas canvas)
        {
            canvas.DrawEllipse(Color.FromArgb(this.red, this.green, this.blue),
            this.xcen, this.ycen, this.radius * 2, this.radius * 2);
        }

        // 주어진 점이 내부인지 판단
        public bool isinside(double xp, double yp)
        {
            double dx = xp - this.xcen;
            double dy = yp - this.ycen;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            return (dist <= this.radius) ? true : false;
        }

        public bool isInsidedCircle(Circle circle)   // 객체의 원이 파라미터의 원에 포함되는지를 판단
        {
            if (this.radius >= circle.radius) return false;     // 객체의 원이 파라미터의 원보다 크거나 같은 경우는 제외

            double dx = this.xcen - circle.xcen;
            double dy = this.ycen - circle.ycen;
            double dist = Math.Sqrt(dx*dx + dy*dy);     // 두 원 중심 사이의 거리를 구함
           
            return ((circle.radius - this.radius) > dist) ? true : false;   // 객체의 원이 포함되는지 아닌지를 판단하는 수식
        }
    }
}
