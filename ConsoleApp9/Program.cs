using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вычисление частного");
            double a = 12, b = 10, result;
            if (b == 0)
                Console.WriteLine("делить на 0 нельзя");
            else
            {
                result = a / b;
                Console.WriteLine($"Result is: {result}");

            }           
             
        }
    }
}



