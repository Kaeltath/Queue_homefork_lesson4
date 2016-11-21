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

        static int[] queue = new int[3];
        static int tail, head, counter;
        private static void Main(string[] args)
        {
            int dequevaleue = 0;
            for (int j = 3; j < 40; j++)
            {
                
                    int value = Convert.ToInt32(Console.ReadLine());
                    Enqueue(value);
                    //isFull();
                

                if (j % 2 == 0)
                {
                    if (Dequeue(out dequevaleue))
                    {
                        Console.WriteLine(dequevaleue);
                    }
                    else
                    {
                        Console.WriteLine("queue is empty");
                    }
                }
                    //isEmpty();
                }
              
            }
         
       
        static void Enqueue(int z)
         {
             counter++;
             if (counter > queue.Length)
             {
                 Console.WriteLine(" item overlaped...");
                 Console.ReadLine();
                 Environment.Exit(0);
             }
             if (tail < queue.Length - 1)
             {
                 queue[tail] = z;
                 tail ++;

             }
             else
             {
                 queue[tail] = z;
                 tail = 0;
             }
             
         }

        private static bool Dequeue(out int value)
         {
             if ( counter==0)
             {
                 value = 0;
                 return false;
                 
             }
             if (head < queue.Length - 1)
             {
                 value = queue[head];
                 head ++;
                 counter--;
                 return true;
             }
             
             value = queue[head];
             head = 0;
             counter--;
             return true;
             
             
            }

        private static void isFull()
        {
            if (counter > queue.Length - 1)
            {
                Console.WriteLine("queue is full don't add new elements untill enqeue older items");
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("queue is not full ");
            }
        }

        static void isEmpty(){
            if (counter == 0)
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