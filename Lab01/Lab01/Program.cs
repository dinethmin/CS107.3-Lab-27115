using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your batch: ");
            string batch = Console.ReadLine();
            Console.WriteLine("\n\nWelcome " + name);
            Console.WriteLine("Your Batch is: " + batch);
            Console.WriteLine("\n");


            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.1415;
            Console.WriteLine("Area of a circle is: " + pi * radius * radius);
            Console.WriteLine("\n");


            Console.Write("Enter your number 01: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your number 02: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is: " + sum);
            Console.WriteLine("\n");


            Console.Write("Enter your salary: ");
            string salary = Console.ReadLine();
            Console.Write("Enter your tax rate: ");
            string tax = Console.ReadLine();
            Console.WriteLine("\nWelcome employee your tax rate is: " + tax);
            Console.WriteLine("Your salary is: " + salary);

            Console.ReadKey();

        }
    }
}
