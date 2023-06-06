using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the KM value: ");
            double km = double.Parse(Console.ReadLine());
            
            
            ConvertValues obj = new ConvertValues();

            Console.WriteLine(km + "KM in m is,\n" + obj.kilometerTOmeter(km) + "m");

            Console.ReadKey();
        }
    }
}
