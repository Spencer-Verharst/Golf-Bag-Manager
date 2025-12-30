using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBagManager;

namespace GolfBagManager
{
    public class ClubFactory : IClubFactory  // <-- Added interface
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
