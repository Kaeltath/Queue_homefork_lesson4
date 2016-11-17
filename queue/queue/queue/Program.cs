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
        //static int head = 0;
        static int tail, head, countEnque, countDeque;
        //int countenqueue = 0;
        //int countdequeue = 0;
        private static void Main(string[] args)
        {

            for (int j = 1; j < 40; j++)
            {
                
                    int value = Convert.ToInt32(Console.ReadLine());
                    Enqueue(value);
                    //isFull(countdequeue, countenqueue, tail, head, queue);
                
               
                if (j % 2 == 0)
                {
                    Dequeue();
                    //isEmpty(countdequeue, countenqueue, tail, head);
                }
              
            }
           
        }
        static void Enqueue(int z)
         {
             countEnque = countEnque + 1;
             if (countEnque - countDeque > queue.Length)
             {
                 Console.WriteLine(" item overlaped...");
                 Console.ReadLine();
                 Environment.Exit(0);
             }
             if (tail < queue.Length - 1)
             {
                 queue[tail] = z;
                 tail = tail + 1;
             }
             else
             {
                 queue[tail] = z;
                 tail = 0;
             }
             
         }

        static bool Dequeue()
         {
             if (countDeque == countEnque && head == tail)
             {
                 Console.WriteLine("queue is empty");
                 Console.ReadLine();
                 return false;
                 
             }
             if (head < queue.Length - 1)
             {
                 Console.WriteLine(queue[head]);
                 head = head + 1;
                 countDeque = countDeque + 1;
                 return true;
             }
             else
             {
                 Console.WriteLine(queue[head]);
                 head = 0;
                 countDeque = countDeque + 1;
                 return true;
             }
             
            }

        private static void isFull()
        {
            if (countEnque - countDeque > queue.Length - 1)
            {
                Console.WriteLine("queue is full don't add new elements untill enqeue firs older");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("queue is not full ");
            }
        }

        static void isEmpty(){
            if (countDeque == countEnque && head == tail)
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