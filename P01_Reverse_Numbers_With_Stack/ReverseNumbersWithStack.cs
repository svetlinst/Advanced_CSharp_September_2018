using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace P01_Reverse_Numbers_With_Stack
{
    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<int> result = new Stack<int>(input.Length);
            foreach (var num in input)
            {
                result.Push(Int32.Parse(num));
            }

            while (result.Count!=1)
            {
                Console.Write(result.Pop() + " ");
            }

            Console.WriteLine(result.Pop());
        }
    }
}
