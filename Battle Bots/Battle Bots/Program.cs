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

        static Vehicle Vehicle = new Vehicle();
        static BattleVehicle BattleVehicle = new BattleVehicle();

        static void Main(string[] args)
        {
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

            Console.WriteLine("The Enemy Weapon is: " + enemyWeapon + "\n");
            Console.ReadLine();
            }while (Vehicle.Fuel != 0 || BattleVehicle.Health != 0);
        }
            
        static public void Check()
        {
            if (weaponPower == 1)
            {
                if (enemyWeapon == "G18" || enemyWeapon == "Trebuchet")
                {
                    Vehicle.Fuel = Vehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                }
                else
                {
                    Vehicle.Fuel = Vehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                }
            if (weaponPower == 2)
                {
                    if (enemyWeapon == "Flamethrower" || enemyWeapon == "Axe")
                    {
                        Vehicle.Fuel = Vehicle.Fuel - 1;
                        BattleVehicle.Points += 1;
                    }
                    else
                    {
                        Vehicle.Fuel = Vehicle.Fuel - 3;
                        BattleVehicle.Health = BattleVehicle.Health - 3;
                    }
                }
            if (weaponPower == 3)
            {
                if (enemyWeapon == "Crossbow" || enemyWeapon == "G18")
                {
                    Vehicle.Fuel = Vehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                }
                else
                {
                    Vehicle.Fuel = Vehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                }
            }
            if (weaponPower == 4)
            {
                if (enemyWeapon == "Trebuchet" || enemyWeapon == "Flamethrower")
                {
                    Vehicle.Fuel = Vehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                }
                else
                {
                    Vehicle.Fuel = Vehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                }
            }
            if (weaponPower == 5)
            {
                if (enemyWeapon == "Axe" || enemyWeapon == "Crossbow")
                {
                    Vehicle.Fuel = Vehicle.Fuel - 1;
                    BattleVehicle.Points += 1;
                }
                else
                {
                    Vehicle.Fuel = Vehicle.Fuel - 3;
                    BattleVehicle.Health = BattleVehicle.Health - 3;
                }
            }
            }
        }
    }
}
