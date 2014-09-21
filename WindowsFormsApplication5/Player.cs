using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingChallege
{
    class Player
    {
        private String username = "";

        public String Name
        {
            get { return username; }
            set { username = value; }
        }
        private float winloseRatio = 0;

        public float WinloseRatio
        {
            get { return winloseRatio; }
            
        }
        private int gamesWon = 0;

        public int GamesWon
        {
            get { return gamesWon; }
            set { gamesWon = value; }
        }
        private int gameslost = 0;

        public int Gameslost
        {
            get { return gameslost; }
            set { gameslost = value; }
        }
        private int gamesDrown = 0;

        public int GamesDrown
        {
            get { return gamesDrown; }
            set { gamesDrown = value; }
        }

        private float calculateWLratio()
        {
            winloseRatio = gamesWon / gameslost;
            return winloseRatio;
        }

    }
}
