using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_csharp
{
    class BangCuuChuong
    {
        static void Main()
        {
            for (int i = 0; i <=10; i++)
            {
                for (int j = 0; j <=10 ; j++)
                {
                    Console.Write($"{i} * {j} = {i * j} \t");
                }
                Console.WriteLine(""); 
            }
        }
    }
}
