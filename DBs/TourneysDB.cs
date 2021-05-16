using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tourney_Creator
{
    class TourneysDB
    {
        public string connectionString = " Data Source = db.sqlite3; Version = 3 ";
        public SQLiteConnection con;
        private SQLiteDataAdapter sqliteDataAdapter = null;

        public void ConnectToSQLiteDB()
        {
            con = new SQLiteConnection(connectionString);

            try
            {
                Console.WriteLine("TRY TO CONNECT : " + connectionString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("SQLITE CONNECTED SUCCESSFULLY!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQLITE CONNECT ERROR : " + ex.Message);
            }
        }

        public void AddNewTourney(string name, string teamsId)
        {
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"INSERT INTO Tourneys (name, teamsId) VALUES (@n,@t)";
                    fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                    fmd.Parameters["@n"].Value = name;

                    fmd.Parameters.Add("@t", System.Data.DbType.String, -1);
                    fmd.Parameters["@t"].Value = teamsId;

                    fmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE ERROR : " + ex.Message);
                }
            }
        }

        public List<int> GetTeamsIds(int id)
        {
            List<int> lst = null;
            string jsonStr = "";

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT teamsId FROM tourneys WHERE id=@id";
                    fmd.Parameters.Add("@id", System.Data.DbType.String);
                    fmd.Parameters["@id"].Value = id;

                    SQLiteDataReader r = fmd.ExecuteReader();

                    while (r.Read())
                    {
                        jsonStr = Convert.ToString(r["teamsId"]);
                    }

                    lst = JsonConvert.DeserializeObject<List<int>>(jsonStr);

                    Console.WriteLine(r);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }

            return lst;
        }

        public DataTable GetDataTable()
        {
            DataSet dataSet = new DataSet();

            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM Tourneys", con);


                sqliteDataAdapter.Fill(dataSet, "Tourneys");

                return dataSet.Tables["Tourneys"];
            }
            catch
            {
                return dataSet.Tables["ERROR"];
            }
        }

        public int DeleteTourneyFromDB(int id)
        {
            int x = 0;

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"DELETE FROM Tourneys WHERE id = @id";
                    fmd.Parameters.Add("@id", System.Data.DbType.String, -1);
                    fmd.Parameters["@id"].Value = id;


                    x = fmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        Console.WriteLine("TOURNEY with id '" + id + "' DELETED SUCCESSFULLY FROM SQLITE DB!");
                    }
                    else
                    {
                        Console.WriteLine("TOURNEY with id '" + id + "' NOT FOUND FROM SQLITE DB!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }

            return x;
        }

        public Tourney GetTourney(int id)
        {
            Tourney tourney = new Tourney();
            tourney.Id = id;
            tourney.Name = "";

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT * FROM tourneys WHERE id=@id";
                    fmd.Parameters.Add("@id", System.Data.DbType.String);
                    fmd.Parameters["@id"].Value = id;

                    SQLiteDataReader r = fmd.ExecuteReader();

                    while (r.Read())
                    {
                        tourney.Name = Convert.ToString(r["name"]);
                        tourney.TeamsId = Convert.ToString(r["teamsId"]);
                    }

                    Console.WriteLine(r);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }

            return tourney;
        }

        public int updateTeamsId(int id, List<int> lst)
        {
            string jsonTeamsId = JsonConvert.SerializeObject(lst);

            int x = 0;
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"UPDATE Tourneys SET teamsId = @t WHERE id = @id";
                    fmd.Parameters.Add("@id", System.Data.DbType.String, -1);
                    fmd.Parameters["@id"].Value = id;

                    fmd.Parameters.Add("@t", System.Data.DbType.String, -1);
                    fmd.Parameters["@t"].Value = jsonTeamsId;

                    x = fmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE UPDATE ERROR : " + ex.Message);
                }
            }
            return x;
        }
    }
}
