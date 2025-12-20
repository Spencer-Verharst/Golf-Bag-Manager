using System;
using CS_GolfBagManager;
namespace GolfBagManager
{
    class TestingBag
    {
        static void Main()
        {
            var bag = new GolfBag();
            var ui = new GolfBagUI();
            var controller = new GolfBagController(bag, ui);

            controller.Run();
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

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Driver
Enter Club Brand: Taylormade Sim 2 Max
Enter Club Distance(Yards): 275
Driver added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wood
Wood number (3-9): 3
Enter Club Brand: Ping G430 Max
Enter Club Distance(Yards): 240
Wood added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wood
Wood number (3-9): 5
Enter Club Brand: Ping G430 Max
Enter Club Distance(Yards): 225
Wood added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 4
Enter Club Brand: Srixon ZXI 5
Enter Club Distance(Yards): 200
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 5
Enter Club Brand: Srixon ZXI 5
Enter Club Distance(Yards): 190
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 6
Enter Club Brand: Srixon ZXI 5
Enter Club Distance(Yards): 180
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 7
Enter Club Brand: Srixon ZXI 7
Enter Club Distance(Yards): 170
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 8
Enter Club Brand: Srixon ZXI 7
Enter Club Distance(Yards): 160
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Iron
Iron number (2-9): 9
Enter Club Brand: Srixon ZXI 7
Enter Club Distance(Yards): 150
Iron added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wedge
Wedge type (PW, AW, SW, LW): PW
Enter Club Brand: Srixon ZXI 7
Enter Club Distance(Yards): 140
Wedge added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wedge
Wedge type (PW, AW, SW, LW): AW
Enter Club Brand: Vokey SM9
Enter Club Distance(Yards): 120
Wedge added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wedge
Wedge type (PW, AW, SW, LW): SW
Enter Club Brand: Vokey SM9
Enter Club Distance(Yards): 110
Wedge added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Wedge
Wedge type (PW, AW, SW, LW): LW
Enter Club Brand: Vokey SM9
Enter Club Distance(Yards): 100
Wedge added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 1

Adding club...
Enter Club Type (Driver, Wood, Iron, Wedge, Putter): Putter
Enter Club Brand: Scotty Cameron GoLo 5
Enter Club Distance(Yards): 1
Putter added to your bag!

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 3

You have 14/14 clubs in your bag

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 4


========== Your Golf Bag ==========
Clubs: 14/14

1. Driver - Taylormade Sim 2 Max (275 yards)
2. 3-Wood - Ping G430 Max (240 yards)
3. 5-Wood - Ping G430 Max (225 yards)
4. 4-Iron - Srixon ZXI 5 (200 yards)
5. 5-Iron - Srixon ZXI 5 (190 yards)
6. 6-Iron - Srixon ZXI 5 (180 yards)
7. 7-Iron - Srixon ZXI 7 (170 yards)
8. 8-Iron - Srixon ZXI 7 (160 yards)
9. 9-Iron - Srixon ZXI 7 (150 yards)
10. PW Wedge - Srixon ZXI 7 (140 yards)
11. AW Wedge - Vokey SM9 (120 yards)
12. SW Wedge - Vokey SM9 (110 yards)
13. LW Wedge - Vokey SM9 (100 yards)
14. Putter - Scotty Cameron GoLo 5 (1 yards)
===================================

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 2

Clubs to remove...

========== Your Golf Bag ==========
Clubs: 14/14

1. Driver - Taylormade Sim 2 Max (275 yards)
2. 3-Wood - Ping G430 Max (240 yards)
3. 5-Wood - Ping G430 Max (225 yards)
4. 4-Iron - Srixon ZXI 5 (200 yards)
5. 5-Iron - Srixon ZXI 5 (190 yards)
6. 6-Iron - Srixon ZXI 5 (180 yards)
7. 7-Iron - Srixon ZXI 7 (170 yards)
8. 8-Iron - Srixon ZXI 7 (160 yards)
9. 9-Iron - Srixon ZXI 7 (150 yards)
10. PW Wedge - Srixon ZXI 7 (140 yards)
11. AW Wedge - Vokey SM9 (120 yards)
12. SW Wedge - Vokey SM9 (110 yards)
13. LW Wedge - Vokey SM9 (100 yards)
14. Putter - Scotty Cameron GoLo 5 (1 yards)
===================================

Enter a club type to remove: Putter
Putter was removed from your bag.

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 4


========== Your Golf Bag ==========
Clubs: 13/14

1. Driver - Taylormade Sim 2 Max (275 yards)
2. 3-Wood - Ping G430 Max (240 yards)
3. 5-Wood - Ping G430 Max (225 yards)
4. 4-Iron - Srixon ZXI 5 (200 yards)
5. 5-Iron - Srixon ZXI 5 (190 yards)
6. 6-Iron - Srixon ZXI 5 (180 yards)
7. 7-Iron - Srixon ZXI 7 (170 yards)
8. 8-Iron - Srixon ZXI 7 (160 yards)
9. 9-Iron - Srixon ZXI 7 (150 yards)
10. PW Wedge - Srixon ZXI 7 (140 yards)
11. AW Wedge - Vokey SM9 (120 yards)
12. SW Wedge - Vokey SM9 (110 yards)
13. LW Wedge - Vokey SM9 (100 yards)
===================================

1:   Add Club
2:   Remove Club
3:   Get Number of Clubs
4:   Display Bag
5:   QUIT
Whats your choice: 5

Thank you for using the GolfBag Manager!

 */




