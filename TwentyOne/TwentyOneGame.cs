using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway //inherits from the superclass "Game" and the interface IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() //abstract method inherited from Game
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players) //Players is a property of the Game class
            {  //at the beginning of the play method, we want to set everything fresh again
                player.Hand = new List<Card>(); //fresh hand
                player.Stay = false; //not staying because it's a new game
            }
            Dealer.Hand = new List<Card>(); //fresh hand for the dealer
            Dealer.Stay = false; // not staying because its a new game
            Dealer.Deck = new Deck(); //fresh deck for the dealer too
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); //passing in the amount they bet into the Bet method
                if (!successfullyBet)
                {
                    return; //this doesn't return anything because Play() is a void method, but it ends the method
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); //passing in the player's hand, then the hand is given a card, then that card is printed to the console.
                    if (i == 1) //if it's the second turn
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); //pass in the player's hand to check it for blackjack
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //player gets their bet back plus 1.5 the same amount
                            return;
                        }
                    }
                }
                Console.Write("Dealer: "); //lets the user know it's the dealer's turn
                Dealer.Deal(Dealer.Hand); //deal a hand to the dealer
                if (i == 1) //if it's the second turn
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //check the Dealer's hand for blackjack
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);

                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); //pass in the player's hand to see if they busted
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.IsActivelyPlaying = true; //the Play() method only runs while IsActivelyPlaying is true
                            return;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //use entry.Key to access properties of the key
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //this give everyone their bet back plus the same amount. Where() produced a list, First() grabs the first value 
                    Dealer.Balance -= entry.Value; //takes each person's bet away from the dealer
                }
                return;
            }
            foreach (Player player in Players) //loop through each player and compare their hand to the dealer's
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y")
                {
                    player.IsActivelyPlaying = true;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers() //virtual method inherited from Game
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player) //method inherited from IWalkAway interface
        {
            throw new NotImplementedException();
        }
    }
}
