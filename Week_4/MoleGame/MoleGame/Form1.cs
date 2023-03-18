using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool[] isOpen = new bool[5] { false, false, false, false, false };

        public Form1()
        {
            InitializeComponent();
        }

        private void timOpen_Tick(object sender, EventArgs e)
        {
            int idx = rnd.Next(5);  // 0~4까지의 랜덤 숫자
            if (idx == 0) pickCard00.Image = Properties.Resources.open;
            else if (idx == 1) pickCard01.Image = Properties.Resources.open;
            else if (idx == 2) pickCard02.Image = Properties.Resources.open;
            else if (idx == 3) pickCard03.Image = Properties.Resources.open;
            else if (idx == 4) pickCard04.Image = Properties.Resources.open;

            timOpen.Enabled = false;
            timClose.Enabled = true;
            isOpen[idx] = true;
        }

        private void CloseAll()
        {
            pickCard00.Image = Properties.Resources.closed;
            pickCard01.Image = Properties.Resources.closed;
            pickCard02.Image = Properties.Resources.closed;
            pickCard03.Image = Properties.Resources.closed;
            pickCard04.Image = Properties.Resources.closed;

            timOpen.Enabled = true;
            timClose.Enabled = false;

            for (int i = 0; i < 5; i++) isOpen[i] = false;
        }

        private void timClose_Tick(object sender, EventArgs e)
        {
            CloseAll();
        }
 

        private void pickCard_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            int idxHit = 0;
            if (pic.Name == "pickCard00") idxHit = 0;
            if (pic.Name == "pickCard01") idxHit = 1;
            if (pic.Name == "pickCard02") idxHit = 2;
            if (pic.Name == "pickCard03") idxHit = 3;
            if (pic.Name == "pickCard04") idxHit = 4;

            if (isOpen[idxHit])
            {
                int score = Convert.ToInt32(lblScore.Text);
                lblScore.Text = (++score).ToString();
                CloseAll();
            }
        }
    }
}
