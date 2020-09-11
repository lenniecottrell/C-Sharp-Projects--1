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
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count()); //Cards is a property of the object deck, and it is a list, so it has a number of values we can count
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) // Method! --> accessible everwhere, no object created first, data type "Deck", name "Shuffle" (data type Deck, name deck)
            //by giving the second parameter a default value, it becomes an optional parameter
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random(); // instantiate a new random object using the random class from the built-in library

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //get a random number between 0 and the length of deck.Cards
                    TempList.Add(deck.Cards[randomIndex]); //add the card at that index to the temporary list
                    deck.Cards.RemoveAt(randomIndex); // remove that card from deck.Cards
                                                      //then do it again until no more cards are left
                }
                deck.Cards = TempList; //put the temp list back into the original list object
            }
            
            return deck; // return the original list object

        } 
        //public static Deck Shuffle(Deck deck, int times) //this is an overloaded method from Shuffle - one extra parameter
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
