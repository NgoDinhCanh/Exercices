using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine("Nhap so a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a < b)
            {
                Console.WriteLine($"Ket qua la {a} < {b}");
            }    
            else if ( a == b)
            {
                Console.WriteLine($"Ket qua la {a} = {b}");

            }   
            else
            {
                Console.WriteLine($"Ket qua la {a} > {b}");
            }    
        }
    }
}
