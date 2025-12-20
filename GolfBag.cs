using System;
using System.Collections.Generic;
using System.Linq;
namespace GolfBagManager
{
    public class GolfBag
    {
        private readonly List<Club> _clubs;
        private const int MAX_CLUBS = 14;

        public GolfBag()
        {
            _clubs = new List<Club>();
        }

        public IReadOnlyList<Club> GetAllClubs() => _clubs.AsReadOnly();

        public int GetClubCount() => _clubs.Count;

        public bool IsFull() => _clubs.Count >= MAX_CLUBS;

        public bool AddClub(Club club)
        {
           if(IsFull())
                return false;

            _clubs.Add(club);
            return true;
        }

        public bool RemoveClub(string typeRemove)
        {
            var club = FindClubByType(typeRemove);

            if (club == null)
                return false;

            _clubs.Remove(club);
            return true;
        }

        public bool FindClubInBag(string clubType)
        {
            return FindClubByType(clubType) != null;
        }

        private Club? FindClubByType(string clubType)
        {
            return _clubs.FirstOrDefault(c =>
                c.Type.Equals(clubType, StringComparison.OrdinalIgnoreCase));
        }
    }
}
