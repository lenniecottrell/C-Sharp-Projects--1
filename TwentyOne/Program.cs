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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();

            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame(); //TwentyOneGame object is an instance of a higher order Game object because polymorphism
            //games.Add(game) // add the intantiated TwentyOneGame object to the game list. even with multiple game times


            //Deck deck = new Deck(); //instantiate a new deck object
            //deck.Shuffle(); //call the shuffle method from the deck class, on the new deck object

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count()); //Cards is a property of the object deck, and it is a list, so it has a number of values we can count
            //Console.ReadLine();
        }
    } 
}
