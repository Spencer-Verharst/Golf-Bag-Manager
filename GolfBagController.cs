using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfBagManager;

namespace CS_GolfBagManager
{
    public class GolfBagController
    {
        private readonly GolfBag _myBag;
        private readonly GolfBagUI _ui;
        private readonly ClubFactory _clubFactory;

        public GolfBagController(GolfBag myBag, GolfBagUI ui)
        {
            _myBag = myBag;
            _ui = ui;
            _clubFactory = new ClubFactory();
        }

        public void Run()
        {
            bool run = true;

            while(run)
            {
                int choice = _ui.DisplayMenuAndGetMenuOption();

                switch(choice)
                {
                    case 1:
                        HandleAddClub();
                        break;
                    case 2:
                        HandleRemoveClub();
                        break;
                    case 3:
                        HandleClubCount();
                        break;
                    case 4:
                        HandleDisplay();
                        break;
                    case 5:
                        Quit();
                        run = false;
                        break;
                }
            }
        }
        
        private void HandleAddClub()
        {
            if (_myBag.IsFull())
            {
                Console.WriteLine("Sorry already 14 clubs in your bag.");
                return;
            }

            _ui.DisplayMessage("Adding club...");

            string clubType = _ui.GetValidClub("Enter Club Type (Driver, Wood, Iron, Wedge, Putter): ", "Not a valid club entry.");

            var (clubNumber, wedgeType) = GetClubSpecificDetails(clubType);

            string clubBrand = _ui.GetValidClub("Enter Club Brand: ", "Not a valid brand entry.");
            int clubDistance = _ui.GetValidDistance("Enter Club Distance(Yards): ", "distance must be a posotive number.");

            Club? newClub = _clubFactory.CreateClub(clubType, clubBrand, clubDistance, clubNumber, wedgeType);

            if(newClub != null && !_myBag.FindClubInBag(clubType) && _myBag.AddClub(newClub))
            {
                _ui.DisplayMessage($"{clubType} added to your bag!\n");
            }
            else
            {
                _ui.DisplayMessage("No club added to your bag.\n");
            }
        }

        private (int? clubNumber, string? wedgeType) GetClubSpecificDetails(string clubType)
        {
            return clubType.ToLower() switch
            {
                "wood" => (_ui.GetValidWoodNumber("Wood number (3-9): ",
                                                 "Please enter a valid wood number (3-9)."), null),
                "iron" => (_ui.GetValidIronNumber("Iron number (2-9): ",
                                                 "Please enter a valid iron number (2-9)."), null),
                "wedge" => (null, _ui.GetValidWedgeType("Wedge type (PW, AW, SW, LW): ",
                                                       "Please enter a valid wedge type.")),
                _ => (null, null)
            };
        }
        
        private void HandleRemoveClub()
        {
            if (_myBag.GetClubCount() == 0)
            {
                _ui.DisplayMessage("GolfBag already empty.\n");
                return;
            }

            _ui.DisplayMessage("Clubs to remove...");

            _ui.DisplayClubs(_myBag.GetAllClubs());

            string clubRemove = _ui.GetValidClub("Enter a club type to remove: ", "Club not in the bag.");

            if(_myBag.RemoveClub(clubRemove))
            {
                _ui.DisplayMessage($"{clubRemove} was removed from your bag.\n");
            }
            else
            {
                _ui.DisplayMessage("No club was removed\n");
            }
        }

        private void HandleClubCount()
        {
            _ui.DisplayMessage($"You have {_myBag.GetClubCount()}/14 clubs in your bag\n");
        }

        private void HandleDisplay()
        {
            _ui.DisplayClubs(_myBag.GetAllClubs());
        }

        private void Quit()
        {
            _ui.DisplayMessage("Thank you for using the GolfBag Manager!");
        }
    }
}


