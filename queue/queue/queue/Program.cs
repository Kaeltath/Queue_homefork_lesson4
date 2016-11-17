using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[] queue = new int[3];
            int head = 0;
            int tail = 0;
            int countenqueue = 0;
            int countdequeue =0;
            for (int j = 1; j < 40; j++)
            {
                
                    int value = Convert.ToInt32(Console.ReadLine());
                    Enqueue(queue, value, head, ref tail, ref countenqueue, countdequeue);
                    //isFull(countdequeue, countenqueue, tail, head, queue);
                
               
                if (j % 2 == 0)
                {
                    Dequeue(queue, ref head, tail, countenqueue, ref countdequeue);
                    //isEmpty(countdequeue, countenqueue, tail, head);
                }
              
            }
           
        }
        static void Enqueue(int[] pushtoarray, int z, int x, ref int m, ref int coen, int code)
         {
             coen = coen + 1;
             if (coen - code > pushtoarray.Length)
             {
                 Console.WriteLine(" item overlaped...");
                 Console.ReadLine();
                 Environment.Exit(0);
             }
             if (m < pushtoarray.Length -1)
             {
                 pushtoarray[m] = z;
                 m = m + 1;
             }
             else
             {
                 pushtoarray[m] = z;
                 m = 0;
             }
             
         }

        static bool Dequeue(int[] popfromarray, ref int x, int m, int coen, ref int code)
         {
             if (code == coen && x == m)
             {
                 Console.WriteLine("queue is empty");
                 Console.ReadLine();
                 return false;
                 
             }
             if (x < popfromarray.Length -1)
             {
                 Console.WriteLine(popfromarray[x]);
                 x = x + 1;
                 code = code + 1;
                 return true;
             }
             else
             {
                 Console.WriteLine(popfromarray[x]);
                 x = 0;
                 code = code + 1;
                 return true;
             }
             
            }

        private static void isFull(int code, int coen, int x, int m, int[] length)
        {
            if (coen - code > length.Length-1)
            {
                Console.WriteLine("queue is full don't add new elements untill enqeue firs older");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("queue is not full ");
            }
        }

        static void isEmpty(int code, int coen, int x, int m){
            if (code == coen && x == m)
            {
                Console.WriteLine("queue is empty");
                Console.ReadLine();
            }
           else
            {
                Console.WriteLine("queue is not empty");
            }
        }
    }
}