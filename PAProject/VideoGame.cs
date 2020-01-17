using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    abstract class VideoGame
    {
        string Developer { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        string Type { get; set; }

        public abstract void EffectToPlayer();
    }
}
