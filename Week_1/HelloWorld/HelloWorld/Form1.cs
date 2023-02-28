using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 버튼이 클릭되었을 때 실행. 폼 디자인에서 버튼 더블클릭하면 이 줄로 이동
        private void HelloButton_Click(object sender, EventArgs e) 
        {
            HelloWorld.Text = "Hello World!";    
        }
    }
}
