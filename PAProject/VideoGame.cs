using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    abstract class VideoGame
    {
        string Developer { get; set; }
        string Name { get; set; }
        double Rating { get; set; }
        string Type { get; set; }

        public abstract void EffectToPlayer();

        VideoGame(string developer,string name,double rating,string type)
        {
            Developer = developer;
            Name = name;
            Rating = rating;
            Type = type;
        }
    }
}
