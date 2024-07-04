//Name : Nimna Alupotha Gamage (NIMNA A. G. T.)
//Index No.: s14682
//Reg.No. : 2019s17241

using System;

namespace Programming_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Game Starts
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************************");
            Console.WriteLine("\n         Welcome to the Dice Game!\n");
            Console.WriteLine("*********************************************");
            Console.ResetColor();

            //Get the player's names as console inputs
            Console.WriteLine("\n>>Enter the name of Player A : ");
            string? nameA = Console.ReadLine();
            Console.WriteLine("\n>>Enter the name of Player B : ");
            string? nameB = Console.ReadLine();


            string[] players = new string[2];
            players[0] = nameA;
            players[1] = nameB;


            //Variables to store random numbers of rolling dices
            //Player A
            int playerARandDice1;
            int playerARandDice2;

            //Player B
            int playerBRandDice1;
            int playerBRandDice2;

            //Variables to store Scores
            //Player A
            int playerADiceTotal = 0;
            int playerAScore = 0;

            //Player B
            int playerBDiceTotal = 0;
            int playerBScore = 0;


            Random randm = new Random();


            for (int i = 0; i < 100; i++)
            {

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Roll the dice by pressing any key. Good Luck!");
                Console.ResetColor();

                Console.ReadKey();

                //Generating random numbers
                //Player A
                playerARandDice1 = randm.Next(1, 7);
                playerARandDice2 = randm.Next(1, 7);
                Console.WriteLine("{0} has rolled {1} {2}", nameA, playerARandDice1, playerARandDice2);

                //Player B
                playerBRandDice1 = randm.Next(1, 7);
                playerBRandDice2 = randm.Next(1, 7);
                Console.WriteLine("{0} has rolled {1} {2}", nameB, playerBRandDice1, playerBRandDice2);


                playerADiceTotal = playerARandDice1 + playerARandDice2;
                playerAScore = playerAScore + playerADiceTotal;
                Console.WriteLine("{0} Score is {1}", nameA, playerAScore);

                playerBDiceTotal = playerBRandDice1 + playerBRandDice2;
                playerBScore = playerBScore + playerBDiceTotal;
                Console.WriteLine("{0} Score is {1}", nameB, playerBScore);



                //Game Rules
                if (playerARandDice1 == playerARandDice2 && playerARandDice1 != 1 && playerARandDice2 != 1)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n{0} will get another chance to roll the dice!", nameA);
                    Console.ResetColor();

                    playerARandDice1 = randm.Next(1, 7);
                    playerARandDice2 = randm.Next(1, 7);
                    Console.WriteLine("{0} has rolled {1} {2}", nameA, playerBRandDice1, playerBRandDice2);
                    playerADiceTotal = playerARandDice1 + playerARandDice2;
                    playerAScore = playerAScore + playerADiceTotal;
                    Console.WriteLine("{0} Score is {1}", nameA, playerAScore);

                }
                else if (playerBRandDice1 == playerBRandDice2 && playerBRandDice1 != 1 && playerBRandDice2 != 1)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n{0} will get another chance to roll the dice!", nameB);
                    Console.ResetColor();

                    playerBRandDice1 = randm.Next(1, 7);
                    playerBRandDice2 = randm.Next(1, 7);
                    Console.WriteLine("{0} has rolled {1} {2}", nameB, playerBRandDice1, playerBRandDice2);
                    playerBDiceTotal = playerBRandDice1 + playerBRandDice2;
                    playerBScore = playerBScore + playerBDiceTotal;
                    Console.WriteLine("{0} Score is {1}", nameB, playerBScore);

                }
                else if (playerARandDice1 == playerARandDice2 && playerARandDice1 == 1 && playerARandDice2 == 1)
                {
                    playerAScore = 0;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBoth dices give the value 1. Marks of {0} reduced to '0'", nameA);
                    Console.ResetColor();
                    Console.WriteLine("{0} Score is {1}", nameA, playerAScore);

                }
                else if (playerBRandDice1 == playerBRandDice2 && playerBRandDice1 == 1 && playerBRandDice2 == 1)
                {
                    playerBScore = 0;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBoth dices give the value 1. Marks of {0} reduced to '0'", nameB);
                    Console.ResetColor();
                    Console.WriteLine("{0} Score is {1}", nameB, playerBScore);

                }


                //Choosing the Winner
                if (playerAScore > playerBScore && playerAScore >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n**************{0} Wins!******************", nameA);
                    Console.ResetColor();
                    break;
                }
                else if (playerAScore < playerBScore && playerBScore >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n***************{0} Wins!****************", nameB);
                    Console.ResetColor();
                    break;
                }



            }



        }
    }
}