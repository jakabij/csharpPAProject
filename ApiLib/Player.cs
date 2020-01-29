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
        [XmlArrayItem("Game_Name")]
        public List<string> playedHorrorGames = new List<string>();
        [XmlArrayItem("Game_Name")]
        public List<string> playedSurvivalGames = new List<string>();
        [XmlArrayItem("Game_Name")]
        public List<string> playedAdventureGames = new List<string>();
        [XmlArrayItem("Game_Name")]
        public List<string> playedActionGames = new List<string>();
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
