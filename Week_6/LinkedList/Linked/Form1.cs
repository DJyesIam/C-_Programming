using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked
{
    public partial class Form1 : Form
    {
        LinkedList list = new LinkedList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            // 첫번째 node
            Node node1 = new Node(10);

            list.first = node1;

            // 두번째 node
            Node node2 = new Node(20);
            node1.next = node2;

            // 세 번째 node
            Node node3 = new Node(30);
            node2.next = node3;

            // 네 번째 node
            Node node4 = new Node(40);
            node3.next = node4;

            //---------------
            //node2.delete(list);

            //---------------
            Node node = new Node(25);
            node.insertAfter(node2, list);  // 출력이 10 > 20 > 25 > 30 > 40
                                      // 이 되어야 함
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            list.printAll();
        }

        private void btnPrepend_Click(object sender, EventArgs e)
        {
            Node node = new Node(5);
            node.prepend(list);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            Node node = new Node(100);
            node.append(list);
        }
    }
}
