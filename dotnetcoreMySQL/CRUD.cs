using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dotnetcoreMySQL
{
    class CRUD
    {
        Menu menu = new Menu();
        public void AddData(string name, string pass)
        {
            using (MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbluser (username, userpass) VALUES (@username, @userpass)", con))
                {
                    cmd.Parameters.AddWithValue("@username", name);
                    cmd.Parameters.AddWithValue("@userpass", pass);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n");
                    Console.WriteLine("User Successfuly Added!");
                }
            }
        }
        public void EditData(string id, string name, string pass)
        {
            using(MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using(MySqlCommand cmd = new MySqlCommand("EDIT tbluser SET username=@username, userpass=@userpass WHERE entryid=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", name);
                    cmd.Parameters.AddWithValue("@userpass", pass);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n");
                    Console.WriteLine("User Successfuly Edited!");
                }
            }
        }
        public void DeleteData(string id)
        {
            using(MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using(MySqlCommand cmd = new MySqlCommand("DELETE FROM tbluser WHERE entryid=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n");
                    Console.WriteLine("User Successfuly Deleted!");
                }
            }
        }

        public void getData()
        {
            using(MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using(MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbluser", con))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"User Id: {reader.GetString(0)}");
                            Console.WriteLine($"User Name: {reader.GetString(1)}");
                            Console.WriteLine($"User Password: {reader.GetString(2)}");
                            Console.WriteLine("\n");
                        }
                    }
                }
            }
        }
    }
}
