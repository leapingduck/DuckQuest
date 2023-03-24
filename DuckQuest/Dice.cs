using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckQuest
{
    internal class Dice
    {
        //Fields
        private static Random rand = new Random();
        public static int d20result {  get; private set; }
        
        //Constructor
        public Dice()
        { 
        }
        public static int D20()
        {
            d20result = rand.Next(1, 21);
            return d20result;
        }


    }
}
