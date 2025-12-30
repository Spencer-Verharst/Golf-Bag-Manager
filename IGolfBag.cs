using System.Collections.Generic;

namespace GolfBagManager
{
    public interface IGolfBag
    {
        IReadOnlyList<Club> GetAllClubs();
        int GetClubCount();
        bool IsFull();
        bool AddClub(Club club);
        bool RemoveClub(string typeRemove);
        bool FindClubInBag(string clubType);
    }
}