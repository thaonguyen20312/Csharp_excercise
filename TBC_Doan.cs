using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class TBC_Doan
    {
        static void Main()
        {
            Console.WriteLine("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap phan tu thu {i}");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Nhap a:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap b:");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                if (a < b)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(arr[i]>=a && arr[i] <= b)
                        {
                            sum += arr[i];
                        }
                    }
                    Console.WriteLine($"Tong la {sum}");
                }
                else
                {
                    Console.WriteLine("Gia tri a phai nho hon b");
                }
            }
            else
            {
                Console.WriteLine("Gia tri n phai la so duong");
            }
        }
    }
}
