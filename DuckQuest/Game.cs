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
        private Player Ducky;
        
        public Game() 
        {
            Ducky = new Player("Ducky", 5, 3, 4);
        }

        public void Run()
        {
            WriteLine(ArtAssets.Header);

            WriteLine("");

            Ducky.CharacterSheet();
            Ducky.Attack();
            Ducky.Flee();
            Ducky.Search();
            Ducky.Speak();

            WaitForKey();
            
        }

        private void WaitForKey()
        {
            WriteLine("");
            WriteLine("Press any key to continue...");
            ReadKey(true);
        }
    }
}
