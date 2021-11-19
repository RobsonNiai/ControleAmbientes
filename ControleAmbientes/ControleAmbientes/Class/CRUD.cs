using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleAmbientes.Class
{
    class CRUD
    {
        string connString = "Server=localhost;Database=controleambientesdb;Uid=root;Pwd=Niaih2so44#";
        MySqlConnection connection = new MySqlConnection();

        public string StringConection { get; private set; }

    }
}
