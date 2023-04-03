using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Poly
{
    class Geom
    {
        public virtual void Draw(PictureBox pic) { }    // 호출될 일이 없으므로 내용이 비어있음.
        public Color col;
    }

    class Circle : Geom
    {
        private int xcen, ycen, radius;
        public static int num;

        public Circle(int xcen, int ycen, int radius, Color col)
        {
            this.xcen = xcen;
            this.ycen = ycen;
            this.radius = radius;
            this.col = col;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawEllipse(new Pen(col), xcen, ycen, radius * 2, radius * 2);
        }
    }

    class Diamond : Geom
    {
        private int xcen, ycen, xsize, ysize;
        public static int num;

        public Diamond(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen, xcen, ycen + ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen + ysize / 2, xcen - xsize / 2, ycen);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen, xcen, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen - ysize / 2, xcen + xsize / 2, ycen);
        }
    }

    class Rectangle : Geom
    {
        private int xcen, ycen, xsize, ysize;
        public static int num;

        public Rectangle(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        
        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen + xsize / 2, ycen + ysize / 2);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen - xsize / 2, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen - ysize / 2, xcen + xsize / 2, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen + ysize / 2, xcen + xsize / 2, ycen - ysize / 2);
        }
    }

    class Triangle : Geom
    {
        private int xcen, ycen, xsize, ysize;
        public static int num;

        public Triangle(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen + xsize / 2, ycen + ysize / 2);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen + ysize / 2, xcen, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen + ysize / 2, xcen, ycen - ysize / 2);
        }
    }
}
