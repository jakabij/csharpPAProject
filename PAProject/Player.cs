using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    public class Player
    {
        string Name { get; set; }
        public List<string> playedHorrorGames = new List<string>();
        public List<string> playedSurvivalGames = new List<string>();
        public List<string> playedAdventureGames = new List<string>();
        public List<string> PlayedActionGames = new List<string>();
        public int PlayedGames = 0;

        public Player(string name)
        {
            Name = name;
        }
    }
}
