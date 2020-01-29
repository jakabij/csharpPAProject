using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLib
{
    public class ActionGame : VideoGame
    {
        public ActionGame()
        {

        }
        public ActionGame(string developer, string name, double rating, string type) 
            :base(developer, name, rating, type)
        {
        }

        public override void EffectToPlayer(Player player,Object game)
        {
            player.playedActionGames.Add((ActionGame)game);
        }
    }
}
