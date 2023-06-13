using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qustion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1 for Addition\n" + "Enter 2 for Subtraction\n" + "Enter 3 for Multiplication\n" + "Enter 4 for Division\n");
            Console.Write("\nEnter your choice : ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            CalculateValues objcalculateValues = new CalculateValues();

            if(choice == 1)
            {
                Console.WriteLine("Your answer is: "+objcalculateValues.Addition(num1,num2));
            }else if(choice == 2)
            {
                Console.WriteLine("Your answer is: " + objcalculateValues.Subtraction(num1, num2));
            }else if( choice == 3)
            {
                Console.WriteLine("Your answer is: " + objcalculateValues.Multiplication(num1, num2));
            }else if(choice==4)
            {
                Console.WriteLine("Your answer is: " + objcalculateValues.Division(num1, num2));
            }

            Console.ReadKey();
        }
    }
}
