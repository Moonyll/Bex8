using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 1; i <= 19; i = i + 2)
            {
                Console.WriteLine($"{pairs[i]}");
            }
        }
    }
}
