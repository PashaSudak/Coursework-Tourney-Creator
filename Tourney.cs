using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_Creator
{
    class Tourney
    {
        private int id { get; set; }
        private string name { get; set; }
        private string teamsId { get; set; }

        public Tourney()
        {

        }

        public Tourney(string name, string teamsId)
        {
            this.name = name;
            this.teamsId = teamsId;
        }
    }
}
