using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayOfWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDayOfWeek_Click(object sender, EventArgs e)
        {
            // 입력 읽기
            int year = Convert.ToInt32(txtYear.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int day = Convert.ToInt32(txtDay.Text);
            
            // 1, 2월인 경우
            if (month == 1 || month == 2)
            {
                month += 12;
                year--;
            }

            // 계산
            int idx = year + year / 4 - year / 100 + year / 400 + (int)(2.6 * month + 1.6) + day;
            int remainder = idx % 7;

            // 출력
            //switch(remainder)
            //{
            //    case 0:
            //        lblOut.Text = "일요일입니다";
            //        break;
            //    case 1:
            //        lblOut.Text = "월요일입니다";
            //        break;
            //    case 2:
            //        lblOut.Text = "화요일입니다";
            //        break;
            //    case 3:
            //        lblOut.Text = "수요일입니다";
            //        break;
            //    case 4:
            //        lblOut.Text = "목요일입니다";
            //        break;
            //    case 5:
            //        lblOut.Text = "금요일입니다";
            //        break;
            //    case 6:
            //        lblOut.Text = "토요일입니다";
            //        break;
            //}

            string[] sday = new string[] { "일", "월", "화", "수", "목", "금", "토" };
            lblOut.Text = sday[remainder] + "요일입니다";
        }

        private void btnLeapYear_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(txtYear.Text);
            bool isLeapYear = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
            //if (isLeapYear) lblOut.Text = "운년입니다";
            //else lblOut.Text = "윤년이 아닙니다"; 
            lblOut.Text = isLeapYear ? "윤년입니다" : "윤년이 아닙니다";
        }
    }
}
