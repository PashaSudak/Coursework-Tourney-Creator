using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_Creator
{
    class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public int wins { get; set; }
        public int loses { get; set; }

        private float winrate;

        public float Winrate
        {
            get
            {
                try
                {
                    winrate = wins / loses;
                    return winrate;
                }
                catch
                {
                    return 100;
                }
            }
        }

        public Team()
        {
        }

        public Team(string name)
        {
            this.name = name;
            this.wins = 0;
            this.loses = 0;
        }
    }
}
