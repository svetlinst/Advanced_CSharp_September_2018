using System;
using System.Collections.Generic;

namespace L03_Decimal_To_Binary_Converter
{
    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Stack<long> binaryResult = new Stack<long>();

            if (number==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (number>0)
                {
                    binaryResult.Push(number%2);
                    number = number / 2;
                }
                while (binaryResult.Count != 0)
                {
                    Console.Write(binaryResult.Pop());
                }

                Console.WriteLine();
            }

        }
    }
}
