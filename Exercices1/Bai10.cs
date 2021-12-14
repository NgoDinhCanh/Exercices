using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai9
    {
        static void Main()
        {
            Console.WriteLine("Nhap so n ");
            int n = Convert.ToInt32(Console.ReadLine());
            float S = 0;
            for (int i = 1; i <= n; i++)
            {
                S = S + ((float)1/i);
            }
            Console.WriteLine($"Ket qua la {S}");
        }
    }
}
