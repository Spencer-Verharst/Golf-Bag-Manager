using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBagManager;

namespace CS_GolfBagManager
{
    public class GolfBagUI
    {
        public int DisplayMenuAndGetMenuOption()
        {
            int choice;

            Console.WriteLine("1:   Add Club");
            Console.WriteLine("2:   Remove Club");
            Console.WriteLine("3:   Get Number of Clubs");
            Console.WriteLine("4:   Display Bag");
            Console.WriteLine("5:   QUIT");
            Console.Write("Whats your choice: ");

            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            { 
                Console.Write("Please pick a proper choice: ");
            }

            Console.WriteLine();

            return choice;
        }

        public void DisplayClubs(IReadOnlyList<Club> clubs)
        {
            Console.WriteLine("\n========== Your Golf Bag ==========");
            Console.WriteLine($"Clubs: {clubs.Count}/14\n");

            if (clubs.Count == 0)
            {
                Console.WriteLine("Your bag is empty.\n");
            }
            else
            {
                for (int i = 0; i < clubs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {clubs[i]}");
                }
            }

            Console.WriteLine("===================================\n");
        }
        
        public string GetValidClub(string prompt, string errorMessage)
        {
            string? input = "";

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"\nError: {errorMessage}\n");
                }
            }

            return input;
        }

        public int GetValidInteger(string prompt, string errorMessage, int min, int max)
        {
            int value = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out value) && value > min && value < max)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\nError: {errorMessage}\n");
                }
            }

            return value;
        }

        public int GetValidIronNumber(string prompt, string errorMessage)
        {
            return GetValidInteger(prompt, errorMessage, 1, 10);
        }

        public int GetValidWoodNumber(string prompt, string errorMessage)
        {
            return GetValidInteger(prompt, errorMessage, 2, 8);
        }

        public int GetValidDistance(string prompt, string errorMessage)
        {
            return GetValidInteger(prompt, errorMessage, 0, int.MaxValue);
        }

        public string GetValidWedgeType(string prompt, string errorMessage)
        {
            while (true)
            {
                Console.Write(prompt);
                string? wedgeType = Console.ReadLine()?.ToUpper();

                if (!string.IsNullOrWhiteSpace(wedgeType) &&
                    (wedgeType == "PW" || wedgeType == "AW" || wedgeType == "SW" || wedgeType == "LW"))
                {
                    return wedgeType; 
                }

                Console.WriteLine($"\nError: {errorMessage}\n");
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

