using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("Nhap so n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 0; i <= 2*n; i=i+2)
            {
                S = S + i;
            }
            Console.WriteLine($"Ket qua la {S}");
        }
    }
}
