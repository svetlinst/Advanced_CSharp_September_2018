using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>(input.Length);
            char[] openingBrackets = new char[]{'(', '[', '{'};
            bool correctInput = true;
            bool isBalanced = true;
            foreach (var ch in input)
            {
                if (openingBrackets.Contains(ch))
                {
                    parentheses.Push(ch);
                    continue;
                }

                if (parentheses.Count!=0)
                {
                    switch (ch)
                    {
                        case ')':
                            if (parentheses.Peek() == '(')
                            {
                                parentheses.Pop();
                            }
                            break;
                        case ']':
                            if (parentheses.Peek() == '[')
                            {
                                parentheses.Pop();
                            }
                            break;
                        case '}':
                            if (parentheses.Peek() == '{')
                            {
                                parentheses.Pop();
                            }
                            break;
                    }
                }
                else
                {
                    correctInput = false;
                }
   
            }

            if (parentheses.Count==0 && correctInput)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
