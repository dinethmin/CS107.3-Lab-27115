using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Array
    {
        public void createarray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Enter the value to array index " + i + " : ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                else if (i % 2 == 1)
                {
                    array[i] = 0;
                }
            }

            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
