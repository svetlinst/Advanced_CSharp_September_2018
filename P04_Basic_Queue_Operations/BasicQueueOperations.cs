using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int toAdd = Int32.Parse(commands[0]);
            int toRemove = Int32.Parse(commands[1]);
            int toFind = Int32.Parse(commands[2]);
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse).ToArray();
            Queue<int> numsQueue = new Queue<int>();

            for (int i = 0; i < toAdd; i++)
            {
                numsQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < toRemove; i++)
            {
                if (numsQueue.Count!=0)
                {
                    numsQueue.Dequeue();
                }
            }

            if (numsQueue.Count==0)
            {
                Console.WriteLine("0");
            }else if (numsQueue.Contains(toFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numsQueue.Min());
            }

        }
    }
}
