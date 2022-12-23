using System;
using System.Threading;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Player = "Rahul";
            int position = 0;
            Console.WriteLine("Welcome to the snake and ladder Simulator");

            //UC1 For single player
            Console.WriteLine("Single player name is player:{0} and its position:{1}: ", Player, position);

            //UC2 player roll die get number between 1 to 6
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("The single player rolled die possibility is: " + roll);
            Console.ReadLine();
        }
    }
}