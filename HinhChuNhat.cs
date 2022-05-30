using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class HinhChuNhat
    {
        static void Main()
        {
            Console.WriteLine("Nhap m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if(m>0 && n > 0)
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("Gia tri m & n la so duong");
            }
        }

    }
}
