using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //this is a constructor. The name of it is always the same as the class
        {
            Cards = new List<Card>(); //this instantiates a new empty list using the property of the class
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //list of suits
            List<string> Faces = new List<string>() //list of faces
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) // nested loop - for each face, loop through all the suits
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); // instantiate a new card
                    card.Suit = suit; // assign suit to the one we're currently looping on
                    card.Face = face; // assign face to the one we're currently looping on
                    Cards.Add(card); // add the new card to the list of cards

                }
            }

        }
        public List<Card> Cards { get; set; }
    }
}
