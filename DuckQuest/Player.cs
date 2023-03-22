using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DuckQuest
{
    internal class Player
    {
        private string Name;
        private int Strength;
        private int Speed;
        private int Brains;
        private int Health;

        public Player(string name, int str, int sp, int br)
        {
            Name = name;
            Strength = str;
            Speed = sp;
            Brains = br;
            Health = Strength * Speed;
        }

        public void CharacterSheet()
        {
            WriteLine($"---{Name}---");
            WriteLine($"Strength    {Strength}");
            WriteLine($"Speed       {Speed}");
            WriteLine($"Brains      {Brains}");
            WriteLine($"Health      {Health}");
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
        public void Flee() 
        {
            WriteLine($"{Name} flies away to fight another day.");
        }

        public void Speak()
        {
            WriteLine($"{Name} tries to talk their way out of it.");
        }

    }
}
