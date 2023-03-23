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
        public string Name { get; protected set; }
        public int Strength { get; protected set; }
        public int Speed { get; protected set; }
        public int Brains { get; protected set; }
        public int Health { get; protected set; }
        public Random DiceRoll { get; protected set; }
        protected Item? CurrentItem;

        public Character(string name, int str, int sp, int br, int health)
        {
            Name = name;
            Strength = str;
            Speed = sp;
            Brains = br;
            Health = health;
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

        public void Equip(Item item)
        {
            CurrentItem = item;
        }

       
        public virtual void Attack (Character otherCharacter)
        {
            WriteLine($"{Name} attacks with his broadsword!");
        }
                   
        public void Search() 
        {
            WriteLine($"{Name} looks around the area.");
        }
        

        

    }
}
