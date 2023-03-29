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
        public static int statResult { get; private set; }
        public static int healthResult { get; private set; }
        //Constructor
        public Dice()
        {
        }
        public static int D20()
        {
            d20result = rand.Next(1, 21);
            return d20result;
        }

        public static int StatGen()
        {
            //List<int> rolls = new List<int>();
            //{
            //    rand.Next(1, 7); rand.Next(1, 7); rand.Next(1, 7);  rand.Next(1, 7);
            //}

            //rolls.Remove(rolls.Min());
            statResult = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            return statResult;

        }

        public static int HealthGen()
        {
            //List<int> rolls = new List<int>();
            //{
            //    rand.Next(1, 7); rand.Next(1, 7); rand.Next(1, 7);  rand.Next(1, 7);
            //}

            //rolls.Remove(rolls.Min());
            healthResult = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            return healthResult;

        }

        /*Alternate Stat rolling

        Select number of D6 for each stat. 
        Roll number of d6 equal to selected die
        Equals strength*/
           

    }
}
