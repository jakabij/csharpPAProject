using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    public class HorrorGame : VideoGame
    {
        public HorrorGame(string developer,string name,double rating,string type)
            :base(developer,name,rating,type)
        {
        }

        public override void EffectToPlayer(Player player)
        {
            player.playedHorrorGames.Add(Name);
        }
    }
}
