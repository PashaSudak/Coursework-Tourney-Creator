using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.AccessControl;

namespace Tourney_Creator
{
    class UsersDB
    {
        public string connectionString = " Data Source = users.sqlite3; Version = 3 ";
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

        public int IsLoginAndPasswordCorrect(string login, string pass)
        {
            // -1 incorrect
            // 0 user
            // 1 admin

            int rights = -1;
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;

                    fmd.Parameters.Add("@p", System.Data.DbType.String, -1);
                    fmd.Parameters["@p"].Value = pass;

                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        rights = Convert.ToInt32(r["rights"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }
            return rights;
        }

        public void AddNewUser(string login, string pass)
        {
            int rights = 0;

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"INSERT INTO Users (login, pass, rights) VALUES (@l,@p,@r)";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;

                    fmd.Parameters.Add("@p", System.Data.DbType.String, -1);
                    fmd.Parameters["@p"].Value = pass;

                    fmd.Parameters.Add("@r", System.Data.DbType.Int32, -1);
                    fmd.Parameters["@r"].Value = rights;

                    fmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE ERROR : " + ex.Message);
                }
            }
        }
        //===============================================================================================
        public int DeleteUserFromDB()
        {// CheckLogin and Password. 0 - fail; other - it's user id
            string login;
            Console.Write("LOGIN : "); login = Console.ReadLine();
            int x = 0;
            Console.Write("Do you really want to delete user '" + login + "' [Y/N]?");
            ConsoleKeyInfo UserInput = Console.ReadKey(); // Get user input

            if (!(UserInput.KeyChar.ToString() == "y" || UserInput.KeyChar.ToString() == "Y"))
            {
                Console.Write("Deleting user '" + login + "' has been cancelled");
                return 0;
            }

            Console.Write("\n");
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                    fmd.CommandText = @"DELETE FROM users WHERE login = @l";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;


                    x = fmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        Console.WriteLine("USER '" + login + "' DELETED SUCCESSFULLY FROM SQLITE DB!");
                    }
                    else
                    {
                        Console.WriteLine("USER '" + login + "' NOT FOUND FROM SQLITE DB!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }

            return x;

        }
        //===============================================================================================

        public int ModifyUserPassword()
        {// CheckLogin and Password. 0 - fail; other - it's user id
            string login, dbpass = "", pass, new_pass1, new_pass2;
            Console.WriteLine("CHANGING PASSWORD FOR USER.");
            Console.Write("LOGIN : "); login = Console.ReadLine();

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                    fmd.CommandText = @"SELECT password FROM users WHERE login = @l";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;

                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        //Console.WriteLine("->"+ (int)r["id"]);
                        dbpass = Convert.ToString(r["password"]);
                        //user_id = (int)r["id"];
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }
            if (dbpass == "")
            {
                Console.Write("ERROR : USER " + login + " NOT FOUNDED!"); ;
                return 0;
            }

            Console.Write("OLD PASSWORD : "); pass = Console.ReadLine();


            if (pass != dbpass)
            {
                Console.Write("ERROR : INCORRECT CURRENT USER " + login + " PASSWORD!"); ;
                return 0;
            }

            Console.Write("NEW PASSWORD : "); new_pass1 = Console.ReadLine();
            Console.Write("Confirm new PASSWORD : "); new_pass2 = Console.ReadLine();
            if (new_pass1 != new_pass2)
            {
                return 0;
            }

            int x = 0;
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    // fmd.CommandText = @"SELECT id FROM users WHERE login=@l AND password=@p";
                    fmd.CommandText = @"UPDATE users SET password = @np WHERE login = @l AND password = @p";
                    fmd.Parameters.Add("@l", System.Data.DbType.String, -1);
                    fmd.Parameters["@l"].Value = login;

                    fmd.Parameters.Add("@p", System.Data.DbType.String, -1);
                    fmd.Parameters["@p"].Value = pass;

                    fmd.Parameters.Add("@np", System.Data.DbType.String, -1);
                    fmd.Parameters["@np"].Value = new_pass1;

                    x = fmd.ExecuteNonQuery();
                    Console.WriteLine("NEW PASSWORD FOR USER '" + login + "' CHANGED SUCCESSFULLY IN SQLITE DB!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                }
            }
            return x;
        }
    }
}
