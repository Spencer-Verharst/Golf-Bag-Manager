using System;
namespace GolfBagManager
{
    class GolfBag
    {
        private List<Club> clubs;
        private const int maxClubs = 14;

        public GolfBag()
        {
            clubs = new List<Club>();
        }

        public bool AddClub(string typeInput, string brandInput, int distanceInput)
        {
            if (clubs.Count >= maxClubs)
            {
                Console.WriteLine("\nGolf Bag already has 14 clubs.\n");
                return false;
            }

            clubs.Add(new Club(typeInput, brandInput, distanceInput));
        
            Console.WriteLine($"\n{typeInput} added to bag.\n");
            return true;
        }

        public bool RemoveClub(string typeRemove)
        {
            foreach(var club in clubs)
            {
                if (club.Type.Equals(typeRemove, StringComparison.OrdinalIgnoreCase) == true)
                {

                    Console.WriteLine($"\n{typeRemove} removed successfully.\n");
                    return true;
                }
            }

            Console.WriteLine($"\n{typeRemove} not found in bag.\n");
            return false;
        }

        public void DisplayBag()
        {
            if (clubs.Count == 0)
            {
                Console.WriteLine("\nYour golf bag is empty.\n");
                return;
            }

            for (int i = 0; i < clubs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clubs[i]}");
            }
        }

        public int GetNumOfClubs()
        {
            return clubs.Count;
        }
    }
}
