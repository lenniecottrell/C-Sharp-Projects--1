using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //this method takes a list 'hand' and adds the first card from the deck, then removes it from the deck
        public void Deal(List<Card> Hand) // takes a list as an input parameter ('hand'), then adds a card to the hand
        {
            Hand.Add(Deck.Cards.First()); //This grabs the first card from the deck list and adds it to the Hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); //remove the first item from the deck (after it's in someone's hand)


        }
    }
}
