using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_1
{
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("Enter the KM value: ");
            double km = double.Parse(Console.ReadLine());
            double m = km * 1000;
            Console.WriteLine(km + "KM in m is,\n" + m + "m");
        }
    }
}
