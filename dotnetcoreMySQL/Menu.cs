using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcoreMySQL
{
    class Menu
    {
        public void Main(string name)
        {
            Console.Write($"Welcome to Dotnet Core {name}! \n");
            Console.WriteLine("\n");
            Console.WriteLine("Please Select a Command and Type: Add, Edit, Delete, Logout \n");
            Command();

            Console.Read();
        }
        void Command()
        {
            var cmd = Console.ReadLine();
            CRUD crud = new CRUD();

            if (cmd == "Add")
            {
                Console.WriteLine("Please Type a User Name \n");
                var name = Console.ReadLine();
                Console.WriteLine("Please Type a Password \n");
                var pass = Console.ReadLine();
                crud.AddData(name, pass);
            }
            Console.Read();
        }
    }
}
