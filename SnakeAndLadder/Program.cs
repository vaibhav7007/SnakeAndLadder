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
            int position = 0, Option = 0, roll = 0;

            Console.WriteLine("Welcome to the snake and ladder Simulator");

            //UC1 For single player
            Console.WriteLine("Single player name is player:{0} and its position:{1}", Player, position);

            //UC2 player roll die get number between 1 to 6
            //Random random = new Random();
            //roll = random.Next(1 , 7);
            //Console.WriteLine("The single player rolled die possibility is: "+roll);

            //UC3 No Play,Ladder or Snake
            //Random random1= new Random();
            //Option = random1.Next(1 , 4);

            //UC4 repeating until player gets wining position
            while (position < 100)
            {
                Random random = new Random();
                roll = random.Next(1, 7);
                Console.WriteLine("die value" + roll);
                Random random1 = new Random();
                Option = random1.Next(1, 4);


                switch (Option)
                {

                    case 1:
                        Console.WriteLine("(No Play)");
                        position = position + 0;
                        Console.WriteLine("player position same " + position);
                        break;
                    case 2:
                        Console.WriteLine(" a ladder");
                        position += roll;  //position+roll
                        if (position > 100)
                        {
                            position = position - roll;
                            Console.WriteLine("If player reach more than 100th position then position will be reduced" + roll);
                        }
                        else
                        {
                            Console.WriteLine("After getting ladder player position will be :" + position);
                        }
                        break;
                    case 3:
                        Console.WriteLine(" get Snake bite");
                        position = position - roll;
                        if (position <= 0)
                        {
                            position = 0;
                        }
                        else
                        {
                            Console.WriteLine("After getting snake bite player position will be:" + position);
                        }
                        break;
                }
            }
            Console.WriteLine("The players max position reached:" + position);
            Console.ReadLine();
        }
    }
}