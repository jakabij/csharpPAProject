using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    class SurvivalGame : VideoGame
    {
        public SurvivalGame(string developer, string name, double rating, string type) 
            :base(developer, name, rating, type)
        {
        }

        public override void EffectToPlayer(Player player)
        {
            player.playedSurvivalGames.Add(base.Name);
        }
    }
}
