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
        public Enemy(string name, int str, int sp, int br)
            : base(name, str, sp, br)
        {

        }

        public void Taunt()
        {
            WriteLine("The enemy tries to taunt you");
        }

        public void Stealth()
        {
            WriteLine("The Enemy Tries to hide.");
        }

        public override void Fight()
        {
            int randnum = DiceRoll.Next(1, 21);
            if (randnum <= 10)
            {
                Stealth();
            }
            else
            {
                Taunt();
            }
        }
    }
}
