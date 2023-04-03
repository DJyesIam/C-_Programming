using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.favorite();   // 1    food

            Man man = new Man();
            man.favorite();     // 2    car

            Woman woman = new Woman();
            woman.favorite();   // 3    jewel

            human = man;
            human.favorite();   // 4    food    car(override)

            human = woman;
            human.favorite();   // 5    food    jewel(override)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Man[] men = new Man[100];
            //Woman[] women = new Woman[100];

            Random rnd = new Random();
            Human[] human_arr = new Human[10];

            // 생성
            for (int i = 0; i < human_arr.Length; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    human_arr[i] = new Man();
                }
                else
                {
                    human_arr[i] = new Woman();
                }
            }

            // 출력
            for (int i = 0; i < human_arr.Length; i++)
            {
                //if (human_arr[i] is Man)
                //{
                //    Man m = human_arr[i] as Man;
                //    m.favorite();
                //}
                //else if (human_arr[i] is Woman)
                //{
                //    Woman w = human_arr[i] as Woman;
                //    w.favorite();
                //}
                human_arr[i].favorite();        // 다형적 호출
            }
        }
    }
}
