using System;
using System.Collections.Generic;

namespace L05_Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int tossNumber = Int32.Parse(Console.ReadLine());
            Queue<string> remainingPlayers = new Queue<string>(players);
            while (remainingPlayers.Count!=1)
            {
                for (int i = 1; i < tossNumber; i++)
                {
                    remainingPlayers.Enqueue(remainingPlayers.Dequeue());
                }

                Console.WriteLine($"Removed {remainingPlayers.Dequeue()}");
            }

            Console.WriteLine($"Last is {remainingPlayers.Dequeue()}");
        }
    }
}
