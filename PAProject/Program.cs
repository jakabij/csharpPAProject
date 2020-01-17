using System;

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

                }
                else if (choice == "find")
                {

                }
                else if (choice == "create")
                {
                    string type = ui.GameTypeFromUser();
                    int developer = 0;
                    int name = 1;
                    int rating = 2;


                    if (type.Equals("Horror"))
                    {
                        string playerName = ui.PlayerNameFromUser();
                        Player player = new Player(playerName);

                        string[] datas=ui.GameDatasFromUser();

                        HorrorGame game = new HorrorGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                        game.EffectToPlayer(player);
                    }

                    else if(type.Equals("Survival"))
                    {
                        string playerName = ui.PlayerNameFromUser();
                        Player player = new Player(playerName);

                        string[] datas = ui.GameDatasFromUser();
                        SurvivalGame game = new SurvivalGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                        game.EffectToPlayer(player);
                    }

                    else if(type.Equals("Adventure"))
                    {
                        string playerName = ui.PlayerNameFromUser();
                        Player player = new Player(playerName);

                        string[] datas = ui.GameDatasFromUser();
                        AdventureGame game = new AdventureGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                        game.EffectToPlayer(player);
                    }

                    else if(type.Equals("Action"))
                    {
                        string playerName = ui.PlayerNameFromUser();
                        Player player = new Player(playerName);

                        string[] datas = ui.GameDatasFromUser();
                        ActionGame game = new ActionGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                        game.EffectToPlayer(player);
                    }

                    else
                    {
                        //ERRORT IDE
                    }
                    
                    
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
