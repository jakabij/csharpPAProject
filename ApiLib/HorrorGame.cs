using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLib
{
    public class HorrorGame : VideoGame
    {
        public HorrorGame()
        {

        }
        public HorrorGame(string developer,string name,double rating,string type)
            :base(developer,name,rating,type)
        {
        }

        public override void EffectToPlayer(Player player,Object game)
        {
            player.playedHorrorGames.Add((HorrorGame)game);
        }
    }
}
