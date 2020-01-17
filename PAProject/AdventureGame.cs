using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    class AdventureGame : VideoGame
    {
        string Effect { get; set; }
        public AdventureGame(string developer, string name, double rating, string type, string effect) : base(developer, name, rating, type)
        {
            Effect = effect;
        }

        public override string EffectToPlayer()
        {
            UI ui = new UI();
            return ui.EffectToPlayerPrinting(Effect);
        }
    }
}
