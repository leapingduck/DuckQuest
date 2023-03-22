using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace DuckQuest
{
    internal class Player : Character
    {
        public Player(string name, int str, int sp, int br)
            : base(name, str, sp, br)
        {

        }

        public void Flee()
        {
            WriteLine($"{Name} flies away to fight another day.");
        }

        public void Speak()
        {
            WriteLine($"{Name} tries to talk their way out of it.");
        }

        public override void Fight ()
        {
            if (CurrentItem != null)
            {
                WriteLine($"{Name} charges forward with their {CurrentItem.Name}");
            }
            else
            {

                int randnum = DiceRoll.Next(1, 21);
                if (randnum <= 10)
                {
                    Flee();
                }
                else
                {
                    Speak();
                }
            }
        }
    }
}
