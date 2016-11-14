using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array_Homework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter number of items in array");
             if (!Int32.TryParse(Console.ReadLine(), out number))
            {
               Console.WriteLine("unsuported expression");
               Console.ReadLine();
               return;
            }

            int[] testArray = new int[number];
            Console.WriteLine("Please enter " + number + " of numbers separated by pressing Enter");
            for (int elem = 0; elem < testArray.Length; elem++)
            {
                int newEl = 1;
                string element = Console.ReadLine();
                if (!Int32.TryParse(element, out newEl))
                {
                    Console.WriteLine("unsuported expression");
                    Console.ReadLine();
                    return;
                }
                testArray[elem] = newEl;
            }
            Sorting(testArray);
            Console.WriteLine("minimal number in array");
            Console.WriteLine(testArray[0]);
            Console.WriteLine("maximum number in array");
            Console.WriteLine(testArray[(number - 1)]);
            Console.ReadLine();
        }

       static int[] Sorting (int[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int m = 0; m < sortArray.Length -1 -i; m++)
                {
                    if (sortArray[m] > sortArray[m + 1])
                    {
                        int temp = sortArray[m];
                        sortArray[m] = sortArray[m+1];
                        sortArray[m+1] = temp;
                    }

                }
            }
          return sortArray;
          }
    }
}
