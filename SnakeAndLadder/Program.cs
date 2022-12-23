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
            Console.ReadLine();
        }
    }
}