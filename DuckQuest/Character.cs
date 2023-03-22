using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DuckQuest
{
    internal class Character
    {
        protected string Name;
        protected int Strength;
        protected int Speed;
        protected int Brains;
        protected int Health;
        protected Random DiceRoll;

        public Character(string name, int str, int sp, int br)
        {
            Name = name;
            Strength = str;
            Speed = sp;
            Brains = br;
            Health = Strength * Speed;
            DiceRoll = new Random();
        }

        public void CharacterSheet()
        {
            WriteLine($"---{Name}---");
            WriteLine($"Strength    {Strength}");
            WriteLine($"Speed       {Speed}");
            WriteLine($"Brains      {Brains}");
            WriteLine($"Health      {Health}");
            WriteLine("---------\n");
        }

        public virtual void Fight()
        {
            WriteLine("");
        }

        public void Attack ()
        {
            WriteLine($"{Name} attacks with his broadsword!");
        }
                   
        public void Search() 
        {
            WriteLine($"{Name} looks around the area.");
        }
        

        

    }
}
