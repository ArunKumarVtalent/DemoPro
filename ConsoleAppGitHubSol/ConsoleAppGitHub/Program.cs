using ConsoleAppGitHub.Operations;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter a value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = Convert.ToInt32(Console.ReadLine());

            AirthmaticOperations obj = new AirthmaticOperations();

            c = obj.Add(a, b);
            Console.WriteLine("The Sum is : " + c);
            c = obj.Sub(a, b);
            Console.WriteLine("The Sub is : " + c);
            c = obj.Mul(a, b);
            Console.WriteLine("The Mul is : " + c);
            c = obj.Div(a, b);
            Console.WriteLine("The Div is : " + c);

            Console.WriteLine("Program Completed...!");
            Console.ReadKey();
        }
    }
}
