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
        public Player(string name, int str, int sp, int br, int health)
            : base(name, str, sp, br, health)
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

        public override void Attack (Character otherCharacter)
        {
            if (CurrentItem == null)
            {
                WriteLine($"{Name} charges towards {otherCharacter.Name} with their fists\n");
            }
            else
            {
                WriteLine($"{Name} charges forward {otherCharacter.Name} with their {CurrentItem.Name}");
                //int randnum = DiceRoll.Next(1, 21);
                //if (randnum <= 10)
                //{
                //    Flee();
                //}
                //else
                //{
                //    Speak();
                //}
            }
        }
    }
}