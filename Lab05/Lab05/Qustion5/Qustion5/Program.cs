using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qustion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter value for " + i + " : ");
                array[i] = int.Parse(Console.ReadLine());

                sum = sum + array[i];
            }
            Console.WriteLine("Sum of array is: " + sum);

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Maximum of array is: " + max);
            Console.WriteLine("Minimum of array is: " + min);

            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int[] ascending = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                int minValue = array[i];
                int minIndex = i;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < minValue)
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }
                array[minIndex] = array[i];
                array[i] = minValue;
            }

            Console.Write("\nArray: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nAscending: ");
            for (int i = 0; i < ascending.Length; i++)
            {
                Console.Write(ascending[i] + " ");
            }
            Console.ReadKey();
        }
    }
    
}
