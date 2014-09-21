using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingChallege
{
    class Game
    {
        private static int gameturn;

        public Game()
        {
            gameturn = 0;
        }
        public static int Gameturn
        {
            get { return Game.gameturn; }
        }
        private Player PlayerOne = null;
        private Player PlayerTwo = null;

        public void incrementGameturn()
        {
            gameturn++;
        }
    }
}
