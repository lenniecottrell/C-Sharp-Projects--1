using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args) //this is the "main" method
        {
            TwentyOneGame game = new TwentyOneGame(); //instantiating a new object called game from the TwentyOneGame class
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            Deck deck = new Deck(); //instantiate a new deck object
            deck.Shuffle(); //call the shuffle method from the deck class, on the new deck object

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count()); //Cards is a property of the object deck, and it is a list, so it has a number of values we can count
            Console.ReadLine();
        }
    } 
}
