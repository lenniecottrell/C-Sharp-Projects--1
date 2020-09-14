using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneGame : Game //inherits from the superclass "Game"
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers() //virtual method inherited from Game
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
    }
}
