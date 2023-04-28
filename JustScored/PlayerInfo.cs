using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustScored
{
    public class PlayerInfo
    {
        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;

        public string Name { get; }

        public float MaxScore
        {
            get
            {
                return maxScore;
            }
            set
            {
                if (value > maxScore)
                {
                    maxScore = value;
                }
            }
        }

        public float RateOfSuccess
        {
            get
            {
                if (gamesPlayed == 0)
                {
                    return 0;
                }

                return gamesWon / gamesPlayed;
            }
        }

        public void AddGame(bool win)
        {
            gamesPlayed += 1;

            if (win == true)
            {
                gamesWon += 1;
            }
        }

        public PlayerInfo(string Name)
        {
            this.Name = Name;
            maxScore = 0;
            gamesPlayed = 0;
            gamesWon = 0;
        }
    }
}