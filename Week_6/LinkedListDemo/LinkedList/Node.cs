using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public Node(int contents)
        {
            c = contents;
            next = null;
        }

        public int c;
        public Node next;
    }

    class LinkedList
    {
        public Node first;
        public Node last;

        public void printAll()
        {
            Console.WriteLine("=============");
            Node node = first;
            while (true)
            {
                if (node == null)
                {
                    Console.WriteLine("=============");
                    break;
                }
                Console.WriteLine(node.c);
                node = node.next;
            }
        }

        public void append(Node newNode)
        {
            if (first == null)
            {
                first = newNode;
                return;
            }
            Node node = first;
            while (true)
            {
                if (node.next == null)
                {
                    node.next = newNode;
                    last = newNode;
                    break;
                }
                node = node.next;
            }
        }
        
        public void pop()
        {
            if (first == null)
            {
                Console.WriteLine("제거할 노드가 없습니다.");
                return;
            }
            if (first == last)
            {
                first = null;
                last = null;
                return;
            }

            Node node = first;
            while (true)
            {
                if (node.next == last)
                {
                    last = node;
                    last.next = null;
                    break;
                }
                node = node.next;
            }
        }
    }
}
