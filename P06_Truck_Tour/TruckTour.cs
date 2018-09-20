using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P06_Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<long[]> pumpInfo = new Queue<long[]>(numberOfPumps);

            for (int i = 0; i < numberOfPumps; i++)
            {
                long[] curPump = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                pumpInfo.Enqueue(curPump);
            }

            int index = 0;
            while (true)
            {
                long totalFuel = 0;
                foreach (var pump in pumpInfo)
                {
                    var fuel = pump[0];
                    var distance = pump[1];
                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        index++;
                        pumpInfo.Enqueue(pumpInfo.Dequeue());
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}