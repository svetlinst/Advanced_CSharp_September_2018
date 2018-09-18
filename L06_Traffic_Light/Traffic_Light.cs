using System;
using System.Collections.Generic;

namespace L06_Traffic_Light
{
    class Traffic_Light
    {
        static void Main(string[] args)
        {
            int carsToPass = Int32.Parse(Console.ReadLine());
            Queue<string> trafficQueue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "end")
            {
                if (input != "green")
                {
                    trafficQueue.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (trafficQueue.Count > 0)
                        {
                            counter++;
                            Console.WriteLine($"{trafficQueue.Dequeue()} passed!");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}