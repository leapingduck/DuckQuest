using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckQuest
{
    internal class Utilities
    {

        public Utilities() { }

        internal static void ItemTest()
        {
            string path = @"C:\Users\dmoore\source\repos\DuckQuest\DuckQuest\Data\items.txt";
            if (File.Exists(path))
            {
                string[] itemsAsString = File.ReadAllLines(path);
                for (int i = 0; i < itemsAsString.Length; i++)
                {
                    string[] itemSplits = itemsAsString[i].Split(',');
                    string itemName = itemSplits[0];
                    string itemDescription = itemSplits[1];
                    string itemAttribute = itemSplits[2];
                    string itemDamage = itemSplits[3];
                    string itemToHit = itemSplits[4];
                    Console.WriteLine($"The {itemName} is {itemDescription}. It uses {itemAttribute} and does {itemDamage} damage with a +{itemToHit} to hit");
                }
            }

            Console.ReadKey();

        }


        internal static void CheckForFiles()
            {
            

            }
    }
}
