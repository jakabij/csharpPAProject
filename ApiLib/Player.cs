using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ApiLib
{
    public class Player
    {
        [XmlAttribute("Player_Name")]
        public string Name { get; set; }

        [XmlArrayItem("Horror_Game")]
        public List<HorrorGame> playedHorrorGames = new List<HorrorGame>();

        [XmlArrayItem("Survival_Game")]
        public List<SurvivalGame> playedSurvivalGames = new List<SurvivalGame>();

        [XmlArrayItem("Adventure_Game")]
        public List<AdventureGame> playedAdventureGames = new List<AdventureGame>();

        [XmlArrayItem("Action_Game")]
        public List<ActionGame> playedActionGames = new List<ActionGame>();

        public int playedGames = 0;

        public Player()
        {

        }
        public Player(string name)
        {
            Name = name;
        }
    }
}
