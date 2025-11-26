using System;
namespace GolfBagManager
{
    class GolfBag
    {
        private Club?[] clubs;
        private int clubCount;

        public GolfBag()
        {
            clubs = new Club?[14];
            clubCount = 0;
        }

        public bool AddClub()
        {
            if (clubCount >= 14)
            {
                Console.WriteLine("\nGolf Bag already has 14 clubs.\n");
                return false;
            }

            Console.WriteLine("\nAdding a new club to your bag...");
            Console.Write("What type of club (Driver, Wood, Iron, Putter...): ");
            string? type = Console.ReadLine();

            Console.Write("Whats your club brand: ");
            string? brand = Console.ReadLine();

            Console.Write("How far does this club go (Yards): ");
            string? distanceInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("\nError: Club type cannot be empty.\n");
                return false;
            }

            if (string.IsNullOrWhiteSpace(brand))
            {
                Console.WriteLine("\nError: Club brand cannot be empty.\n");
                return false;
            }

            if (!int.TryParse(distanceInput, out int distance) || distance <= 0)
            {
                Console.WriteLine("\nError: Distance must be a positive number.\n");
                return false;
            }

            clubs[clubCount] = new Club(type, brand, distance);
            clubCount++;
            Console.WriteLine($"\n{type} added to bag.\n");
            return true;
        }

        public bool RemoveClub()
        {
            Console.Write("\nWhat club do you want to remove: ");
            string? type = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("\nError: Please enter a club type.\n");
                return false;
            }

            for (int i = 0; i < clubCount; i++)
            {
                if (clubs[i]?.Type.Equals(type, StringComparison.OrdinalIgnoreCase) == true)
                {
                    for (int j = i; j < clubCount - 1; j++)
                    {
                        clubs[j] = clubs[j + 1];
                    }

                    clubs[clubCount - 1] = null;
                    clubCount--;
                    Console.WriteLine($"\n{type} removed successfully.\n");
                    return true;
                }
            }

            Console.WriteLine($"\n{type} not found in bag.\n");
            return false;
        }

        public void DisplayBag()
        {
            if (clubCount == 0)
            {
                Console.WriteLine("\nYour golf bag is empty.\n");
                return;
            }

            Console.WriteLine("\n========== Your Golf Bag ==========");
            Console.WriteLine($"Clubs: {clubCount}/14\n");

            for (int i = 0; i < clubCount; i++)
            {
                if (clubs[i] != null)
                {
                    Console.WriteLine($"{i + 1}. {clubs[i]}");
                }
            }

            Console.WriteLine("===================================\n");
        }

        public int GetNumOfClubs()
        {
            return clubCount;
        }
    }
}