using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLib
{
    public abstract class VideoGame
    {
        public string Developer { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Type { get; set; }

        public abstract void EffectToPlayer(Player player);

        public VideoGame()
        {

        }
        public VideoGame(string developer,string name,double rating,string type)
        {
            Developer = developer;
            Name = name;
            Rating = rating;
            Type = type;
        }
    }
}
