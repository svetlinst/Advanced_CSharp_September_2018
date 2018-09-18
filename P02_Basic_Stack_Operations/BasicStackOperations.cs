using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int toPush = Int32.Parse(commands[0]);
            int toPop = Int32.Parse(commands[1]);
            int toFind = Int32.Parse(commands[2]);
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse).ToArray();
            Stack<int> numStack = new Stack<int>();

            for (int i = 0; i < toPush; i++)
            {
                numStack.Push(numbers[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                if (numStack.Count!=0)
                {
                    numStack.Pop();
                }
            }

            if (numStack.Contains(toFind))
            {
                Console.WriteLine("true");
            }
            else if(numStack.Count>0)
            {
                Console.WriteLine(numStack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }



        }
    }
}
