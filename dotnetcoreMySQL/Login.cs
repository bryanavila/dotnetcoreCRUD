using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace dotnetcoreMySQL
{
    class Login
    {
        public void LoginData()
        {
            Console.Write("Please login the account info \n");
            Console.Write("Please type your User Name: \n");
            var name = Console.ReadLine();
            Data.username = name;
            Console.Write("Please type your User Password: \n");
            var pass = Console.ReadLine();
            using (MySqlConnection con = new MySqlConnection(Data.conn))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM tbluser WHERE username=@1 and userpass=@2", con))
                {
                    cmd.Parameters.AddWithValue("@1", name);
                    cmd.Parameters.AddWithValue("@2", pass);


                   int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if(count == 1)
                    {
                        Console.Clear();
                        Menu m = new Menu();
                        m.Main(name);
                        
                        
                    }
                    else if(count != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong User Name or Password Please Try Again! \n");
                        LoginData();
                    }
                }
            }
        }
    }
}
