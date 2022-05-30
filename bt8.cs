using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class bt8
    {
        static void Main()
        {
            Console.WriteLine("Nhap ban kinh r:");
            float r = Convert.ToSingle(Console.ReadLine());
            if (r > 0)
            {
                float chuVi = (float)(2 * Math.PI * r);
                Console.WriteLine($"Chu vi hinh tron la {chuVi}");
                float dienTich = (float)(Math.PI * r * r);
                Console.WriteLine($"Dien tich hinh tron la {dienTich}");
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao phai la so nguyen duong");
            }
        }
    }
}
