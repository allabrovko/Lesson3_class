using System;

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

            {
                Console.WriteLine("площадь");
                a = 13.5; b = 7;
                if ((a - b)< 0)
                    Console.WriteLine("радиус отверстия не может быть больше радиуса кольца");
                else
                {
                    result = Math.PI*((a*a)- (b*b));
                    Console.WriteLine($"Result is: {result}");

                }

            }
        }
    }
}



