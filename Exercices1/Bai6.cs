using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap so n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 0; i <= n; i++)
            {
                S = S + i;

            }
            Console.WriteLine($"S cua ban la : {S}");
        }
    }
}
