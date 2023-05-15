using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace OpenCVTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat matOrg = new Mat("Lake.JPG");       
            pictureBox1.Image = matOrg.ToBitmap();  // Mat 형을 Bitmap형으로 바꿔준다.

            //Bitmap bmp = matOrg.ToBitmap();   // 위의 코드를 두 줄로 표현하면 다음과 같다.
            //pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat matOrg = new Mat("Lake.JPG");
            Mat matGray = matOrg.CvtColor(ColorConversionCodes.BGR2GRAY);
            pictureBox1.Image = matGray.ToBitmap();
        }
    }
}
