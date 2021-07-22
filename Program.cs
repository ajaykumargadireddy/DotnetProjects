using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n*n];
            Console.WriteLine("Enter the position you want one to be reset of {0} elements",n*n);
            int pos = int.Parse(Console.ReadLine());
            for (int i = 0; i < n*n; i++)
            {
                if (i == (pos-1))
                    a[i] = 1;
                else
                    a[i] = 0;
            }
            display(a,n);
            int index = pos-1;
            Console.WriteLine("2-Down 4-Left 6-Right 8-Up -1-Exit\nEnter Direction: ");
            string input = Console.ReadLine();
            while (input != "-1")
            {
                int r = index / n, c = index % n;
                switch (input)
                {
                    case "8": if (IsValid(r - 1, c, n))
                            index = ChangeandGetNewIndex(r - 1, c, a, index,n);
                        else
                            Console.WriteLine("\nCannot Move up further");
                        break;
                    case "2":if (IsValid(r + 1, c,n))
                                    index = ChangeandGetNewIndex(r+1, c, a,index,n);
                        else
                            Console.WriteLine("\nCannot Move down further");
                        break;
                    case "4":
                        if (IsValid(r, c-1,n))
                            index = ChangeandGetNewIndex(r, c - 1, a,index,n);
                        else
                            Console.WriteLine("\nCannot Move left further");
                        break;
                    case "6":if (IsValid(r, c+1,n)) 
                                    index = ChangeandGetNewIndex(r,c+1,a,index,n);
                        else
                            Console.WriteLine("\nCannot Move right further");
                        break;
                    default: Console.WriteLine("Enter Valid choice");break;
                }
                display(a,n);
                Console.WriteLine("2-Down 4-Left 6-Right 8-Up -1-Exit \nEnter Direction: ");
                input = Console.ReadLine();
            }
        }
        private static void display(int[] a,int n)
        {
            for(int i = 0; i < a.Length/n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i * n + j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static bool IsValid(int r, int v,int n)
        {
            if (r >= 0 && r < (n)  && v >= 0 && v < n)
                return true;
            return false;
        }
        private static int ChangeandGetNewIndex(int R,int C,int[] a,int index,int n)
        {
            int newindex = R * n + C;
            a[newindex] = 1;
            a[index] = 0;
            return newindex;
        }
    }
}
