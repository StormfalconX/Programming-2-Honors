using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle_Bots
{
    abstract class Player
    {
        abstract public int Attack();
    }

    class Vehicle : Player
    {
        public int Fuel { get; set; }
    }

    sealed class BattleVehicle : Vehicle
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Health { get; set; }
        public string Weapon { get; set; }

        public override int Attack()
        {
            Program.Check();
            throw new NotImplementedException();
        }
    }

    sealed class EnemyVehicle : Vehicle
    {
        public override int Attack()
        {
            
            throw new NotImplementedException();
        }
    }
     

}
