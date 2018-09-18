using System;
using System.Collections.Generic;

namespace L04_Matching_Brackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketPosition = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    bracketPosition.Push(i);
                }
                else if (input[i]==')')
                {
                    int start = bracketPosition.Pop();
                    Console.WriteLine(input.Substring(start,i-start+1));
                }
            }
        }
    }
}
