using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace ControleAmbientes.Class
{
    class CRUD
    {
        string path = "Server=localhost;Database=controleambientesdb;Uid=root;Pwd=Niaih2so44#";

        private string _server, _database, _user, _password;

        public string Server { 
            get => _server; 
            set => _server = value; 
        }

        public string Database { 
            get => _database; 
            set => _database = value; 
        }

        public string User { 
            get => _user; 
            set => _user = value; 
        }

        public string Password { 
            get => _password; 
            set => _password = value; 
        }

        /// <summary>
        /// Salva Dados da Tela de Configuração
        /// Esse método cria sempre uma nova inserção deletando
        /// a inserção anterior de forma que mantenha sempre um
        /// unico registro, registando o momento que o mesmo foi
        /// recriado. Utilizeu array como assinatura do método para
        /// evitar sobrecarregamento do mesmo, assim posso compactar
        /// os dados em array e 
        /// </summary>

        public void SaveConfig(int n_IdUnicoConfig, DateTime d_DataConfig, string c_IpArduinoConfig, int[] comboType, int[] comboCol, int[] comboRow, int[] watts) {

        //Query para inserção de dados de configuração 
        string QuerySql = "INSERT INTO controleambientesdb.config(n_IdUnicoConfig, d_DataConfig, c_IpArduinoConfig, " +
                "n_ComboTypeA0Config, n_ComboTypeA1Config, n_ComboTypeA2Config, n_ComboTypeA3Config, n_ComboTypeA4Config," +
                "n_ComboTypeA5Config, n_ComboTypeA6Config, n_ComboTypeA7Config, n_ComboTypeA8Config, n_ComboTypeA9Config," +
                "n_ComboTypeA10Config, n_ComboTypeA11Config, n_ComboTypeA12Config, n_ComboTypeA13Config, n_ComboTypeA14Config," +
                "n_ComboTypeA15Config, n_ComboType2Config, n_ComboType3Config, n_ComboType4Config, n_ComboType5Config, n_ComboType6Config, n_ComboType7Config," +
                "n_ComboType8Config, n_ComboType9Config, n_ComboType22Config, n_ComboType23Config, n_ComboType24Config, n_ComboType25Config, n_ComboType26Config, " +
                "n_ComboType27Config, n_ComboType28Config, n_ComboType29Config, n_ComboType30Config, n_ComboType31Config, n_ComboType32Config, n_ComboType33Config," +
                "n_ComboType34Config, n_ComboType35Config, n_ComboType36Config, n_ComboType37Config, n_ComboType38Config, n_ComboType39Config, n_ComboType40Config," +
                "n_ComboType41Config, n_ComboType42Config, n_ComboType43Config, n_ComboType44Config, n_ComboType45Config, n_ComboType46Config, n_ComboType47Config," +
                "n_ComboType48Config, n_ComboType49Config, n_ComboType50Config, n_ComboType51Config, n_comboColA0Config, n_comboColA1Config, n_comboColA2Config," +
                "n_comboColA3Config, n_comboColA4Config, n_comboColA5Config, n_comboColA6Config, n_comboColA7Config, n_comboColA8Config, n_comboColA9Config," +
                "n_comboColA10Config, n_comboColA11Config, n_comboColA12Config, n_comboColA13Config, n_comboColA14Config, n_comboColA15Config, n_comboCol2Config," +
                "n_comboCol3Config, n_comboCol4Config, n_comboCol5Config, n_comboCol6Config, n_comboCol7Config, n_comboCol8Config, n_comboCol9Config, n_comboCol22Config," +
                "n_comboCol23Config, n_comboCol24Config, n_comboCol25Config, n_comboCol26Config, n_comboCol27Config, n_comboCol28Config, n_comboCol29Config, n_comboCol30Config," +
                "n_comboCol31Config, n_comboCol32Config, n_comboCol33Config, n_comboCol34Config, n_comboCol35Config, n_comboCol36Config, n_comboCol37Config, n_comboCol38Config," +
                "n_comboCol39Config, n_comboCol40Config, n_comboCol41Config, n_comboCol42Config, n_comboCol43Config, n_comboCol44Config, n_comboCol45Config, n_comboCol46Config," +
                "n_comboCol47Config, n_comboCol48Config, n_comboCol49Config, n_comboCol50Config, n_comboCol51Config, n_comboRowA0Config, n_comboRowA1Config, n_comboRowA2Config," +
                "n_comboRowA3Config, n_comboRowA4Config, n_comboRowA5Config, n_comboRowA6Config, n_comboRowA7Config, n_comboRowA8Config, n_comboRowA9Config, n_comboRowA10Config," +
                "n_comboRowA11Config, n_comboRowA12Config, n_comboRowA13Config, n_comboRowA14Config, n_comboRowA15Config, n_comboRow2Config, n_comboRow3Config, n_comboRow4Config," +
                "n_comboRow5Config, n_comboRow6Config, n_comboRow7Config, n_comboRow8Config, n_comboRow9Config, n_comboRow22Config, n_comboRow23Config, n_comboRow24Config, n_comboRow25Config," +
                "n_comboRow26Config, n_comboRow27Config, n_comboRow28Config, n_comboRow29Config, n_comboRow30Config, n_comboRow31Config, n_comboRow32Config, n_comboRow33Config, n_comboRow34Config," +
                "n_comboRow35Config, n_comboRow36Config, n_comboRow37Config, n_comboRow38Config, n_comboRow39Config, n_comboRow40Config, n_comboRow41Config, n_comboRow42Config, n_comboRow43Config," +
                "n_comboRow44Config, n_comboRow45Config, n_comboRow46Config, n_comboRow47Config, n_comboRow48Config, n_comboRow49Config, n_comboRow50Config, n_comboRow51Config, n_txtWats_A0Config," +
                "n_txtWats_A1Config, n_txtWats_A2Config, n_txtWats_A3Config, n_txtWats_A4Config, n_txtWats_A5Config, n_txtWats_A6Config, n_txtWats_A7Config, n_txtWats_A8Config, n_txtWats_A9Config," +
                "n_txtWats_A10Config, n_txtWats_A11Config, n_txtWats_A12Config, n_txtWats_A13Config, n_txtWats_A14Config, n_txtWats_A15Config, n_txtWats_2Config, n_txtWats_3Config, n_txtWats_4Config," +
                "n_txtWats_5Config, n_txtWats_6Config, n_txtWats_7Config, n_txtWats_8Config, n_txtWats_9Config, n_txtWats_22Config, n_txtWats_23Config, n_txtWats_24Config, n_txtWats_25Config, n_txtWats_26Config," +
                "n_txtWats_27Config, n_txtWats_28Config, n_txtWats_29Config, n_txtWats_30Config, n_txtWats_31Config, n_txtWats_32Config, n_txtWats_33Config, n_txtWats_34Config, n_txtWats_35Config, n_txtWats_36Config," +
                "n_txtWats_37Config, n_txtWats_38Config, n_txtWats_39Config, n_txtWats_40Config, n_txtWats_41Config, n_txtWats_42Config, n_txtWats_43Config, n_txtWats_44Config, n_txtWats_45Config, n_txtWats_46Config," +
                "n_txtWats_47Config, n_txtWats_48Config, n_txtWats_49Config, n_txtWats_50Config, n_txtWats_51Config) Values (" + n_IdUnicoConfig + ",'" + d_DataConfig.ToString("yyyy/MM/dd HH:mm:ss") + "','" + c_IpArduinoConfig + 
                "'," + comboType[0] + "," + comboType[1] + "," + comboType[2] + "," + comboType[3] + "," + comboType[4] + "," + comboType[5] + "," + comboType[6] + "," + comboType[7] + "," + comboType[8] + "," + comboType[9] + 
                "," + comboType[10] + "," + comboType[11] + "," + comboType[12] + "," + comboType[13] + "," + comboType[14] + "," + comboType[15] + "," + comboType[16] + "," + comboType[17] + "," + comboType[18] + "," + comboType[19] + 
                "," + comboType[20] + "," + comboType[21] + "," + comboType[22] + "," + comboType[23] + "," + comboType[24] + "," + comboType[25] + "," + comboType[26] + "," + comboType[27] + "," + comboType[28] + "," + comboType[29] + 
                "," + comboType[30] + "," + comboType[31] + "," + comboType[32] + "," + comboType[33] + "," + comboType[34] + "," + comboType[35] + "," + comboType[36] + "," + comboType[37] + "," + comboType[38] + "," + comboType[39] + 
                "," + comboType[40] + "," + comboType[41] + "," + comboType[42] + "," + comboType[43] + "," + comboType[44] + "," + comboType[45] + "," + comboType[46] + "," + comboType[47] + "," + comboType[48] + "," + comboType[49] + 
                "," + comboType[50] + "," + comboType[51] + "," + comboType[52] + "," + comboType[53] + "," + comboCol[0] + "," + comboCol[1] + "," + comboCol[2] + "," + comboCol[3] + "," + comboCol[4] + "," + comboCol[5] + "," + comboCol[6] + 
                "," + comboCol[7] + "," + comboCol[8] + "," + comboCol[9] + "," + comboCol[10] + "," + comboCol[11] + "," + comboCol[12] + "," + comboCol[13] + "," + comboCol[14] + "," + comboCol[15] + "," + comboCol[16] + "," + comboCol[17] + 
                "," + comboCol[18] + "," + comboCol[19] + "," + comboCol[20] + "," + comboCol[21] + "," + comboCol[22] + "," + comboCol[23] + "," + comboCol[24] + "," + comboCol[25] + "," + comboCol[26] + "," + comboCol[27] + "," + comboCol[28] + 
                "," + comboCol[29] + "," + comboCol[30] + "," + comboCol[31] + "," + comboCol[32] + "," + comboCol[33] + "," + comboCol[34] + "," + comboCol[35] + "," + comboCol[36] + "," + comboCol[37] + "," + comboCol[38] + "," + comboCol[39] + 
                "," + comboCol[40] + "," + comboCol[41] + "," + comboCol[42] + "," + comboCol[43] + "," + comboCol[44] + "," + comboCol[45] + "," + comboCol[46] + "," + comboCol[47] + "," + comboCol[48] + "," + comboCol[49] + "," + comboCol[50] + 
                "," + comboCol[51] + "," + comboCol[52] + "," + comboCol[53] + "," + comboRow[0] + "," + comboRow[1] + "," + comboRow[2] + "," + comboRow[3] + "," + comboRow[4] + "," + comboRow[5] + "," + comboRow[6] + "," + comboRow[7] + 
                "," + comboRow[8] + "," + comboRow[9] + "," + comboRow[10] + "," + comboRow[11] + "," + comboRow[12] + "," + comboRow[13] + "," + comboRow[14] + "," + comboRow[15] + "," + comboRow[16] + "," + comboRow[17] + "," + comboRow[18] + 
                "," + comboRow[19] + "," + comboRow[20] + "," + comboRow[21] + "," + comboRow[22] + "," + comboRow[23] + "," + comboRow[24] + "," + comboRow[25] + "," + comboRow[26] + "," + comboRow[27] + "," + comboRow[28] + "," + comboRow[29] + 
                "," + comboRow[30] + "," + comboRow[31] + "," + comboRow[32] + "," + comboRow[33] + "," + comboRow[34] + "," + comboRow[35] + "," + comboRow[36] + "," + comboRow[37] + "," + comboRow[38] + "," + comboRow[39] + "," + comboRow[40] + 
                "," + comboRow[41] + "," + comboRow[42] + "," + comboRow[43] + "," + comboRow[44] + "," + comboRow[45] + "," + comboRow[46] + "," + comboRow[47] + "," + comboRow[48] + "," + comboRow[49] + "," + comboRow[50] + "," + comboRow[51] + 
                "," + comboRow[52] + "," + comboRow[53] + "," + watts[0] + "," + watts[1] + "," + watts[2] + "," + watts[3] + "," + watts[4] + "," + watts[5] + "," + watts[6] + "," + watts[7] + "," + watts[8] + "," + watts[9] + "," + watts[10] + 
                "," + watts[11] + "," + watts[12] + "," + watts[13] + "," + watts[14] + "," + watts[15] + "," + watts[16] + "," + watts[17] + "," + watts[18] + "," + watts[19] + "," + watts[20] + "," + watts[21] + "," + watts[22] + "," + watts[23] + 
                "," + watts[24] + "," + watts[25] + "," + watts[26] + "," + watts[27] + "," + watts[28] + "," + watts[29] + "," + watts[30] + "," + watts[31] + "," + watts[32] + "," + watts[33] + "," + watts[34] + "," + watts[35] + "," + watts[36] + 
                "," + watts[37] + "," + watts[38] + "," + watts[39] + "," + watts[40] + "," + watts[41] + "," + watts[42] + "," + watts[43] + "," + watts[44] + "," + watts[45] + "," + watts[46] + "," + watts[47] + "," + watts[48] + "," + watts[49] + 
                "," + watts[50] + "," + watts[51] + "," + watts[52] + "," + watts[53] + ")";

            //Query para deletar registro atual mantendo sempre um unico registro na base
            string QueryDrop = "DELETE FROM controleambientesdb.config WHERE n_IdUnicoConfig = 1";

            MySqlConnection connect = new MySqlConnection(path);
            MySqlCommand comand = new MySqlCommand(QuerySql, connect);
            MySqlCommand comandDrop = new MySqlCommand(QueryDrop, connect);

            try
            {
                connect.Open();
                comandDrop.ExecuteNonQuery();
                comand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro na gravação do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }

        }

        public void UpdateConfig(ref DateTime d_DataConfig, ref string c_IpArduinoConfig, ref int[] comboType, ref int[] comboCol, ref int[] comboRow, ref int[] watts)
        {
            string QuerySql = "SELECT * FROM controleambientesdb.config WHERE n_IdUnicoConfig = 1";

        }
    }
}
