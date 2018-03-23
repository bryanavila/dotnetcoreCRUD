using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcoreMySQL
{
    class Menu
    {
        public void Main(string name)
        {
            Console.Write($"Welcome to Dotnet Core {name}!");
            Console.WriteLine("\n");
            Console.WriteLine("Please Select a Command and Type: List, Add, Edit, Delete, Logout");
            Command();

            Console.Read();
        }
        void Command()
        {
            var cmd = Console.ReadLine();
            CRUD crud = new CRUD();

            if (cmd == "Add")
            {
                Console.WriteLine("Please Type a User Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Please Type a Password: ");
                var pass = Console.ReadLine();
                crud.AddData(name, pass);
                Console.WriteLine("\n");
                Console.WriteLine("Please Select a Command and Type: List, Add, Edit, Delete, Logout");
                Command();
            }
            else if(cmd == "Edit")
            {
                Console.WriteLine("Please type a ID to Edit: ");
                var id = Console.ReadLine();
                Console.WriteLine("Please Type a User Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Please Type a Password: ");
                var pass = Console.ReadLine();
                crud.EditData(id, name, pass);
                Console.WriteLine("\n");
                Console.WriteLine("Please Select a Command and Type: List, Add, Edit, Delete, Logout");
                Command();
            }
            else if(cmd == "Delete")
            {
                Console.WriteLine("Please tyoe a ID to Delete: ");
                var id = Console.ReadLine();
                crud.DeleteData(id);
                Console.WriteLine("\n");
                Console.WriteLine("Please Select a Command and Type: List, Add, Edit, Delete, Logout");
                Command();
            }
            else if(cmd == "List")
            {
                Console.WriteLine("List of User Entries: \n");
                crud.getData();
                Console.WriteLine("\n");
                Console.WriteLine("Please Select a Command and Type: List, Add, Edit, Delete, Logout");
                Command();
            }
            Console.Read();


        }
    }
}
