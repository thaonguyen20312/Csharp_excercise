using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class BT_SoLanXuatHienX
    {
       static void Main()
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nhap x:");
                int x = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if(arr[i] == x)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"So lan xuat hien cua {x} trong mang la {count}");
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao phai la so duong");
            }
        }
    }
}
