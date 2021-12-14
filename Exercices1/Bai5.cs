using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai5
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so d");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c && c == d)
            {
                Console.WriteLine("Khong co gia tri phu hop ");

            }
            else
            {
                // Tim Min
                int min = a;
                if (min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                if (min > d)
                {
                    min = d;
                }
                Console.WriteLine($"Gia tri nho nhat la {min}");
                // Tim Max
                int max = a;
                if (max < b)
                {
                    max = b;
                }
                if (max < c)
                {
                    max = c;
                }
                if (max < d)
                {
                    max = d;
                }
                int max2 = min;
                if(max2 < a && a!=max)
                {
                    max2 = a;
                }
                if (max2 < b && b != max)
                {
                    max2 = b;
                }
                if (max2 < c && c != max)
                {
                    max2 = c;
                }
                if (max2 < d && d != max)
                {
                    max2 = d;
                }
                Console.WriteLine($"Gia tri lon thu 1 la {max}");
                Console.WriteLine($"Gia tri lon thu 2 la {max2}");
                

            }

        }
    }
}
