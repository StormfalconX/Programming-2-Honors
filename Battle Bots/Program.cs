using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Timers;

namespace Battle_Bots
{
    class Program
    {
        static int weaponPower;
        static string enemyWeapon;

        static BattleVehicle BattleVehicle = new BattleVehicle();

        static SoundPlayer atomic = new SoundPlayer("atomic.wav");
        static SoundPlayer airstrike = new SoundPlayer( "airstrike.wav");
        static SoundPlayer laser = new SoundPlayer("laser.wav");
        static SoundPlayer background = new SoundPlayer("background.wav");

        private Timer tmr = new Timer(1000);

        
        static int counter = 0;
        static string strCounter;
        static string[,] Score = new string[10,2];
        static string points;

        static List<string> lstHighScore = new List<string>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {
                var p1 = new System.Windows.Media.MediaPlayer();
                p1.Open(new System.Uri(@"H:\My Documents\Programming 2\Unit 2\Battle Bots\background.wav"));
                p1.Play();
            } while (BattleVehicle.Fuel > 0 || BattleVehicle.Health > 0);

            //background.SoundLocation = @"H:\My Documents\Programming 2\Unit 2\Battle Bots\background.wav";
            //background.PlayLooping();

            BattleVehicle.Fuel = 30;
            BattleVehicle.Health = 30;
            BattleVehicle.Points = 0;

            Console.WriteLine("Welcome to Mortal Kombat" + "\n" + "\n" + "Enter Your Name");
            BattleVehicle.Name = Console.ReadLine();
            Console.WriteLine("\n" + "Welcome to the apocalypse " + BattleVehicle.Name + "\n");
            Console.WriteLine("\n" + "Choose your hero" + "\n");

           Console.WriteLine("Sub-Zero: Effective against Kano and Raiden but loses to Liu Kang and Scorpian" + "\n");
           Console.WriteLine("Scorpian: Effective against Sub-Zero and Liu Kang but loses to Kano and Raiden" + "\n");
           Console.WriteLine("Raiden: Effective against Scorpian and Kano but loses to Sub-Zero and Liu Kang" + "\n");
           Console.WriteLine("Liu Kang: Effective against Raiden and Sub-Zero but loses to Scorpian and Kano" + "\n");
           Console.WriteLine("Kano: Effective against Liu Kang and Scorpian but loses to Sub-Zero and Raiden" + "\n");

            BattleVehicle.Weapon = Console.ReadLine();

            if (BattleVehicle.Weapon == "Sub-Zero")
                weaponPower = 1;
            else if (BattleVehicle.Weapon == "Scorpian" || BattleVehicle.Weapon == "scorpian")
                weaponPower = 2;
            else if (BattleVehicle.Weapon == "Raiden")
                weaponPower = 3;
            else if (BattleVehicle.Weapon == "Liu Kang")
                weaponPower = 4;
            else if (BattleVehicle.Weapon == "Kano")
                weaponPower = 5;

            while (BattleVehicle.Points > 0 || BattleVehicle.Fuel > 0)
            {
                int Random;
                Random intRand = new Random();
                Random = intRand.Next(1, 6);

                if (Random == 1)
                    enemyWeapon = "Sub-Zero";
                else if (Random == 2)
                    enemyWeapon = "Scorpian";
                else if (Random == 3)
                    enemyWeapon = "Raiden";
                else if (Random == 4)
                    enemyWeapon = "Liu Kang";
                else if (Random == 5)
                    enemyWeapon = "Kano";

                Console.WriteLine(enemyWeapon + " is attacking!");

                Console.WriteLine("What do you choose to do?");

                string Decision = Console.ReadLine();

                if (Decision == "Attack" || Decision == "attack")
                {
                    BattleVehicle.Attack();
                    Console.ReadLine();
                    DisplayPoints();
                }
                else if (Decision == "Defend" || Decision == "defend")
                {
                    BattleVehicle.Defend();
                    Console.ReadLine();
                    DisplayPoints();
                }
                else if (Decision == "Absorb" || Decision == "absorb")
                {
                    BattleVehicle.Absorb();
                    Console.ReadLine();
                    DisplayPoints();
                }
                else if (Decision == "Retreat" || Decision == "retreat")
                {
                    BattleVehicle.Retreat();
                    Console.ReadLine();
                    DisplayPoints();
                }
            }

            Console.WriteLine("\n\n\nGAME OVER");
            Console.WriteLine("\nWell Done " + BattleVehicle.Name + "! High Scores are displayed....\n\n");

            points = BattleVehicle.Points.ToString();
            strCounter = counter.ToString();

            lstHighScore.Add("Game " + strCounter + " . You scored " + points);

            lstHighScore.Sort();
            lstHighScore.Reverse();

            lstHighScore.ForEach(Console.WriteLine);
            //foreach (string name in lstHighScore)
            //{
            //    Microsoft.VisualBasic.Interaction.MsgBox(name);
            //}

            //for (int i = 0; i < counter + 1; i++)
            //{
            //    Console.WriteLine(Score[counter, 0] = "Game " + strCounter);
            //    Console.WriteLine(Score[counter, 1] = "You earned " + points + " points");
            //}

           

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(Score[i, 0]);
            //    Console.WriteLine(Score[i, 1]);
            //}

            Console.WriteLine("Do you want to play again?");
            string decision;
            decision = Console.ReadLine();

            if (decision == "yes")
            {
                counter++;
                Main(args);
            }
            else
            {
                Environment.Exit(0);
            }

        }//main
        
        static public void CheckAttack()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "Kano" || enemyWeapon == "Raiden")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            else if (weaponPower == 2)
                {
                    if (enemyWeapon == "Sub-Zero" || enemyWeapon == "Liu Kang")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }   
            else if (weaponPower == 3)
            {
                if (enemyWeapon == "Scorpian" || enemyWeapon == "Kano")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            else if (weaponPower == 4)
            {
                if (enemyWeapon == "Raiden" || enemyWeapon == "Sub-Zero")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            else if (weaponPower == 5)
            {
                if (enemyWeapon == "Liu Kang" || enemyWeapon == "Scorpian")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
        }//check attack

        static public void CheckDefend()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "Kano" || enemyWeapon == "Raiden")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            else if (weaponPower == 2)
                {
                    if (enemyWeapon == "Sub-Zero" || enemyWeapon == "Liu Kang")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
              else if (weaponPower == 3)
                {
                    if (enemyWeapon == "Scorpian" || enemyWeapon == "Kano")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
             else if (weaponPower == 4)
                {
                    if (enemyWeapon == "Raiden" || enemyWeapon == "Sub-Zero")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
              else if (weaponPower == 5)
                {
                    if (enemyWeapon == "Liu Kang" || enemyWeapon == "Scorpian")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
            
        }//check defend

        static public void CheckAbsorb()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "Sub-Zero")
                {
                    Console.WriteLine("The enemy is a copy!! Good job attacking and absorbing. You gained more points");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points += 5;
                }
            }
            else if (weaponPower == 2)
                {
                    if (enemyWeapon == "Scorpian")
                    {
                        Console.WriteLine("The enemy is a copy!! Good job attacking and absorbing. You gained more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                }
            else if (weaponPower == 3)
                {
                    if (enemyWeapon == "Raiden")
                    {
                        Console.WriteLine("The enemy had the same weapon!! Good job attacking and absorbing. You gained more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                }
            else if (weaponPower == 4)
                {
                    if (enemyWeapon == "Liu Kang")
                    {
                        Console.WriteLine("The enemy is a copy!! Good job attacking and absorbing. You gained more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                }
            else  if (weaponPower == 5)
                {
                    if (enemyWeapon == "Kano")
                    {
                        Console.WriteLine("The enemy is a copy!! Good job attacking and absorbing. You gained more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                }
             
        }

        static public void CheckRetreat()
        {
            Console.WriteLine("How shameful...");
            BattleVehicle.Fuel -= 5;
            BattleVehicle.Health -= 5;
            BattleVehicle.Points -= 5;
        }

        static public void DisplayPoints()
        {
            Console.WriteLine("Your Health: " + BattleVehicle.Health + "\n");
            Console.WriteLine("Your Stamina: " + BattleVehicle.Fuel + "\n");
            Console.WriteLine("Your Points: " + BattleVehicle.Points + "\n");
        }//DisplayPoints

        static public void SpecialWeapon()
        {
            int result = ItemDrop.Generate();

            if (result == 1)
            {
                Console.WriteLine("CONGRATULATIONS! YOU JUST FOUND GAINED AN AIRSTRIKE POWERUP! TYPE 'USE'\n");
                string decision = Console.ReadLine();
                if (decision == "use" || decision == "Use")
                {
                    airstrike.SoundLocation = @"H:\My Documents\Programming 2\Unit 2\Battle Bots\airstrike.wav";
                    airstrike.Play();
                    BattleVehicle.Fuel += 10;
                    BattleVehicle.Health += 10;
                    BattleVehicle.Points += 20;
                    DisplayPoints();
                }
            }
            else if (result == 2)
            {
                Console.WriteLine("CONGRATULATIONS! YOU JUST FOUND GAINED A NUKE! TYPE 'USE'\n");
                string decision = Console.ReadLine();
                if (decision == "use" || decision == "Use")
                {
                    atomic.SoundLocation = @"H:\My Documents\Programming 2\Unit 2\Battle Bots\atomic.wav";
                    atomic.Play();
                    BattleVehicle.Fuel += 15;
                    BattleVehicle.Health += 15;
                    BattleVehicle.Points += 25;
                    DisplayPoints();
                }
            }
            else if (result == 3)
            {
                Console.WriteLine("CONGRATULATIONS! YOU JUST FOUND GAINED AN ORBITAL LASER! TYPE 'USE'\n");
                string decision = Console.ReadLine();
                if (decision == "use" || decision == "Use")
                {
                    laser.SoundLocation = @"H:\My Documents\Programming 2\Unit 2\Battle Bots\laswer.wav";
                    laser.Play();
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 15;
                    BattleVehicle.Points += 30;
                    DisplayPoints();
                }
            }
        }//specialweapon

        static public void Shop()
        {
            if (BattleVehicle.Points > 5)
            {
                Console.WriteLine("\n\n\n Welcome To The SHOP!!! Type Health or Stamina to spend 5 points and buy a fuel or health potion! Or enter to continue.");
                string shop = Console.ReadLine();

                if (shop == "Stamina" || shop == "stamina")
                {
                    Console.WriteLine("Fuel potion consumer");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Points -= 5;
                    DisplayPoints();
                }
                else if (shop == "health" || shop == "Health")
                {
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points -= 5;
                    DisplayPoints();
                }
            }
        }

    }
}