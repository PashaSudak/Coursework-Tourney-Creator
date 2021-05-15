using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tourney_Creator
{
    public class Tourney
    {
        private int id { get; set; }
        private string name { get; set; }
        private string teamsId { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TeamsId
        {
            get { return teamsId; }
            set { teamsId = value; }
        }

        public List<int> getTeamsIdList()
        {
            List<int> lst = null;
            try
            {
                lst = JsonConvert.DeserializeObject<List<int>>(this.TeamsId);
            }
            catch
            {
                Console.WriteLine("ERROR: convert str to list");
            }
            return lst;
        }

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
