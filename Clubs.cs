using System;

namespace GolfBagManager
{
    class Club
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public int Distance { get; set; }
        public Club(string type, string brand, int distance)
        {
            Type = type;
            Brand = brand;
            Distance = distance;
        }

        public override string ToString()
        {
            return $"{Type} - {Brand} ({Distance} yards)";
        }
    }


}
