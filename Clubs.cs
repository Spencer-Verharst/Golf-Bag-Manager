using System;

namespace GolfBagManager
{
    public abstract class Club
    {
        public string Type { get; }
        public string Brand { get; set; }
        public int Distance { get; set; }
        protected Club(string type, string brand, int distance)
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

    public class Driver : Club
    {
        public Driver(string brand, int distance)
            : base("Driver", brand, distance) { }
    }

    public class Wood : Club
    {
        public int Number { get; set; }

        public Wood(string brand, int distance, int number)
            : base($"{number}-Wood", brand, distance)
        {
            Number = number;
        }
    }

    public class Iron : Club
    {
        public int Number { get; set; }

        public Iron(string brand, int distance, int number)
            : base($"{number}-Iron", brand, distance)
        {
            Number = number;
        }
    }

    public class Wedge : Club
    {
        public string WedgeType { get; set; }

        public Wedge(string brand, int distance, string wedgeType)
            : base($"{wedgeType} Wedge", brand, distance)
        {
            WedgeType = wedgeType;
        }
    }

    public class Putter : Club
    {
        public Putter(string brand, int distance)
            : base("Putter", brand, distance) { }
    }

    public class GenericClub : Club
    {
        public GenericClub(string type, string brand, int distance)
            : base(type, brand, distance) { }
    }

    public class ClubFactory
    {
        public Club? CreateClub(string type, string brand, int distance, int? number = null, string? wedgeType = null)
        {
            return type.ToLower() switch
            {
                "driver" => new Driver(brand, distance),
                "putter" => new Putter(brand, distance),
                "wood" => new Wood(brand, distance, number ?? 3),
                "iron" => new Iron(brand, distance, number ?? 5),
                "wedge" => new Wedge(brand, distance, wedgeType ?? "PW"),
                _ => new GenericClub(type, brand, distance)
            };
        }
    }
}

