using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 10;
            int result = number1 * number2;
            //razlichni metodi
            Console.WriteLine("Multiply:"+result);
            Console.WriteLine($"Multiply: {result}");
            Console.WriteLine("Multiply: {0},",result);


        }
    }
}
