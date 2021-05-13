using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tourney_Creator
{
    class TourneysDB
    {
        public string connectionString = " Data Source = db.sqlite3; Version = 3 ";
        public SQLiteConnection con;

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

        public void GetTeamsIds(int id)
        {
            List<int> lst;
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT teamsId FROM tourneys WHERE id=@id";
                    fmd.Parameters.Add("@id", System.Data.DbType.String);
                    fmd.Parameters["@id"].Value = id;

                    SQLiteDataReader r = fmd.ExecuteReader();

                    Console.WriteLine(r);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }
            Console.WriteLine(id);
            return;
        }
    }
}
