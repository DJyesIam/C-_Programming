using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Linked
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        //---- 뒤에 추가
        public void prepend(LinkedList list)
        {
            next = list.first;
            list.first = this;
        }

        //---- 앞에 추가
        public void append(LinkedList list)
        {
            if (list.first == null)
            {
                list.first = this;
                this.next = null;
            }
            else
            {
                Node node = list.first;
                while (true)
                {
                    if (node.next == null) break;
                    node = node.next;
                }
                node.next = this;
                this.next = null;
            }
        }

        //---- 자기 자신 삭제
        public void delete(LinkedList list)
        {
            if (list.first == null) return;

            // 나의 앞 노드를 찾아야 함
            Node node = list.first;
            while (true)
            {
                if (node.next == this) break;
                node = node.next;
            }
            node.next = this.next;
        }

        //---- 자기 자신을 주어진 노드 뒤로 추가
        public void insertAfter(Node node, LinkedList list)
        {
            if (node == list.first) // 만약 주어진 노드가 first 노드라면 first 노드 뒤에 추가
            {
                this.next = list.first.next;
                list.first.next = this;
                return;
            }

            Node tmpNode = list.first;  
            while (true)
            {
                if (tmpNode.next == node)
                {
                    tmpNode = tmpNode.next;
                    break;
                }
                tmpNode = tmpNode.next;
            }
            this.next = tmpNode.next;
            tmpNode.next = this;
        }
    }

    class LinkedList
    {
        public Node first;

        public void printAll()
        {
            Node node = this.first;
            while (true)
            {
                if (node == null) break;
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
}
