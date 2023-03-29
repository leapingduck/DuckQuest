namespace DuckQuest
{

    class Item
    {

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        //public int StrengthPenalty { get; protected set; }
        //public int SpeedPenalty { get; protected set; }
        //public int BrainsPenalty { get; protected set; }
        //public int StrengthBonus { get; protected set; }
        //public int SpeedBonus { get; protected set; }
        //public int BrainsBonus { get; protected set; }


        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
