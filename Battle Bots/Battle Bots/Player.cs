using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battle_Bots
{
    abstract class Player
    {
        abstract public void Attack();
    }

    sealed class BattleVehicle : Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Health { get; set; }
        public int Fuel { get; set; }
        public string Weapon { get; set; }

        public override void Attack()
        {
            Program.CheckAttack();
        }

        public void Defend()
        {
            Program.CheckDefend();
        }
        public void Absorb()
        {
            
        }

    }

    sealed class EnemyVehicle : Player
    {
        public override void Attack()
        {
            
            throw new NotImplementedException();
        }
    }
     

}
