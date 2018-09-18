using System;
using System.Collections.Generic;

namespace L01_ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>(input.Length);
            foreach (var ch in input)
            {
                reversedString.Push(ch);
            }

            while (reversedString.Count!=0)
            {
                Console.Write(reversedString.Pop());
            }
            Console.WriteLine();
        }
    }
}
