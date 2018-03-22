using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dotnetcoreMySQL
{
    class CRUD
    {
        public void AddData(string name, string pass)
        {
            using (MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tbluser (username, userpass) VALUES (@1, @2)", con))
                {
                    cmd.Parameters.AddWithValue("@1", name);
                    cmd.Parameters.AddWithValue("@2", pass);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("\n");
                    Console.WriteLine("User Successfuly Added!");
                }
            }
        }
    }
}
