using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay11
{
    public class DNode
    {
        public int data;
        public DNode prev;
        public DNode next;
        public DNode(int data)
        {
            this.next = null;
            this.prev = null;
            this.data = data;
        }
        public void display()
        {
            Console.Write(data + "\t");
        }
        public override string ToString()
        {
            return ("\nThe deleted Node is " + data+"\n");
        }
    }
    public class DoubledLinkedlist
    {
        public DNode head = null;
        public int count = 0;
        public void insertbegin(int ele)
        {
            if (head == null)
                head = createNode(ele);
            else
            {
                DNode temp = createNode(ele);
                temp.next = head;
                head.prev = temp;
                head = temp;
            }
        }

        public DNode createNode(int ele)
        {
            count++;
            return new DNode(ele);
        }

        public void insertend(int ele)
        {
            if (head == null)
                head = createNode(ele);
            else
            {
                DNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                DNode newnode= createNode(ele);
                temp.next = newnode;
                newnode.prev = temp;
            }
        }

        public void display()
        {
            DNode temp = head;
            Console.WriteLine();
            Console.WriteLine();
            if (head == null)
                Console.WriteLine("The List is Empty");
            else
            {
                while (temp != null)
                {
                    temp.display();
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void insertatpos(int ele, int pos)
        {
            if (pos == 1)
                insertbegin(ele);
            else if (pos == count + 1)
                insertend(ele);
            else
            {
                DNode cn = head, pn = head;
                for(int i = 1; i < pos; i++)
                {
                    pn = cn;
                    cn = cn.next;
                }
                DNode newnode = createNode(ele);
                pn.next = newnode;
                newnode.next = cn;
                newnode.prev = pn;
                cn.prev = newnode;
            }
        }

        public void deleteatpos(int pos)
        {
            if (pos == 1)
                deletebegin();
            else if (pos == count)
                deleteend();
            else
            {
                DNode pn = head, cn = head;
                for(int i = 1; i < pos; i++)
                {
                    pn = cn;
                    cn = cn.next;
                }
                pn.next = cn.next;
                if (pn.next != null)
                    pn.next.prev = pn;
                Console.WriteLine(cn);
                cn = null;
            }
        }

        internal int find(int ele,int cnt=1)
        {
            DNode temp = head;
            int i = 0,pos=0;
            while (temp != null)
            {
                if (temp.data == ele)
                {
                    i += 1;  
                    if(i==cnt)
                        return pos + 1;
                }
                temp = temp.next;
                pos++;
            }
            if (i > 0)
            {
                Console.WriteLine("Occuernce Not found");
                return 0;
            }
            return -1;
        }

        public void deleteend()
        {
            if (head == null)
                Console.WriteLine("Deletion is Not Possible");
            else
            {
                DNode pn = head, cn = head;
                while (cn.next != null)
                {
                    pn = cn;
                    cn = cn.next;
                }
                pn.next = cn.next;
                Console.WriteLine(cn);
                if (pn == cn)
                    head = null;
                cn = null;
                count--;
            }
        }

        internal void Traversereverse(int pos)
        {
            DNode temp = head;
            for (int i = 1; i < pos; i++)
                temp = temp.next;
            while (temp != null)
            {
                temp.display();
                temp = temp.prev;
            }
            Console.WriteLine();
        }

        public void deletebegin()
        {
            if (head == null)
                Console.WriteLine("Deletion is Not Possible");
            else
            {
                DNode temp = head;
                head = head.next;
                if (head != null)
                    head.prev = null;
                Console.WriteLine(temp);
                temp = null;
                count--;
            }
        }
    }
}
