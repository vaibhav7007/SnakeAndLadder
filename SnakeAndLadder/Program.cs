using System;
using System.Threading;
using System.Xml.Linq;

namespace SnakeAndLadderProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Player1 = "Rahul";
            string Player2 = "Karan";
            int position = 0, Option = 0, roll = 0, Count = 0, position1 = 0;
            bool turn = true;

            Console.WriteLine("Welcome to the snake and ladder Simulator");

            //UC1 For single player
            Console.WriteLine("Player1 name is player1:{0} and its position:{1}", Player1, position);
            Console.WriteLine("Player2 name is player2:{0} and its position:{1}", Player2, position1);

            //UC2 player roll die get number between 1 to 6
            //Random random = new Random();
            //roll = random.Next(1 , 7);
            //Console.WriteLine("The single player rolled die possibility is: "+roll);

            //UC3 No Play,Ladder or Snake

            //UC4 repeating until player gets wining position
            while (position < 100 && position1 < 100)
            {
                Random random = new Random();
                roll = random.Next(1, 7);
                Console.WriteLine("die value" + roll);

                Random random1 = new Random();
                Option = random1.Next(1, 4);
                if (turn == true)
                {
                    if (position < 100)
                    {
                        switch (Option)///player one
                        {
                            case 1:
                                Console.WriteLine("(No Play)");
                                position = position + 0;
                                turn = false;
                                Console.WriteLine("player position same " + position);
                                //UC6 Counting the number of times the die rolled 
                                Count = Count + 1;
                                break;
                            case 2:
                                Console.WriteLine(" Get A ladder");
                                position += roll;  //position+roll
                                //UC5 if player gets more than 100th position then position will be reduced
                                if (position > 100)
                                {
                                    position = position - roll;
                                    Console.WriteLine("If player reach more than 100th position then position will be reduced" + roll);
                                }
                                else
                                {
                                    Console.WriteLine("After getting ladder player position will be :" + position);
                                }
                                turn = true;
                                Count = Count + 1;
                                break;
                            case 3:
                                Console.WriteLine(" Get a Snake bite");
                                position = position - roll;
                                if (position <= 0)
                                {
                                    position = 0;
                                }
                                else
                                {
                                    Console.WriteLine("After getting snake bite player position will be:" + position);
                                }
                                turn = false;
                                Count = Count + 1;
                                break;
                        }
                        Console.WriteLine("Player1 is won the game");
                    }
                }
                else
                {
                    if (position1 < 100)
                    {
                        switch (Option)//player two
                        {
                            case 1:
                                Console.WriteLine("(No Play)");
                                position1 = position1 + 0;
                                Console.WriteLine("player2 position1 same " + position1);
                                turn = true;
                                //UC6 Counting the number of times the die rolled 
                                Count = Count + 1;
                                break;
                            case 2:
                                Console.WriteLine(" Get A ladder");
                                position1 += roll;  //position+roll
                                                    //UC5 if player gets more than 100th position then position will be reduced
                                if (position1 > 100)
                                {
                                    position1 = position1 - roll;
                                    Console.WriteLine("If player2 reach more than 100th position then position will be reduced" + roll);
                                }
                                else
                                {
                                    Console.WriteLine("After getting ladder player2 position will be :" + position1);
                                }
                                turn = false;
                                Count = Count + 1;
                                break;
                            case 3:
                                Console.WriteLine(" Get a Snake bite");
                                position1 = position1 - roll;
                                if (position1 <= 0)
                                {
                                    position1 = 0;
                                }
                                else
                                {
                                    Console.WriteLine("After getting snake bite player2 position will be:" + position1);
                                }
                                turn = true;
                                Count = Count + 1;
                                break;
                        }
                        Console.WriteLine("Player2 is won the game");
                    }
                }
            }
            Console.WriteLine("The player1 max position reached:" + position);
            Console.WriteLine("The player2 max position1 reached:" + position1);
            if (position > position1)
            {
                Console.WriteLine("Player1 win the game");
            }
            else
            {
                Console.WriteLine("Player2 win the game");
            }
            Console.WriteLine("count" + Count);
            Console.ReadLine();
        }
    }
}