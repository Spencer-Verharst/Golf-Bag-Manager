namespace GolfBagManager
{
    public interface IClubFactory
    {
        Club? CreateClub(string type, string brand, int distance, int? number = null, string? wedgeType = null);
    }
}