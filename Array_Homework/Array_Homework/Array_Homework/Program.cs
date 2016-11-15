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
            Console.WriteLine("Please input " + number + " of numbers separated by pressing Enter");
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
            int minElem = testArray[0];
            int maxElem = testArray[0];
            MinMax(ref minElem ,  ref maxElem , testArray);
            Console.WriteLine("minimal number in array is "+minElem);
            Console.WriteLine("maximum number in array is "+maxElem);
            Console.ReadKey();

        }

        private static void MinMax(ref int a, ref int b , int[] tempArray)
        {
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (a > tempArray[i])
                {
                    a = tempArray[i];
                }
                else if (b < tempArray[i])
                {
                    b = tempArray[i];
                }
                
            }
        }
    }
}