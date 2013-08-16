using System;

namespace _99BottlesSlim
{
    class SingTheSong
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SINGING THE '99 Bottles of Beer' SONG!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteLyrics("beer", 99);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It sounds like the song is finished or you are too drunk to buy some more bottles.. :-)\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("See you for the next binge!");
            Console.ReadKey();
        }

        static void WriteLyrics(string beverage, int numberOfBottles)
        { 
            for (int i = numberOfBottles; i > 0; --i)
            { 
                Console.WriteLine(String.Format("{0} bottle{1} of {2} on the wall, {0} bottle{1} of {2}. \nTake one down, pass it around.\n", i, (i == 1) ? "" : "s", beverage));
            }

            Console.WriteLine(String.Format("No more bottles of {0} on the wall, no more bottles of {0}. \nGo to the store and buy some more, {1} bottles of {0} on the wall! Oh yeah!\n", beverage,numberOfBottles));
        }
    }
}
