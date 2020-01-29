using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLib
{
    public class AdventureGame : VideoGame
    {
        public AdventureGame()
        {

        }
        public AdventureGame(string developer, string name, double rating, string type) 
            :base(developer, name, rating, type)
        {
        }

        public override void EffectToPlayer(Player player)
        {
            player.playedAdventureGames.Add(base.Name);
        }
    }
}
