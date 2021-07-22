using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay11
{
    class DobMain
    {
        static void Main(string[] args)
        {
            DoubledLinkedlist d = new DoubledLinkedlist();
            
            int ch,ele,pos,res,oc;
            do
            {
                Console.WriteLine("1. Insert at begin");
                Console.WriteLine("2. Insert at end");
                Console.WriteLine("3. Insert at position");
                Console.WriteLine("4. Delete at begin");
                Console.WriteLine("5. Delete at end");
                Console.WriteLine("6. Delete at Position");
                Console.WriteLine("7. Find an element");
                Console.WriteLine("8. Find an element after a Occurence");
                Console.WriteLine("9. Display");
                Console.WriteLine("10. exit");
                Console.WriteLine("11. Traverse Reverse from given Position");
                Console.WriteLine("Enter your choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: Console.WriteLine("Enter your element");
                        ele = int.Parse(Console.ReadLine());
                        d.insertbegin(ele);
                        break;
                    case 2:
                        Console.WriteLine("Enter your element");
                        ele = int.Parse(Console.ReadLine());
                        d.insertend(ele);
                        break;
                    case 3: Console.WriteLine("Enter your element");
                            ele= int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Enter Position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > d.count + 1);
                        d.insertatpos(ele, pos);
                        break;
                    case 4:d.deletebegin();
                        break;
                    case 5:
                        d.deleteend();
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("Enter Position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > d.count);
                        d.deleteatpos(pos);
                        break;
                    case 7:
                        Console.WriteLine("Enter your element");
                        ele = int.Parse(Console.ReadLine());
                        res=d.find(ele);
                        if (res == -1)
                            Console.WriteLine("Element is not found");
                        else
                            Console.WriteLine("The Key is found at position:" + res);
                        break;
                    case 8:
                        Console.WriteLine("Enter your element");
                        ele = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Enter occurence number");
                            oc = int.Parse(Console.ReadLine());
                            
                        } while (oc < 1 || oc > d.count);
                        res = d.find(ele, oc);
                        if (res == -1)
                            Console.WriteLine("Element is not found");
                        else if(res!=0)
                            Console.WriteLine("The Key is found at :" + res);
                        break;
                    case 9:d.display();
                        break;
                    case 11:
                        do
                        {
                            Console.WriteLine("Enter Position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > d.count);
                        d.Traversereverse(pos);
                        break;
                    case 10:break;
                }
            } while (ch != 10);

        }
    }
}
