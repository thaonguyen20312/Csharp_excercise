using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class TBCChanLe
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
                int demChan = 0;
                int tongChan = 0;
                int demLe = 0;
                int tongLe = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        tongChan += arr[i];
                        demChan++;
                    }
                    else
                    {
                        tongLe += arr[i];
                        demLe++;
                    }
                }
                double tbc = (demChan == 0) ? 0 : 1.0 * tongChan / demChan;
                double tbl = (demLe == 0) ? 0 : 1.0 * tongLe / demLe;
                Console.WriteLine($"TB Chan: {tbc}");
                Console.WriteLine($"TB Le: {tbl}");
            }
           
        }
    }
}
