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
        
        private List<Character> CharacterList;
        
        public Game() 
        {
            Player ducky = new Player("Ducky", 6, 5, 4);
            Player dread = new Player("Dread", 1, 2, 3);
            Player rev = new Player("Rev", 7, 8, 9);

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

            foreach (Character character in CharacterList) 
            {
                character.Fight();
            }
      
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
