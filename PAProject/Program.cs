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
                    int effect = 3;


                    if (type.Equals("Horror"))
                    {
                        Player player = new Player("Piftaaa");

                        string[] datas=ui.GameDatasFromUser();

                        HorrorGame game = new HorrorGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                        game.EffectToPlayer(player);

                        for(int i = 0; i<player.playedHorrorGames.Count;i++)
                            Console.WriteLine(player.playedHorrorGames[i]);
                    }
                    else if(type.Equals("Survival"))
                    {
                        string[] datas = ui.GameDatasFromUser();
                    }
                    else if(type.Equals("Adventure"))
                    {
                        string[] datas = ui.GameDatasFromUser();
                    }
                    else if(type.Equals("Action"))
                    {
                        string[] datas = ui.GameDatasFromUser();
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
