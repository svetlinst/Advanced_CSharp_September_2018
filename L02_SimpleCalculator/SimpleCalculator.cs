using System;
using System.Collections.Generic;
using System.Linq;

namespace L02_SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> equation = new Stack<string>(input.Reverse());
            while (equation.Count!=1)
            {
                int firstNumber = int.Parse(equation.Pop());
                string operatorString = equation.Pop();
                int secondNumber = int.Parse(equation.Pop());
                switch (operatorString)
                {
                    case "-":
                        equation.Push((firstNumber-secondNumber).ToString());
                        break;
                    case "+":
                        equation.Push((firstNumber + secondNumber).ToString());
                        break;
                }
            }

            Console.WriteLine(equation.Pop());
        }
    }
}
