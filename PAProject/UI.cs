using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    public class UI
    {
        public void PrintMenu()
        {
            Console.WriteLine("/--------------------------------------------------------\\");
            Console.WriteLine("\tlist:  List all the stored data\n\tfind:   Find a particular data\n\t" +
                "create:  Create new data\n\tremove:  Remove data from the database\n\texit:  To exit from the program");
            Console.WriteLine("\\--------------------------------------------------------/");
        }


        public string InputChoice(string[] arguments)
        {
            if(arguments.Length>1)
            {
                Console.WriteLine("Too many arguments! You should add only just one!");
            }
            else if(arguments.Length==0)
            {
                Console.WriteLine("You have to add an argument!");
            }
            else
            {
                Console.WriteLine("You chose {0}", arguments[0]);
                return arguments[0];
            }
            return null;
        }

        public string GameTypeFromUser()
        {
            Console.WriteLine("What type is this game? (Horror, Survival, Adventure or Action)");
            string type=Console.ReadLine();
            return type;
        }

        public string PlayerNameFromUser()
        {
            Console.WriteLine("What is the player's name?");
            return Console.ReadLine();
        }


        public string[] GameDatasFromUser()
        {
            string[] dataNames = { "developer", "name","rating"};
            string[] userInputs = new string[dataNames.Length];

            for(int count=0;count<dataNames.Length;count++)
            { 
                Console.WriteLine("Add the {0} of the game!",dataNames[count]);
                userInputs[count]=Console.ReadLine();
            }

            return userInputs;
        }
    }
}
