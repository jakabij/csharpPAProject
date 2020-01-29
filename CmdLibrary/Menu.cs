using System;
using System.Collections.Generic;
using System.Text;
using ApiLib;

namespace CmdLibrary
{
    public class Menu
    {
        public void TypeChoosing(string type, Player player)  
        {
            UI ui = new UI();

            int developer = 0;
            int name = 1;
            int rating = 2;

            if (type.Equals("Horror"))
            {
                string[] datas = ui.GameDatasFromUser();
                HorrorGame game = new HorrorGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                game.EffectToPlayer(player);
            }

            else if (type.Equals("Survival"))
            {
                string[] datas = ui.GameDatasFromUser();
                SurvivalGame game = new SurvivalGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                game.EffectToPlayer(player);
            }

            else if (type.Equals("Adventure"))
            {
                string[] datas = ui.GameDatasFromUser();
                AdventureGame game = new AdventureGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                game.EffectToPlayer(player);
            }

            else if (type.Equals("Action"))
            {
                string[] datas = ui.GameDatasFromUser();
                ActionGame game = new ActionGame(datas[developer], datas[name], Double.Parse(datas[rating]), type);
                game.EffectToPlayer(player);
            }

            else
            {
                ui.ErrorMessage("Wrong type of attribute!");
            }

        }
    }
}
