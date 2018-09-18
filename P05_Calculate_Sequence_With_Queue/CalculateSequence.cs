using System;
using System.Collections.Generic;

namespace P05_Calculate_Sequence_With_Queue
{
    class CalculateSequence
    {
        static void Main(string[] args)
        {
            long number = Int64.Parse(Console.ReadLine());
            Queue<long> calculationQueue = new Queue<long>();
            calculationQueue.Enqueue(number);
            List<long> resultList = new List<long>();
            resultList.Add(number);
            while (resultList.Count<50)
            {
                long first = calculationQueue.Dequeue(); //first
                long second = first+1; //second
                long third = 2*first+1; //third
                long fourth = first+2; //fourth

                
                resultList.Add(second);
                resultList.Add(third);
                resultList.Add(fourth);

                calculationQueue.Enqueue(second);
                calculationQueue.Enqueue(third);
                calculationQueue.Enqueue(fourth);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{resultList[i]} ");
            }
        }
    }
}
