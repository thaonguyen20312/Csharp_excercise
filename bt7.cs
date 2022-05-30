using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class bt7
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Nhap canh a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap canh b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                int chuVi = (a + b) * 2;
                Console.WriteLine($"Chu vi hinh chu nhat la {chuVi}");
                int dienTich = a * b;
                Console.WriteLine($"Dien tich hinh chu nhat la {dienTich}");
            }
            else
            {
                Console.WriteLine("Canh hinh chu nhat phai la so nguyen duong");
            }
        }
    }
}
