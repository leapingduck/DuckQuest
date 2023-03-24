using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DuckQuest
{
    internal class Character_Creation
    {
        Dice dice = new Dice();
        new List<Weapon> weapons;
        public static void CreateCharacter()
        {
            WriteLine("Let's start with creating a character.\n");

            int strength = Dice.d20result;
            int speed = 5;
            int brains = 3;
            int health = 3;

            //Type your name
            WriteLine("What is your character's name?");
            String characterName = ReadLine();
            WriteLine($"\nNice to meet you, {characterName}!\n");

            //Roll 3d6 for each stat + 4d6 health
            WriteLine("Are you ready to roll for stats?");
            WaitForKey();
            Clear();
            WriteLine($"Your strenth is {strength}!");
            WriteLine($"Your speed is {speed}!");
            WriteLine($"Your brains are {brains}!");
            WriteLine($"Your health is {health}!");
            WaitForKey();
            Clear();

            ////Select Weapons from list

            string weaponPrompt = "\nSelect your weapon from the list";
            string[] weaponsList = { "Sword", "Axe", "Spear" };


            Dice dice = new Dice();
            Menu weaponsMenu = new Menu(weaponPrompt, weaponsList);
            weaponsMenu.Run();

            WaitForKey();
            Clear();
            //WriteLine("\nWeapons are next!\n");
            //WriteLine("Select from the following items");
            //WriteLine("1. Sword");
            //WriteLine("2. Spear");
            //WriteLine("3. Axe");
            //WriteLine("4. Warhammer");
            //WriteLine("5. Scythe");
            //WriteLine("6. I don't need a weapon\n");
                     
            //Select Armor from list 
            // Make a shield that is only usable with some weapons? 
            //WriteLine("\nArmor is next!\n");
            //WriteLine("Select from the following items");
            //WriteLine("1. Chain Mail");
            //WriteLine("2. Leather");
            //WriteLine("3. Scale Mail");
            //WriteLine("4. Breastplate");
            //WriteLine("5. Full Plate");
            //WriteLine("6. I don't need armor");

            string CharacterArmor = "armor";

           // WriteLine($"You created {characterName}! They are wielding a {characterWeapon} and wearing a {CharacterArmor}.");

            //Show Full character sheet at end

        }


        private static void WaitForKey()
        {
            WriteLine("\nPress <Enter> key to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
