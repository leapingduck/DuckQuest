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

        internal static void WeaponTest()
        {
            string path = @"C:\Users\dmoore\source\repos\DuckQuest\DuckQuest\Data\weapons.txt";
            if (File.Exists(path))
            {
                string[] weaponAsString = File.ReadAllLines(path);
                for (int i = 0; i < weaponAsString.Length; i++)
                {
                    string[] weaponSplits = weaponAsString[i].Split(',');
                    string weaponName = weaponSplits[0];
                    string weaponDescription = weaponSplits[1];
                    string weaponAttribute = weaponSplits[2];
                    string weaponDamage = weaponSplits[3];
                    string weaponToHit = weaponSplits[4];
                    Console.WriteLine($"The {weaponName} is {weaponDescription}. It uses {weaponAttribute} and does {weaponDamage} damage with a +{weaponToHit} to hit");
                }
            }

            Console.ReadKey();

        }

        internal static void ArmorTest()
        {
            string path = @"C:\Users\dmoore\source\repos\DuckQuest\DuckQuest\Data\armor.txt";
            if (File.Exists(path))
            {
                string[] armorAsString = File.ReadAllLines(path);
                for (int i = 0; i < armorAsString.Length; i++)
                {
                    string[] armorSplits = armorAsString[i].Split(',');
                    string armorName = armorSplits[0];
                    string armorDescription = armorSplits[1];
                    string armorAttribute = armorSplits[2];
                    string armorDamage = armorSplits[3];
                    string armorPenalty = armorSplits[4];
                    Console.WriteLine($"The {armorName} is {armorDescription}. It uses {armorAttribute} and reduces {armorDamage} damage. It does reduce your speed by {armorPenalty}");
                }
            }

            Console.ReadKey();

        }


        internal static void CheckForFiles()
            {
            

            }
    }
}
