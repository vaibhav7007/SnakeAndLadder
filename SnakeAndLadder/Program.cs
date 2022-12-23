using System;
using System.Threading;
using System.Xml.Linq;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Player = "Rahul";
            int position = 0, Option = 0;

            Console.WriteLine("Welcome to the snake and ladder Simulator");

            //UC1 For single player
            Console.WriteLine("Single player name is player:{0} and its position:{1}", Player, position);

            //UC2 player roll die get number between 1 to 6
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine("The single player rolled die possibility is: " + roll);

            //UC3 No Play,Ladder or Snake
            Random random1 = new Random();
            Option = random1.Next(0, 3);
            switch (Option)
            {
                case 1:
                    Console.WriteLine("Player is at same position(No Play)");
                    break;
                case 2:
                    Console.WriteLine("Player gets a ladder");
                    position += roll;  //position+roll 
                    Console.WriteLine("After getting ladder player position will be :" + position);
                    break;
                default:
                    Console.WriteLine("Player will get Snake bite and position will decrease");
                    position = roll - position;
                    Console.WriteLine("After getting snake bite player position will be:" + position);
                    break;
            }
            Console.ReadLine();
        }
    }
}