using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_8B
{
    class Program
    {
        static void PokazSume(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            int a = 5, b = -7;
            PokazSume(a, b);
            Console.ReadKey();
        }
    }
}
