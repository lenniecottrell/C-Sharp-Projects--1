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
        //public static Deck Shuffle(Deck deck, int times) //this is an overloaded method from Shuffle - one extra parameter
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
