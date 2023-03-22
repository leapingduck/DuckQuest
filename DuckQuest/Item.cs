using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckQuest
{
    internal class Item
    {

        public String Name;
        public String Description;
        //private int StrengthPenalty;
        //private int SpeedPenalty;
        //private int BrainsPenalty;
        //private int StrengthBonus;
        //private int SpeedBonus;
        //private int BrainsBonus;


        public Item(string name, string description) 
        {
            Name = name;
            Description = description;
        }

    }
}
