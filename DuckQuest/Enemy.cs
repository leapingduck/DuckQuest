using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DuckQuest
{
    internal class Enemy : Character
    {
        public Enemy(string name, int str, int sp, int br, int health)
            : base(name, str, sp, br, health)
        {

        }

        public void Taunt()
        {
            WriteLine("The enemy tries to taunt you");
        }

        public void Attack()
        {
            WriteLine("The enemy charges forward.");
        }

        public override void Attack(Character otherCharacter)
        {
            int randnum = DiceRoll.Next(1, 21);
            if (randnum <= 10)
            {
                Attack();
            }
            else
            {
                Taunt();
            }
        }
    }
}
