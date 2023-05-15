using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace tServer
{
    public partial class Form1 : Form
    {
        private TServer serverChat; //채팅용
        private TServer serverCopy; //원위치복사용
        private TServer serverComm; //비트통신용
        private TServer serverCopy2;

        private string rbuffcir = "";   // 원위치송신메시지 저장버퍼
        private string rbuffbit = "";   // 비트정보 asking 메시지 저장버퍼

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }

            lblComInfo.Text = st;
        }

        private void timConnStatus_Tick(object sender, EventArgs e)
        {
            if (serverChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = serverChat.ServerStatus();
                if (conn == csConnStatus.Closed) btnListen_Click(sender, e);
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (serverCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = serverCopy.ServerStatus();
                if (conn == csConnStatus.Closed) btnListen_Click(sender, e);
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (serverComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = serverComm.ServerStatus();
                if (conn == csConnStatus.Closed) btnListen_Click(sender, e);
                lblConnComm.Text = "Comm : " + conn.ToString();
            }

            if (serverCopy2 == null) { lblConnCopy2.Text = "Copy2 : " + "NULL"; }
            else
            {
                csConnStatus conn = serverCopy2.ServerStatus();
                if (conn == csConnStatus.Closed) btnListen_Click(sender, e);
                lblConnCopy2.Text = "Copy2 : " + conn.ToString();
            }
        }

        private void btnServerMe_Click(object sender, EventArgs e)
        {
            txtMyIP.Text = TSocket.HostAddresses()[1].ToString(); //XP는 [0]
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serverChat != null) serverChat.ServerClose();
            if (serverCopy != null) serverCopy.ServerClose();
            if (serverComm != null) serverComm.ServerClose();
            if (serverCopy2 != null) serverCopy2.ServerClose();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            string myIP = txtMyIP.Text;

            if (serverChat == null) serverChat = new TServer();
            serverChat.ServerStartListen(myIP, 5000);   // 1024~65535 추천

            if (serverCopy == null) serverCopy = new TServer(CirclePosDataArrived);
            serverCopy.ServerStartListen(myIP, 5001);   // 1024~65535 추천

            if (serverComm == null) serverComm = new TServer(AskingBitsDataArrived);
            serverComm.ServerStartListen(myIP, 5002);   // 1024~65535 추천

            if (serverCopy2 == null) serverCopy2 = new TServer();
            serverCopy2.ServerStartListen(myIP, 5003);   // 1024~65535 추천
        }

        private void CirclePosDataArrived()
        {
            while (true)
            {
                rbuffcir += serverCopy.GetRcvMsg();
                int idx1 = rbuffcir.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffcir.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string xypos = rbuffcir.Substring(idx1 + 1, idx2 - idx1 - 1);
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    lblO.Left = Convert.ToInt32(xy[0]);
                    lblO.Top = Convert.ToInt32(xy[1]);
                    rbuffcir = rbuffcir.Substring(idx2 + 1);
                }
                else
                    break;
            }
        }

        private void AskingBitsDataArrived()
        {
            while (true)
            {
                rbuffbit += serverComm.GetRcvMsg();
                int idx1 = rbuffbit.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffbit.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 - idx1 == 3)
                {
                    string stnet = rbuffbit.Substring(idx1 + 1, 2);
                    if (stnet == "RI")
                    {
                        int ibits = 0;
                        if (chkDI0.Checked) ibits += 0x1;
                        if (chkDI1.Checked) ibits += 0x2;
                        if (chkDI2.Checked) ibits += 0x4;
                        if (chkDI3.Checked) ibits += 0x8;
                        if (chkDI4.Checked) ibits += 0x10;
                        if (chkDI5.Checked) ibits += 0x20;
                        if (chkDI6.Checked) ibits += 0x40;
                        if (chkDI7.Checked) ibits += 0x80;

                        string hexnum = Util.Hex(ibits);
                        if (hexnum.Length == 1) hexnum = "0" + hexnum;
                        string st = TSocket.sACK() + "RI" + hexnum + TSocket.sETX();
                        serverComm.ServerSend(st);
                    }
                    // 처리한 곳까지 잘라내기
                    rbuffbit = rbuffbit.Substring(idx2 + 1);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serverChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            serverChat.ServerSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        private void timGetRcvMsg_Tick(object sender, EventArgs e)
        {
            if (serverChat == null) return;
            string st = serverChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            serverCopy2.ServerSend(st);
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            serverCopy2.ServerSend(st);
        }
    }
}
