using System;
using System.Linq;
using System.Collections.Generic;

namespace CardPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

            Console.WriteLine("Here are the cards...");

            deck.PrintCards();

            Console.WriteLine("Press any key to continue and see the cards randomized...");
            Console.ReadKey();

            deck.Shuffle();
            deck.PrintCards();

            Console.WriteLine("Press any key again to continue and see the cards sorted...");
            Console.ReadKey();

            deck.Sort();
            deck.PrintCards();
            
        }
    }
}
