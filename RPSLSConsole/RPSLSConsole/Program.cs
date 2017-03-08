using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLSConsole
{
    class Program
    {
        static int intPlayerChoice = 0;
        static int intComputerChoice = 0;
        static int intRounds = 0;
        static Random randInt = new Random();
        static Player player = new Player();
        static string strTemp = string.Empty;

        static void Main(string[] args)
        {
            RPSLS();
        }

        static void RPSLS()
        {
            Console.WriteLine("Enter 'rock', 'paper', 'scissors', 'lizard', or 'spock':");
            strTemp = Console.ReadLine();

            if (strTemp == "rock")
            {
                intPlayerChoice = 1;
                player.Rock++;
            }
            else if (strTemp == "paper")
            {
                intPlayerChoice = 2;
                player.Paper++;
            }
            else if (strTemp == "scissors")
            {
                intPlayerChoice = 3;
                player.Scissors++;
            }
            else if (strTemp == "lizard")
            {
                intPlayerChoice = 4;
                player.Lizard++;
            }
            else if (strTemp == "spock")
            {
                intPlayerChoice = 5;
                player.Spock++;
            }

            CompChoice();
            Check();

            intRounds++;
            Console.WriteLine(player.ShowStats() + "\nRound #: " + intRounds.ToString());
            Console.ReadLine();

            RPSLS();
        }

        static void CompChoice()
        {
            intComputerChoice = randInt.Next(1, 6);

            if (intComputerChoice == 1)
                Console.WriteLine("\nComputer chooses Rock");
            else if (intComputerChoice == 2)
                Console.WriteLine("\nComputer chooses Paper");
            else if (intComputerChoice == 3)
                Console.WriteLine("\nComputer chooses Scissors");
            else if (intComputerChoice == 4)
                Console.WriteLine("\nComputer chooses Lizard");
            else
                Console.WriteLine("\nComputer chooses Spock");
        }

        static void Check()
        {
            if (intPlayerChoice == 1 & intComputerChoice == 3 || intPlayerChoice == 1 & intComputerChoice == 4 || intPlayerChoice == 2 & intComputerChoice == 1 || intPlayerChoice == 2 & intComputerChoice == 5 || intPlayerChoice == 3 & intComputerChoice == 2 || intPlayerChoice == 3 & intComputerChoice == 4 || intPlayerChoice == 4 & intComputerChoice == 2 || intPlayerChoice == 4 & intComputerChoice == 5 || intPlayerChoice == 5 & intComputerChoice == 3 || intPlayerChoice == 5 & intComputerChoice == 1)
            {
                Console.WriteLine("Player Wins");
                player.Wins++;
            }
            else if (intPlayerChoice == 1 & intComputerChoice == 1 || intPlayerChoice == 2 & intComputerChoice == 2 || intPlayerChoice == 3 & intComputerChoice == 3 || intPlayerChoice == 4 & intComputerChoice == 4 || intPlayerChoice == 5 & intComputerChoice == 5)
            {
                Console.WriteLine("Tie");
                player.Ties++;
            }
            else
            {
                Console.WriteLine("Computer Wins");
                player.Losses++;
            }
        }
    }
}
