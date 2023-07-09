using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    public class LinkedList1
    {
        public Node head; // head of list

        public LinkedList1()
        {
            push(5);
            push(4);
            push(3);
            push(2);
            push(1);

            //InserInEnd(7);

            printList();

            //ReverseList(head);

            //printList();

           var res= Reverse(head, 3);

        }

        /* Linked list Node*/
       public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public Node ReverseList(Node head)
        {
            Node curr = head, prev = null, next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public Node Reverse(Node head, int k)
        {
            if (head == null)
                return null;
            Node current = head;
            Node next = null;
            Node prev = null;

            int count = 0;

            /* Reverse first k nodes of linked list */
            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }

            /* next is now a pointer to (k+1)th node
                Recursively call for the list starting from
               current. And make rest of the list as next of
               first node */
            if (next != null)
            {
                Node temp = next;
                int r = 0;
                while (temp != null)
                {
                    r++;
                    temp = temp.next;
                }
                if (r >= k)
                {
                    head.next = Reverse(next, k);
                }
                else
                {
                    head.next = next;
                }
               
            }
                

            // prev is now head of input list
            return prev;
        }

        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Function to print linked list */
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

       public void InserInEnd(int val, Node head)
        {
            if (head == null)
            {
                head = new Node(val);
            }

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
            }
            temp = new Node(val);
        }

       
    }
}
