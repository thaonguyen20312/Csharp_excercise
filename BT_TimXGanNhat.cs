using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class BT_TimXGanNhat
    {
       static void Main()
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int [n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nhap gia tri x:");
                int x = Convert.ToInt32(Console.ReadLine());
                int min = Math.Abs(x - arr[0]);
                for (int i = 0; i < n; i++)
                {
                    int tmp = Math.Abs(x - arr[i]);
                    if (tmp < min)
                    {
                        min = tmp;
                    }
                }
                Console.WriteLine("Vi tri cac phan tu gan x nhat:");
                for (int i = 0; i < n; i++)
                {
                    int tmp = Math.Abs(x - arr[i]);
                    if (tmp == min)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao phai la so duong");
            }
        }
    }
}
