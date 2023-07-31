using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum is: "+sum);
            Console.WriteLine("\n");


            Console.Write("Enter Number 1: ");
            double num01 = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            double num02 = double.Parse(Console.ReadLine());
            double summation = num1 + num2;
            double Subtraction =  num1 - num2;
            double Multiplication = num1 * num2;
            double Division = num1 / num2;
            Console.WriteLine("summation is: " + summation);
            Console.WriteLine("Subtraction is: " + Subtraction);
            Console.WriteLine("Multiplication is: " + Multiplication);
            Console.WriteLine("Division is: " + Division);
            Console.WriteLine("\n");


            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.1415;
            double circum = 2 * pi * radius;
            double area = pi * radius * radius;
            Console.WriteLine("Circumference: " + circum);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("\n");


            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(+num+" is Even");
            }
            else
            {
                Console.WriteLine(+num + " is Odd");
            }
            Console.WriteLine("\n");


            for(int i = 0; i < 10; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine(+number + " is Even");
                }
                else
                {
                    Console.WriteLine(+number + " is Odd");
                }
            }


            Console.ReadKey();

        }
    }
}
