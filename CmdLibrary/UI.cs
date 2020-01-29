using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApiLib;

namespace CmdLibrary
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

        public void ErrorMessage(string message)
        {
            Console.WriteLine("ERROR occuered: " + message);
        }



        public void Creating(string playerName,string type)
        {
            DataManager manager = new DataManager();
            Menu menu = new Menu();

            Player player = new Player(playerName);

            if (File.Exists("players.xml"))
            {
                List<Player> players = manager.LoadPlayers();
                bool foundIt = false;
                for (int count = 0; count < players.Count; count++)
                {
                    if (players[count].Name.Equals(playerName))
                    {
                        menu.TypeChoosing(type, players[count]);
                        manager.SavingPlayers(players[count], true);
                        foundIt = true;
                    }
                }
                if (!foundIt)
                {
                    menu.TypeChoosing(type, player);
                    manager.SavingPlayers(player, false);
                }
            }
            else
            {
                menu.TypeChoosing(type, player);
                manager.SavingPlayers(player, false);
            }
        }



        public void ListAllSavedPlayers()
        {
            DataManager manager = new DataManager();
            List<Player> listOfAllPlayer=manager.LoadPlayers();
            for(int count=0;count<listOfAllPlayer.Count;count++)
            {
                Console.WriteLine("---------------------------------------------------\n"+listOfAllPlayer[count].Name);
                Console.WriteLine("\t-HORROR GAMES-");
                for(int countOfGames=0; countOfGames < listOfAllPlayer[count].playedHorrorGames.Count; countOfGames++)
                {
                    Console.WriteLine("\t\t"+listOfAllPlayer[count].playedHorrorGames[countOfGames].Name+
                        " (Rating: "+ listOfAllPlayer[count].playedHorrorGames[countOfGames].Rating+")");
                }

                Console.WriteLine("\n\t-ACTION GAMES-");
                for(int countOfGames = 0; countOfGames < listOfAllPlayer[count].playedActionGames.Count; countOfGames++)
                {
                    Console.WriteLine("\t\t" + listOfAllPlayer[count].playedActionGames[countOfGames].Name +
                        " (Rating: " + listOfAllPlayer[count].playedActionGames[countOfGames].Rating + ")");
                }

                Console.WriteLine("\n\t-ADVENTURE GAMES-");
                for (int countOfGames = 0; countOfGames < listOfAllPlayer[count].playedAdventureGames.Count; countOfGames++)
                {
                    Console.WriteLine("\t\t" + listOfAllPlayer[count].playedAdventureGames[countOfGames].Name +
                        " (Rating: " + listOfAllPlayer[count].playedAdventureGames[countOfGames].Rating + ")");
                }

                Console.WriteLine("\n\t-SURVIVAL GAMES-");
                for (int countOfGames = 0; countOfGames < listOfAllPlayer[count].playedSurvivalGames.Count; countOfGames++)
                {
                    Console.WriteLine("\t\t" + listOfAllPlayer[count].playedSurvivalGames[countOfGames].Name +
                        " (Rating: " + listOfAllPlayer[count].playedSurvivalGames[countOfGames].Rating + ")");
                }
            }
        }
    }
}
