using System;
using System.Collections.Generic;
using System.IO;
using ApiLib;
using CmdLibrary;

namespace PAProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();

            ui.PrintMenu();
            string choice = ui.InputChoice(args);

            if (choice!=null)
            {
                Console.WriteLine("\tlist:  List all the stored data\n\tfind:   Find a particular data\n\t" +
                "create:  Create new data\n\tremove:  Remove data from the database\n\texit:  To exit from the program");

                if (choice == "list")
                {
                    ui.ListAllSavedPlayers();
                }
                else if (choice == "find")
                {

                }
                else if (choice == "create")
                {
                    string type = ui.GameTypeFromUser();
                    string playerName = ui.PlayerNameFromUser();
                    ui.Creating(playerName, type);
                    
                }
                else if(choice == "remove")
                {

                }
                else if(choice == "exit")
                {

                }
                else
                {
                    Console.WriteLine("Not acceptable command! You have to choose from above!");
                }
            }
        }
    }
}
