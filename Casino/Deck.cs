using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() //this is a constructor. The name of it is always the same as the class
        {
            Cards = new List<Card>(); //this instantiates a new empty list using the property of the class

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //i is an integer, and we're casting i to the enum Face (outer for loop)
                    card.Suit = (Suit)j; //j is an integer, and we're casting j to the enum Suit (inner for loop)
                    Cards.Add(card); //add the new card to the cards list
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) // Method! --> accessible everwhere, data type "Deck", name "Shuffle"
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random(); // instantiate a new random object using the random class from the built-in library

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //get a random number between 0 and the length of deck.Cards
                    TempList.Add(Cards[randomIndex]); //add the card at that index to the temporary list
                    Cards.RemoveAt(randomIndex); // remove that card from deck.Cards
                                                 //then do it again until no more cards are left
                }
                Cards = TempList; //put the temp list back into the original list object
            }
        }
    }
}
