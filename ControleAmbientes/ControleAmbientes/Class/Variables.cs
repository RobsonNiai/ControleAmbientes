using System;
using System.Collections.Generic;

namespace ControleAmbientes.Class
{
    static public class Variables
    {
        static public bool userLoggin;
        static public bool admin;
        static public bool[] btSelect = new bool[32];
        static public bool[] btSelectAction = new bool[32];
        static public bool[] btSelectTransition = new bool[32];
        static public int[] poten = new int[32];
        static public ushort[] modBusAddres = new ushort[32];

        static public int[] typeIO_DB = new int[54];
        static public int[] actionCol_DB = new int[54];
        static public int[] watts_DB = new int[54];
        static public int[] actionRow_DB = new int[54];
        static public string[] enableButtonSelect = new string[54];
        static public string c_IpArduinoConfig = "192.168.1.1";
        static public DateTime d_DateTime = new DateTime();


        public static List<string> enableButton = new List<string>(54);

        public static List<Class.Watts> watts = new List<Class.Watts>(54);


    }
}
