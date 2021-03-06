﻿    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SQLite;

    namespace Tourney_Creator
    {
        class TeamsDB
        {
            public string connectionString = " Data Source = db.sqlite3; Version = 3 ";
            public SQLiteConnection con;
            public SQLiteDataAdapter sqliteDataAdapter;

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

            public void AddNewTeam(string name)
            {
                int wins = 0;
                int loses = 0;
                int winrate = 100;

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"INSERT INTO Teams (name, wins, loses, winrate) VALUES (@n,@w,@l,@wr)";
                        fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                        fmd.Parameters["@n"].Value = name;

                        fmd.Parameters.Add("@w", System.Data.DbType.String, -1);
                        fmd.Parameters["@w"].Value = wins;

                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = loses;

                        fmd.Parameters.Add("@wr", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@wr"].Value = winrate;

                        fmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE ERROR : " + ex.Message);
                    }
                }
            }

            public int DeleteTeamFromDB(int id)
            {
                int x = 0;

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"DELETE FROM Teams WHERE id = @id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String, -1);
                        fmd.Parameters["@id"].Value = id;


                        x = fmd.ExecuteNonQuery();
                        if (x != 0)
                        {
                            Console.WriteLine("TEAM with id '" + id + "' DELETED SUCCESSFULLY FROM SQLITE DB!");
                        }
                        else
                        {
                            Console.WriteLine("TEAM with id '" + id + "' NOT FOUND FROM SQLITE DB!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                return x;
            }

            public DataTable GetDataTable()
            {
                DataSet dataSet = new DataSet();

                try
                {
                    sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM Teams", con);


                    sqliteDataAdapter.Fill(dataSet, "Teams");

                    return dataSet.Tables["Teams"];
                }
                catch
                {
                    return dataSet.Tables["ERROR"];
                }
            }

            public bool isExist(int id)
            {
                int idFromDb = 0;
                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT id FROM Teams WHERE id=@id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String);
                        fmd.Parameters["@id"].Value = id;

                        SQLiteDataReader r = fmd.ExecuteReader();

                        while (r.Read())
                        {
                            idFromDb = Convert.ToInt32(r["id"]);
                        }

                        if (Convert.ToBoolean(idFromDb))
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                       
                    }
                }

                return false;
            }

            public void addWinLose(int id, bool isWin)
            {
                int count = 0;

                string rowName;
                if (isWin) rowName = "wins";
                else rowName = "loses";

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        if (isWin) fmd.CommandText = @"SELECT wins FROM Teams WHERE id=@id";
                        else fmd.CommandText = @"SELECT loses FROM Teams WHERE id=@id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String);
                        fmd.Parameters["@id"].Value = id;

                        SQLiteDataReader r = fmd.ExecuteReader();

                        while (r.Read())
                        {
                            count = Convert.ToInt32(r[rowName]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }

                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        if (isWin) fmd.CommandText = @"UPDATE Teams SET wins = @wl WHERE id = @id";
                        else fmd.CommandText = @"UPDATE Teams SET loses = @wl WHERE id = @id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String, -1);
                        fmd.Parameters["@id"].Value = id;

                        fmd.Parameters.Add("@wl", System.Data.DbType.String, -1);
                        fmd.Parameters["@wl"].Value = count + 1;

                        fmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE UPDATE ERROR : " + ex.Message);
                    }
                }
            }

            public string GetTeamName(int id)
            {
                string teamName = "";
                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT name FROM Teams WHERE id=@id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String);
                        fmd.Parameters["@id"].Value = id;

                        SQLiteDataReader r = fmd.ExecuteReader();

                        while (r.Read())
                        {
                            teamName = Convert.ToString(r["name"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }

                return teamName;
            }

            public void updateWinrate(int id)
            {
                float wins = 0;
                float loses = 0;
                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT wins, loses FROM Teams WHERE id=@id";
                        fmd.Parameters.Add("@id", System.Data.DbType.String);
                        fmd.Parameters["@id"].Value = id;

                        SQLiteDataReader r = fmd.ExecuteReader();

                        while (r.Read())
                        {
                            wins = Convert.ToInt32(r["wins"]);
                            loses = Convert.ToInt32(r["loses"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }

                if (loses != 0)
                {
                    float winrate;

                    winrate = (wins / (wins + loses)) * 100;

                    Console.WriteLine("wr" + winrate);

                    using (SQLiteCommand fmd = con.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"UPDATE Teams SET winrate=@wr WHERE id=@id";
                            fmd.Parameters.Add("@id", System.Data.DbType.String);
                            fmd.Parameters["@id"].Value = id;

                            fmd.Parameters.Add("@wr", System.Data.DbType.String);
                            fmd.Parameters["@wr"].Value = Convert.ToInt32(winrate);

                            SQLiteDataReader r = fmd.ExecuteReader();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("SQLITE UPDATE ERROR : " + ex.Message);
                        }
                    }
                }
            }
        }
    }
