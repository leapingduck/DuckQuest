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
        public int result;
        
        //Constructor
        public Dice()
        { 
        }
        public void D20()
        {
            result = rand.Next(1, 21);
        }


    }
}
