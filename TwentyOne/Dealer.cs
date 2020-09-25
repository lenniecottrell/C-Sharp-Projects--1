using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        //the dealer class has three properties
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //this method takes a list 'hand' and adds the first card from the deck, then removes it from the deck
        public void Deal(List<Card> Hand) // takes list ('hand') as an input parameter, then adds a card to the hand
        {
            Hand.Add(Deck.Cards.First()); //This grabs the first card from the deck list and adds it to the Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\lenni\Desktop\logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //remove the first item from the deck (since it's in someone's hand)


        }
    }
}
