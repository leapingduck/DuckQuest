using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace DuckQuest
{
    internal class Character_Creation
    {
        

        new List<Weapon> weapons;
        new List<Armor> armors;
        public static void CreateCharacter()
        {
            WriteLine("Let's start with creating a character.\n");

            

            //Type your name
            WriteLine("What is your character's name?");
            String characterName = ReadLine();
            WriteLine($"\nNice to meet you, {characterName}!\n");


            Dice.StatGen();
            int strength = Dice.statResult;
            Dice.StatGen(); ;
            int speed = Dice.statResult;
            Dice.StatGen();
            int brains = Dice.statResult;
            Dice.HealthGen();
            int health = Dice.healthResult;

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
            string[] weaponsList = { "Sword", "Axe", "Spear", "Warhammer", "Scythe", "No Weapon"};

            
            Menu weaponsMenu = new Menu(weaponPrompt, weaponsList);
            weaponsMenu.Run();



            WaitForKey();
            Clear();

            string armorPrompt = "\nSelect your armor from the list.";
            string[] armorList = { "Chain Mail", "Leather", "Scale Mail", "Breastplate", "Full Plate", "I don't need armor" };
            
            Clear();
            
            Menu armorMenu = new Menu(armorPrompt, armorList);
            armorMenu.Run();
                    

            // WriteLine($"You created {characterName}! They are wielding a {characterWeapon} and wearing a {CharacterArmor}.");

            //Show Full character sheet at end

            Clear();
            WriteLine($"---{characterName}---");
            WriteLine($"Strength    {strength}");
            WriteLine($"Speed       {speed}");
            WriteLine($"Brains      {brains}");
            WriteLine($"Health      {health}");
            WriteLine("---------");
            WriteLine("You are wielding a ....");
            WriteLine("You decided you didn't need armor for some reason.");
            WriteLine("---------\n\n");
            WriteLine("Are you content with your choice? Y/N");
            
        }

        


        private static void WaitForKey()
        {
            WriteLine("\nPress <Enter> key to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
