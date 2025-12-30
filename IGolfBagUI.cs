using System.Collections.Generic;

namespace CS_GolfBagManager
{
    public interface IGolfBagUI
    {
        int DisplayMenuAndGetMenuOption();
        void DisplayClubs(IReadOnlyList<GolfBagManager.Club> clubs);
        string GetValidClub(string prompt, string errorMessage);
        int GetValidIronNumber(string prompt, string errorMessage);
        int GetValidWoodNumber(string prompt, string errorMessage);
        int GetValidDistance(string prompt, string errorMessage);
        string GetValidWedgeType(string prompt, string errorMessage);
        void DisplayMessage(string message);
    }
}
