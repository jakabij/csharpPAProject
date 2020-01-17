using System;
using System.Collections.Generic;
using System.Text;

namespace PAProject
{
    public class UI
    {
        public string[] GameDatasFromUser()
        {
            string[] dataNames = { "developer", "name","rating","type" };
            string[] userInputs = new string[dataNames.Length];

            for(int count=0;count<dataNames.Length;count++)
            { 
                Console.WriteLine("Add the {0} of the game!",dataNames[count]);
                userInputs[count]=Console.ReadLine();
            }

            return userInputs;
        }

        public string EffectToPlayerPrinting(string effect)
        {
            return Console.WriteLine("After this game: "+effect);
        }
    }
}
