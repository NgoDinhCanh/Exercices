using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai4
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
            if ( a == b && b == c && c == d)
            {
                Console.WriteLine("Khong co gia tri nho nhat ");

            }   
            else
            {
                int min = a;
                if ( min > b)
                {
                    min = b;
                }    
                if (min > c)
                {
                    min = c;
                }    
                if (min > d )
                {
                    min = d;
                }
                Console.WriteLine($"Gia tri nho nhat la {min}");
            }    

        }
    }
}
