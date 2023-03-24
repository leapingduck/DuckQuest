using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace DuckQuest
{
    internal class Game
    {
        private Player CurrentPlayer;
        private List<Character> CharacterList;

        public Game() 
        {
           //This creates the items and players right now. 
            Player ducky = new Player("Ducky", 26, 25, 34,20);
            Player dread = new Player("Dread", 1, 2, 3, 20);
            Player rev = new Player("Rev", 17, 38, 49, 20);
            Weapon sword = new Weapon("sword", "Sharped edged metal thing", 5);
            //ducky.Equip(sword);

            CharacterList = new List<Character>()
            {
                ducky,
                dread,
                rev
            };
        }

        public void Run()
        {
            WriteLine(ArtAssets.Header);

            WriteLine("");

            //CurrentPlayer = new Player("Dread", 1, 2, 3, 20);
            //urrentPlayer.CharacterSheet();

            //CurrentPlayer.Equip(Weapon.sword);

            //CurrentPlayer.Attack(CharacterList[0]);
            
            Character_Creation.CreateCharacter();

            //WriteLine("The three adventurers walk into a cave and find out it is actually full of bandits.\n");

            //foreach (Character character in CharacterList) 
            //{
            //    character.Fight();
            //}

           WaitForKey();

        }

        private void WaitForKey()
        {
            WriteLine("\nPress <Enter> key to finish...");
            while(Console.ReadKey(true).Key != ConsoleKey.Enter) { };
        }
    }
}
