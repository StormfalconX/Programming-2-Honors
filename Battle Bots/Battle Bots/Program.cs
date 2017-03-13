using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle_Bots
{
    class Program
    {
        static int weaponPower;
        static string enemyWeapon;

        static BattleVehicle BattleVehicle = new BattleVehicle();

        static void Main(string[] args)
        {
            BattleVehicle.Fuel = 30;
            BattleVehicle.Health = 30;
            BattleVehicle.Points = 0;

            Console.WriteLine("Welcome to Battle Bots" + "\n" + "\n" + "Enter the Robots Name");
            BattleVehicle.Name = Console.ReadLine();
            Console.WriteLine("\n" + "Welcome to the apocalypse " + BattleVehicle.Name + "\n");
            Console.WriteLine("\n" + "Choose your weapon" + "\n");

            Console.WriteLine("Flamethrower: Effective against the G18 and Trebuchet but loses to Axe and Crossbow" + "\n");
            Console.WriteLine("Exploding Crossbow Bolts: Effective against the Flamethrower and Axe but loses to G18 and Trebuchet" + "\n");
            Console.WriteLine("Trebuchet: Effective against the Crossbow and G18 but loses to Flamethrower and Axe" + "\n");
            Console.WriteLine("Axe: Effective against the Trebuchet and Flamethrower but loses to Crossbow and G18" + "\n");
            Console.WriteLine("G18: Effective against the Axe and Crossbow but loses to Flamethrower and Trebuchet" + "\n");

            BattleVehicle.Weapon = Console.ReadLine();

            if (BattleVehicle.Weapon == "Flamethrower")
                weaponPower = 1;
            else if (BattleVehicle.Weapon == "Crossbow" || BattleVehicle.Weapon == "Exploding Crossbow Bolts")
                weaponPower = 2;
            else if (BattleVehicle.Weapon == "Trebuchet")
                weaponPower = 3;
            else if (BattleVehicle.Weapon == "Axe")
                weaponPower = 4;
            else if (BattleVehicle.Weapon == "G18")
                weaponPower = 5;
            
            do
            {
            int Random;
            Random intRand = new Random();
            Random = intRand.Next(1, 6);

            if (Random == 1)
                enemyWeapon = "Flamethrower";
            else if (Random == 2)
                enemyWeapon = "Crossbow";
            else if (Random == 3)
                enemyWeapon = "Trebuchet";
            else if (Random == 4)
                enemyWeapon = "Axe";
            else if (Random == 5) 
                enemyWeapon = "G18";

            Console.WriteLine("The Enemy Weapon is choosing their weapon.......\n");

            Console.WriteLine("The enemy is attacking with " + enemyWeapon + "!\n");

            Console.WriteLine("What do you choose to do?");

            string Decision =Console.ReadLine();

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

            }while (BattleVehicle.Fuel != 0 || BattleVehicle.Health != 0);

            Console.WriteLine("\n\n\n GAME OVER");
        }//main
            
        static public void CheckAttack()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "G18" || enemyWeapon == "Trebuchet")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else if (enemyWeapon == "Flamethrower")
                {
                    Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points += 5;
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            if (weaponPower == 2)
                {
                    if (enemyWeapon == "Flamethrower" || enemyWeapon == "Axe")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else if (enemyWeapon == "Crossbow")
                    {
                        Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
            if (weaponPower == 3)
            {
                if (enemyWeapon == "Crossbow" || enemyWeapon == "G18")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else if (enemyWeapon == "Trebuchet")
                {
                    Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points += 5;
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            if (weaponPower == 4)
            {
                if (enemyWeapon == "Trebuchet" || enemyWeapon == "Flamethrower")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else if (enemyWeapon == "Axe")
                {
                    Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points += 5;
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            if (weaponPower == 5)
            {
                if (enemyWeapon == "Axe" || enemyWeapon == "Crossbow")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else if (enemyWeapon == "G18")
                {
                    Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                    BattleVehicle.Fuel += 5;
                    BattleVehicle.Health += 5;
                    BattleVehicle.Points += 5;
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
            }
            }
        }//check attack

        static public void CheckDefend()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "G18" || enemyWeapon == "Trebuchet")
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Points += 1;
                    Console.WriteLine("You won the battle");
                }
                else if (enemyWeapon == "Flamethrower")
                {
                    Console.WriteLine("The enemy has the same weapon!! How can you gain more points?");
                    BattleVehicle.Fuel -= 2;
                    BattleVehicle.Health -= 5;
                    BattleVehicle.Points += 2;
                }
                else
                {
                    BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                    Console.WriteLine("You lost the battle");
                }
                if (weaponPower == 2)
                {
                    if (enemyWeapon == "Flamethrower" || enemyWeapon == "Axe")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else if (enemyWeapon == "Crossbow")
                    {
                        Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
                if (weaponPower == 3)
                {
                    if (enemyWeapon == "Crossbow" || enemyWeapon == "G18")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else if (enemyWeapon == "Trebuchet")
                    {
                        Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
                if (weaponPower == 4)
                {
                    if (enemyWeapon == "Trebuchet" || enemyWeapon == "Flamethrower")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else if (enemyWeapon == "Axe")
                    {
                        Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
                if (weaponPower == 5)
                {
                    if (enemyWeapon == "Axe" || enemyWeapon == "Crossbow")
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                        Console.WriteLine("You won the battle");
                    }
                    else if (enemyWeapon == "G18")
                    {
                        Console.WriteLine("The enemy has the same weapon!! Attack to absorb and gain more points");
                        BattleVehicle.Fuel += 5;
                        BattleVehicle.Health += 5;
                        BattleVehicle.Points += 5;
                    }
                    else
                    {
                        BattleVehicle.Fuel = BattleVehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                        Console.WriteLine("You lost the battle");
                    }
                }
            }
        }//check defend

        static public void CheckAbsorb()
        {
            
        }




        static public void DisplayPoints()
        {
            Console.WriteLine("Your Health: " + BattleVehicle.Health + "\n");
            Console.WriteLine("Your Fuel: " + BattleVehicle.Fuel + "\n");
            Console.WriteLine("Your Points: " + BattleVehicle.Points + "\n");
        }//DisplayPoints
    }
}
