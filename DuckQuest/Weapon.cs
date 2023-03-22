using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DuckQuest
{
    internal class Weapon : Item
    {

        private int Damage;

        public Weapon(string name, string description, int damage)
            : base(name, description)
        {
            Damage = damage;

        }

        public void Attack()
        {
            WriteLine($"Name hits for {Damage}!");
        }

    }
}
