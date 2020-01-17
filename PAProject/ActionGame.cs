using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    class ActionGame : VideoGame
    {
        public ActionGame(string developer, string name, double rating, string type) 
            :base(developer, name, rating, type)
        {
        }

        public override void EffectToPlayer(Player player)
        {
            player.PlayedActionGames.Add(base.Name);
        }
    }
}
