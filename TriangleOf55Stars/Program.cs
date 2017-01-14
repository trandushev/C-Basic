using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
