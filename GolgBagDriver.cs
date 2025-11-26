using System;
namespace GolfBagManager
{
    class TestingBag
    {
        static void Main()
        {
            GolfBag myBag = new GolfBag();
            bool running = true;
            while (running)
            {
                Console.WriteLine("1:   Add Club");
                Console.WriteLine("2:   Remove Club");
                Console.WriteLine("3:   Get Number of Clubs");
                Console.WriteLine("4:   Display Bag");
                Console.WriteLine("5:   QUIT");
                Console.Write("Whats your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            myBag.AddClub();
                            break;
                        case 2:
                            myBag.RemoveClub();
                            break;
                        case 3:
                            Console.WriteLine($"\nClubs: {myBag.GetNumOfClubs()}\n");
                            break;
                        case 4:
                            myBag.DisplayBag();
                            break;
                        case 5:
                            running = false;
                            Console.WriteLine("\nThanks for using Golf Bag Manager!\n");
                            break;
                        default:
                            Console.WriteLine("\nNot a proper choice.\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.\n");
                }
            }
        }
    }
}

/*
1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): Driver
Whats your club brand: TaylorMade Sim 2 Max
How far does this club go (Yards): 275

Driver added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 3 Wood
Whats your club brand: Ping G430 Max
How far does this club go (Yards): 240

3 Wood added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 5 Wood
Whats your club brand: Ping G430 Max
How far does this club go (Yards): 225

5 Wood added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 4 Iron
Whats your club brand: Srixon ZXI 5
How far does this club go (Yards): 200

4 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 5 Iron
Whats your club brand: Srixon ZXI 5
How far does this club go (Yards): 190

5 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 6 Iron
Whats your club brand: Srixon ZXI 5
How far does this club go (Yards): 180

6 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 7 Iron
Whats your club brand: Srixon ZXI 7
How far does this club go (Yards): 175

7 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 8 Iron
Whats your club brand: Srixon ZXI 7
How far does this club go (Yards): 160

8 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): 9 Iron
Whats your club brand: Srixon ZXI 7
How far does this club go (Yards): 150

9 Iron added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): P Wedge
Whats your club brand: Srixon ZXI 7
How far does this club go (Yards): 130

P Wedge added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): A Wedge
Whats your club brand: Vokey SM9
How far does this club go (Yards): 120

A Wedge added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): S Wedge
Whats your club brand: Vokey SM9
How far does this club go (Yards): 110

S Wedge added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding a new club to your bag...
What type of club (Driver, Wood, Iron, Putter...): L Wedge
Whats your club brand: Vokey SM9
How far does this club go (Yards): 100

L Wedge added to bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 4

========== Your Golf Bag ==========
Clubs: 13/14

1. Driver - TaylorMade Sim 2 Max (275 yards)
2. 3 Wood - Ping G430 Max (240 yards)
3. 5 Wood - Ping G430 Max (225 yards)
4. 4 Iron - Srixon ZXI 5 (200 yards)
5. 5 Iron - Srixon ZXI 5 (190 yards)
6. 6 Iron - Srixon ZXI 5 (180 yards)
7. 7 Iron - Srixon ZXI 7 (175 yards)
8. 8 Iron - Srixon ZXI 7 (160 yards)
9. 9 Iron - Srixon ZXI 7 (150 yards)
10. P Wedge - Srixon ZXI 7 (130 yards)
11. A Wedge - Vokey SM9 (120 yards)
12. S Wedge - Vokey SM9 (110 yards)
13. L Wedge - Vokey SM9 (100 yards)
===================================

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 5

Thanks for using Golf Bag Manager!
 */