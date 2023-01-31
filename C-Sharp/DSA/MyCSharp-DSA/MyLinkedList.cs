using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class MyLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }
        public void displayContents()
        {
            //Variable to keep track of the current node
            Node current = head;

            while(current != null)
            {
                Console.Write(current.data + "->");
                //increment the current
                current = current.next;
            }
        }
        public void removeBackHalf()
        {
            //Check if head is null before entering the while loop
            if(head == null || head.next == null)
            {
                head = null;
            }
            Node slow = head;
            Node fast = head;
            Node prev = null;

            while(fast != null && fast.next != null)
            {
                prev = slow; //to run just before the slow node
                slow = slow.next;
                fast = fast.next;
            }
            //Deletes the middle node
            prev.next = null;
        }
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedList.displayContents();
            linkedList.removeBackHalf();
            Console.WriteLine();
            linkedList.displayContents();
        }
    }
}
