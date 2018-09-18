using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Maximum_Element
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int numberOfCommands = Int32.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "1":
                        numbers.Push(Int32.Parse(command[1]));
                        break;
                    case "2":
                        if (numbers.Count>0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case "3":
                        Console.WriteLine(numbers.Max());
                        break;
                }
            }
        }
    }
}
