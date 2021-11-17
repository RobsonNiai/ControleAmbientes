using System.Collections.Generic;

namespace ControleAmbientes.Class
{
    static public class Variables
    {
        static public bool userLoggin;
        static public bool[] btSelect = new bool[32];
        static public bool[] btSelectAction = new bool[32];

        static public int[] typeIO_DB = new int[54];
        static public int[] actionCol_DB = new int[54];
        static public int[] actionRow_DB = new int[54];
        static public int[] watts_DB = new int[54];
        static public string[] enableButtonSelect = new string[54];

        public static List<string> enableButton = new List<string>(54);

        
    }
}
