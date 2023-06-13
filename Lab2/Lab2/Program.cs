using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues objfindValues = new FindValues();

            Console.Write("What do you need?(Area/Cicumference): ");
            string option = Console.ReadLine();

            if(option == "Area")
            {
                Console.WriteLine("The Area is: " + objfindValues.findArea(radius));
            }
            else
            {
                Console.WriteLine("The Cicumference is: " + objfindValues.findCicumference(radius));
                
            }

            Console.ReadKey();
        }
    }
}
