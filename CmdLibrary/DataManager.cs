using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using ApiLib;

namespace CmdLibrary
{
    public class DataManager
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Player>));

        public void SavingPlayers(Player player,bool needTODelete)
        {   
            if(File.Exists("players.xml"))
            {
                List<Player> loadedPlayersList=LoadPlayers();
                if(needTODelete)
                {
                    for(int count=0;count<loadedPlayersList.Count;count++)
                    {
                        if(loadedPlayersList[count].Name.Equals(player.Name))
                        {
                            loadedPlayersList.RemoveAt(count);
                            break;
                        }
                    }
                }
                loadedPlayersList.Add(player);
                using(StreamWriter sw=new StreamWriter("players.xml"))
                {
                    xml.Serialize(sw, loadedPlayersList);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("players.xml"))
                {
                    List<Player> playersList = new List<Player>();
                    playersList.Add(player);
                    xml.Serialize(sw, playersList);
                }
            }
        }



        public List<Player> LoadPlayers()
        {
            List<Player> list = new List<Player>();
            using (FileStream st = File.OpenRead("players.xml"))
            {
                list = (List<Player>)xml.Deserialize(st);
            }
            return list;
        }


    }
}
