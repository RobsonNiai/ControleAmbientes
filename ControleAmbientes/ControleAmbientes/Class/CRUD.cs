using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace ControleAmbientes.Class
{
    class CRUD
    {
        //String padrão do MySql
        string path = "Server=localhost;Database=controleambientesdb;Uid=root;Pwd=Niaih2so44#";

        string dataFormat = "yyyy/MM/dd HH:mm:ss";

        /// <summary>
        /// Salva Dados da Tela de Configuração
        /// Esse método cria sempre uma nova inserção deletando
        /// a inserção anterior de forma que mantenha sempre um
        /// unico registro, registando o momento que o mesmo foi
        /// recriado. Utilizeu array como assinatura do método para
        /// evitar sobrecarregamento do mesmo, assim posso compactar
        /// os dados em array e 
        /// </summary>
        public void SaveConfig(int n_IdUnicoConfig, DateTime d_DataConfig, string c_IpArduinoConfig, int[] comboType, int[] comboCol, int[] comboRow, int[] watts)
        {

            //Query para inserção de dados de configuração 
            string QuerySql = "INSERT INTO controleambientesdb.config Values (" + n_IdUnicoConfig + ",'" + d_DataConfig.ToString(dataFormat) + "','" + c_IpArduinoConfig +
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
            catch (Exception e)
            {
                MessageBox.Show("Erro na gravação do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }

        }

        /// <summary>
        /// Método realiza leitura das variáveis salvas no banco de dados 
        /// e atualiza a tela de configurações
        /// </summary>
        /// <param name="d_DataConfig"></param>
        /// <param name="c_IpArduinoConfig"></param>
        /// <param name="comboType"></param>
        /// <param name="comboCol"></param>
        /// <param name="comboRow"></param>
        /// <param name="watts"></param>
        public void UpdateConfig(ref DateTime d_DataConfig, ref string c_IpArduinoConfig, ref int[] comboType, ref int[] comboCol, ref int[] comboRow, ref int[] watts)
        {
            string QuerySql = "SELECT * FROM controleambientesdb.config WHERE n_IdUnicoConfig = 1";

            MySqlConnection connect = new MySqlConnection(path);

            try
            {
                connect.Open();

                MySqlCommand comand = new MySqlCommand(QuerySql, connect);
                MySqlDataReader comandReader = comand.ExecuteReader();

                comandReader.Read();

                d_DataConfig = DateTime.Parse(comandReader["d_DataConfig"].ToString());

                c_IpArduinoConfig = comandReader["c_IpArduinoConfig"].ToString();

                comboType[0] = int.Parse(comandReader["n_ComboTypeA0Config"].ToString()); comboType[1] = int.Parse(comandReader["n_ComboTypeA1Config"].ToString()); comboType[2] = int.Parse(comandReader["n_ComboTypeA2Config"].ToString()); comboType[3] = int.Parse(comandReader["n_ComboTypeA3Config"].ToString());
                comboType[4] = int.Parse(comandReader["n_ComboTypeA4Config"].ToString()); comboType[5] = int.Parse(comandReader["n_ComboTypeA5Config"].ToString()); comboType[6] = int.Parse(comandReader["n_ComboTypeA6Config"].ToString()); comboType[7] = int.Parse(comandReader["n_ComboTypeA7Config"].ToString());
                comboType[8] = int.Parse(comandReader["n_ComboTypeA8Config"].ToString()); comboType[9] = int.Parse(comandReader["n_ComboTypeA9Config"].ToString()); comboType[10] = int.Parse(comandReader["n_ComboTypeA10Config"].ToString()); comboType[11] = int.Parse(comandReader["n_ComboTypeA11Config"].ToString());
                comboType[12] = int.Parse(comandReader["n_ComboTypeA12Config"].ToString()); comboType[13] = int.Parse(comandReader["n_ComboTypeA13Config"].ToString()); comboType[14] = int.Parse(comandReader["n_ComboTypeA14Config"].ToString()); comboType[15] = int.Parse(comandReader["n_ComboTypeA15Config"].ToString());
                comboType[16] = int.Parse(comandReader["n_ComboType2Config"].ToString()); comboType[17] = int.Parse(comandReader["n_ComboType3Config"].ToString()); comboType[18] = int.Parse(comandReader["n_ComboType4Config"].ToString()); comboType[19] = int.Parse(comandReader["n_ComboType5Config"].ToString());
                comboType[20] = int.Parse(comandReader["n_ComboType6Config"].ToString()); comboType[21] = int.Parse(comandReader["n_ComboType7Config"].ToString()); comboType[22] = int.Parse(comandReader["n_ComboType8Config"].ToString()); comboType[23] = int.Parse(comandReader["n_ComboType9Config"].ToString());
                comboType[24] = int.Parse(comandReader["n_ComboType22Config"].ToString()); comboType[25] = int.Parse(comandReader["n_ComboType23Config"].ToString()); comboType[26] = int.Parse(comandReader["n_ComboType24Config"].ToString()); comboType[27] = int.Parse(comandReader["n_ComboType25Config"].ToString());
                comboType[28] = int.Parse(comandReader["n_ComboType26Config"].ToString()); comboType[29] = int.Parse(comandReader["n_ComboType27Config"].ToString()); comboType[30] = int.Parse(comandReader["n_ComboType28Config"].ToString()); comboType[31] = int.Parse(comandReader["n_ComboType29Config"].ToString());
                comboType[32] = int.Parse(comandReader["n_ComboType30Config"].ToString()); comboType[33] = int.Parse(comandReader["n_ComboType31Config"].ToString()); comboType[34] = int.Parse(comandReader["n_ComboType32Config"].ToString()); comboType[35] = int.Parse(comandReader["n_ComboType33Config"].ToString());
                comboType[36] = int.Parse(comandReader["n_ComboType34Config"].ToString()); comboType[37] = int.Parse(comandReader["n_ComboType35Config"].ToString()); comboType[38] = int.Parse(comandReader["n_ComboType36Config"].ToString()); comboType[39] = int.Parse(comandReader["n_ComboType37Config"].ToString());
                comboType[40] = int.Parse(comandReader["n_ComboType38Config"].ToString()); comboType[41] = int.Parse(comandReader["n_ComboType39Config"].ToString()); comboType[42] = int.Parse(comandReader["n_ComboType40Config"].ToString()); comboType[43] = int.Parse(comandReader["n_ComboType41Config"].ToString());
                comboType[44] = int.Parse(comandReader["n_ComboType42Config"].ToString()); comboType[45] = int.Parse(comandReader["n_ComboType43Config"].ToString()); comboType[46] = int.Parse(comandReader["n_ComboType44Config"].ToString()); comboType[47] = int.Parse(comandReader["n_ComboType45Config"].ToString());
                comboType[48] = int.Parse(comandReader["n_ComboType46Config"].ToString()); comboType[49] = int.Parse(comandReader["n_ComboType47Config"].ToString()); comboType[50] = int.Parse(comandReader["n_ComboType48Config"].ToString()); comboType[51] = int.Parse(comandReader["n_ComboType49Config"].ToString());
                comboType[52] = int.Parse(comandReader["n_ComboType50Config"].ToString()); comboType[53] = int.Parse(comandReader["n_ComboType51Config"].ToString());

                comboCol[0] = int.Parse(comandReader["n_comboColA0Config"].ToString()); comboCol[1] = int.Parse(comandReader["n_comboColA1Config"].ToString()); comboCol[2] = int.Parse(comandReader["n_comboColA2Config"].ToString()); comboCol[3] = int.Parse(comandReader["n_comboColA3Config"].ToString());
                comboCol[4] = int.Parse(comandReader["n_comboColA4Config"].ToString()); comboCol[5] = int.Parse(comandReader["n_comboColA5Config"].ToString()); comboCol[6] = int.Parse(comandReader["n_comboColA6Config"].ToString()); comboCol[7] = int.Parse(comandReader["n_comboColA7Config"].ToString());
                comboCol[8] = int.Parse(comandReader["n_comboColA8Config"].ToString()); comboCol[9] = int.Parse(comandReader["n_comboColA9Config"].ToString()); comboCol[10] = int.Parse(comandReader["n_comboColA10Config"].ToString()); comboCol[11] = int.Parse(comandReader["n_comboColA11Config"].ToString());
                comboCol[12] = int.Parse(comandReader["n_comboColA12Config"].ToString()); comboCol[13] = int.Parse(comandReader["n_comboColA13Config"].ToString()); comboCol[14] = int.Parse(comandReader["n_comboColA14Config"].ToString()); comboCol[15] = int.Parse(comandReader["n_comboColA15Config"].ToString());
                comboCol[16] = int.Parse(comandReader["n_comboCol2Config"].ToString()); comboCol[17] = int.Parse(comandReader["n_comboCol3Config"].ToString()); comboCol[18] = int.Parse(comandReader["n_comboCol4Config"].ToString()); comboCol[19] = int.Parse(comandReader["n_comboCol5Config"].ToString());
                comboCol[20] = int.Parse(comandReader["n_comboCol6Config"].ToString()); comboCol[21] = int.Parse(comandReader["n_comboCol7Config"].ToString()); comboCol[22] = int.Parse(comandReader["n_comboCol8Config"].ToString()); comboCol[23] = int.Parse(comandReader["n_comboCol9Config"].ToString());
                comboCol[24] = int.Parse(comandReader["n_comboCol22Config"].ToString()); comboCol[25] = int.Parse(comandReader["n_comboCol23Config"].ToString()); comboCol[26] = int.Parse(comandReader["n_comboCol24Config"].ToString()); comboCol[27] = int.Parse(comandReader["n_comboCol25Config"].ToString());
                comboCol[28] = int.Parse(comandReader["n_comboCol26Config"].ToString()); comboCol[29] = int.Parse(comandReader["n_comboCol27Config"].ToString()); comboCol[30] = int.Parse(comandReader["n_comboCol28Config"].ToString()); comboCol[31] = int.Parse(comandReader["n_comboCol29Config"].ToString());
                comboCol[32] = int.Parse(comandReader["n_comboCol30Config"].ToString()); comboCol[33] = int.Parse(comandReader["n_comboCol31Config"].ToString()); comboCol[34] = int.Parse(comandReader["n_comboCol32Config"].ToString()); comboCol[35] = int.Parse(comandReader["n_comboCol33Config"].ToString());
                comboCol[36] = int.Parse(comandReader["n_comboCol34Config"].ToString()); comboCol[37] = int.Parse(comandReader["n_comboCol35Config"].ToString()); comboCol[38] = int.Parse(comandReader["n_comboCol36Config"].ToString()); comboCol[39] = int.Parse(comandReader["n_comboCol37Config"].ToString());
                comboCol[40] = int.Parse(comandReader["n_comboCol38Config"].ToString()); comboCol[41] = int.Parse(comandReader["n_comboCol39Config"].ToString()); comboCol[42] = int.Parse(comandReader["n_comboCol40Config"].ToString()); comboCol[43] = int.Parse(comandReader["n_comboCol41Config"].ToString());
                comboCol[44] = int.Parse(comandReader["n_comboCol42Config"].ToString()); comboCol[45] = int.Parse(comandReader["n_comboCol43Config"].ToString()); comboCol[46] = int.Parse(comandReader["n_comboCol44Config"].ToString()); comboCol[47] = int.Parse(comandReader["n_comboCol45Config"].ToString());
                comboCol[48] = int.Parse(comandReader["n_comboCol46Config"].ToString()); comboCol[49] = int.Parse(comandReader["n_comboCol47Config"].ToString()); comboCol[50] = int.Parse(comandReader["n_comboCol48Config"].ToString()); comboCol[51] = int.Parse(comandReader["n_comboCol49Config"].ToString());
                comboCol[52] = int.Parse(comandReader["n_comboCol50Config"].ToString()); comboCol[53] = int.Parse(comandReader["n_comboCol51Config"].ToString());

                comboRow[0] = int.Parse(comandReader["n_comboRowA0Config"].ToString()); comboRow[1] = int.Parse(comandReader["n_comboRowA1Config"].ToString()); comboRow[2] = int.Parse(comandReader["n_comboRowA2Config"].ToString()); comboRow[3] = int.Parse(comandReader["n_comboRowA3Config"].ToString());
                comboRow[4] = int.Parse(comandReader["n_comboRowA4Config"].ToString()); comboRow[5] = int.Parse(comandReader["n_comboRowA5Config"].ToString()); comboRow[6] = int.Parse(comandReader["n_comboRowA6Config"].ToString()); comboRow[7] = int.Parse(comandReader["n_comboRowA7Config"].ToString());
                comboRow[8] = int.Parse(comandReader["n_comboRowA8Config"].ToString()); comboRow[9] = int.Parse(comandReader["n_comboRowA9Config"].ToString()); comboRow[10] = int.Parse(comandReader["n_comboRowA10Config"].ToString()); comboRow[11] = int.Parse(comandReader["n_comboRowA11Config"].ToString());
                comboRow[12] = int.Parse(comandReader["n_comboRowA12Config"].ToString()); comboRow[13] = int.Parse(comandReader["n_comboRowA13Config"].ToString()); comboRow[14] = int.Parse(comandReader["n_comboRowA14Config"].ToString()); comboRow[15] = int.Parse(comandReader["n_comboRowA15Config"].ToString());
                comboRow[16] = int.Parse(comandReader["n_comboRow2Config"].ToString()); comboRow[17] = int.Parse(comandReader["n_comboRow3Config"].ToString()); comboRow[18] = int.Parse(comandReader["n_comboRow4Config"].ToString()); comboRow[19] = int.Parse(comandReader["n_comboRow5Config"].ToString());
                comboRow[20] = int.Parse(comandReader["n_comboRow6Config"].ToString()); comboRow[21] = int.Parse(comandReader["n_comboRow7Config"].ToString()); comboRow[22] = int.Parse(comandReader["n_comboRow8Config"].ToString()); comboRow[23] = int.Parse(comandReader["n_comboRow9Config"].ToString());
                comboRow[24] = int.Parse(comandReader["n_comboRow22Config"].ToString()); comboRow[25] = int.Parse(comandReader["n_comboRow23Config"].ToString()); comboRow[26] = int.Parse(comandReader["n_comboRow24Config"].ToString()); comboRow[27] = int.Parse(comandReader["n_comboRow25Config"].ToString());
                comboRow[28] = int.Parse(comandReader["n_comboRow26Config"].ToString()); comboRow[29] = int.Parse(comandReader["n_comboRow27Config"].ToString()); comboRow[30] = int.Parse(comandReader["n_comboRow28Config"].ToString()); comboRow[31] = int.Parse(comandReader["n_comboRow29Config"].ToString());
                comboRow[32] = int.Parse(comandReader["n_comboRow30Config"].ToString()); comboRow[33] = int.Parse(comandReader["n_comboRow31Config"].ToString()); comboRow[34] = int.Parse(comandReader["n_comboRow32Config"].ToString()); comboRow[35] = int.Parse(comandReader["n_comboRow33Config"].ToString());
                comboRow[36] = int.Parse(comandReader["n_comboRow34Config"].ToString()); comboRow[37] = int.Parse(comandReader["n_comboRow35Config"].ToString()); comboRow[38] = int.Parse(comandReader["n_comboRow36Config"].ToString()); comboRow[39] = int.Parse(comandReader["n_comboRow37Config"].ToString());
                comboRow[40] = int.Parse(comandReader["n_comboRow38Config"].ToString()); comboRow[41] = int.Parse(comandReader["n_comboRow39Config"].ToString()); comboRow[42] = int.Parse(comandReader["n_comboRow40Config"].ToString()); comboRow[43] = int.Parse(comandReader["n_comboRow41Config"].ToString());
                comboRow[44] = int.Parse(comandReader["n_comboRow42Config"].ToString()); comboRow[45] = int.Parse(comandReader["n_comboRow43Config"].ToString()); comboRow[46] = int.Parse(comandReader["n_comboRow44Config"].ToString()); comboRow[47] = int.Parse(comandReader["n_comboRow45Config"].ToString());
                comboRow[48] = int.Parse(comandReader["n_comboRow46Config"].ToString()); comboRow[49] = int.Parse(comandReader["n_comboRow47Config"].ToString()); comboRow[50] = int.Parse(comandReader["n_comboRow48Config"].ToString()); comboRow[51] = int.Parse(comandReader["n_comboRow49Config"].ToString());
                comboRow[52] = int.Parse(comandReader["n_comboRow50Config"].ToString()); comboRow[53] = int.Parse(comandReader["n_comboRow51Config"].ToString());

                watts[0] = int.Parse(comandReader["n_txtWats_A0Config"].ToString()); watts[1] = int.Parse(comandReader["n_txtWats_A1Config"].ToString()); watts[2] = int.Parse(comandReader["n_txtWats_A2Config"].ToString()); watts[3] = int.Parse(comandReader["n_txtWats_A3Config"].ToString());
                watts[4] = int.Parse(comandReader["n_txtWats_A4Config"].ToString()); watts[5] = int.Parse(comandReader["n_txtWats_A5Config"].ToString()); watts[6] = int.Parse(comandReader["n_txtWats_A6Config"].ToString()); watts[7] = int.Parse(comandReader["n_txtWats_A7Config"].ToString());
                watts[8] = int.Parse(comandReader["n_txtWats_A8Config"].ToString()); watts[9] = int.Parse(comandReader["n_txtWats_A9Config"].ToString()); watts[10] = int.Parse(comandReader["n_txtWats_A10Config"].ToString()); watts[11] = int.Parse(comandReader["n_txtWats_A11Config"].ToString());
                watts[12] = int.Parse(comandReader["n_txtWats_A12Config"].ToString()); watts[13] = int.Parse(comandReader["n_txtWats_A13Config"].ToString()); watts[14] = int.Parse(comandReader["n_txtWats_A14Config"].ToString()); watts[15] = int.Parse(comandReader["n_txtWats_A15Config"].ToString());
                watts[16] = int.Parse(comandReader["n_txtWats_2Config"].ToString()); watts[17] = int.Parse(comandReader["n_txtWats_3Config"].ToString()); watts[18] = int.Parse(comandReader["n_txtWats_4Config"].ToString()); watts[19] = int.Parse(comandReader["n_txtWats_5Config"].ToString());
                watts[20] = int.Parse(comandReader["n_txtWats_6Config"].ToString()); watts[21] = int.Parse(comandReader["n_txtWats_7Config"].ToString()); watts[22] = int.Parse(comandReader["n_txtWats_8Config"].ToString()); watts[23] = int.Parse(comandReader["n_txtWats_9Config"].ToString());
                watts[24] = int.Parse(comandReader["n_txtWats_22Config"].ToString()); watts[25] = int.Parse(comandReader["n_txtWats_23Config"].ToString()); watts[26] = int.Parse(comandReader["n_txtWats_24Config"].ToString()); watts[27] = int.Parse(comandReader["n_txtWats_25Config"].ToString());
                watts[28] = int.Parse(comandReader["n_txtWats_26Config"].ToString()); watts[29] = int.Parse(comandReader["n_txtWats_27Config"].ToString()); watts[30] = int.Parse(comandReader["n_txtWats_28Config"].ToString()); watts[31] = int.Parse(comandReader["n_txtWats_29Config"].ToString());
                watts[32] = int.Parse(comandReader["n_txtWats_30Config"].ToString()); watts[33] = int.Parse(comandReader["n_txtWats_31Config"].ToString()); watts[34] = int.Parse(comandReader["n_txtWats_32Config"].ToString()); watts[35] = int.Parse(comandReader["n_txtWats_33Config"].ToString());
                watts[36] = int.Parse(comandReader["n_txtWats_34Config"].ToString()); watts[37] = int.Parse(comandReader["n_txtWats_35Config"].ToString()); watts[38] = int.Parse(comandReader["n_txtWats_36Config"].ToString()); watts[39] = int.Parse(comandReader["n_txtWats_37Config"].ToString());
                watts[40] = int.Parse(comandReader["n_txtWats_38Config"].ToString()); watts[41] = int.Parse(comandReader["n_txtWats_39Config"].ToString()); watts[42] = int.Parse(comandReader["n_txtWats_40Config"].ToString()); watts[43] = int.Parse(comandReader["n_txtWats_41Config"].ToString());
                watts[44] = int.Parse(comandReader["n_txtWats_42Config"].ToString()); watts[45] = int.Parse(comandReader["n_txtWats_43Config"].ToString()); watts[46] = int.Parse(comandReader["n_txtWats_44Config"].ToString()); watts[47] = int.Parse(comandReader["n_txtWats_45Config"].ToString());
                watts[48] = int.Parse(comandReader["n_txtWats_46Config"].ToString()); watts[49] = int.Parse(comandReader["n_txtWats_47Config"].ToString()); watts[50] = int.Parse(comandReader["n_txtWats_48Config"].ToString()); watts[51] = int.Parse(comandReader["n_txtWats_49Config"].ToString());
                watts[52] = int.Parse(comandReader["n_txtWats_50Config"].ToString()); watts[53] = int.Parse(comandReader["n_txtWats_51Config"].ToString());
            }
            catch (Exception e)
            {
                //Verifica o date time para garantir que o banco não esteja em branco e quebre na primeira
                //vez que for utilizado, ou seja, sem nenhuma configuração salva
                if (d_DataConfig != DateTime.Parse("01/01/0001 00:00:00"))
                {
                    MessageBox.Show("Erro na consulta do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            finally
            {
                connect.Close();
            }
        }

        /// <summary>
        /// Metodo publico realiza Login na aplicação
        /// </summary>
        /// <param name="c_LogginUsers"></param>
        /// <param name="c_PasswUsers"></param>
        /// <returns></returns>
        public bool LoginUser(string c_LogginUsers, string c_PasswUsers)
        {
            string retorno = ""; bool resultado = false;

            string QuerySql = "SELECT * FROM controleambientesdb.users Where c_LogginUsers = '" + c_LogginUsers + "' And c_PasswUsers = md5('" + c_PasswUsers + "')";

            MySqlConnection connect = new MySqlConnection(path);

            try
            {

                connect.Open();

                MySqlCommand comand = new MySqlCommand(QuerySql, connect);
                MySqlDataReader comandReader = comand.ExecuteReader();

                comandReader.Read();

                retorno = comandReader["c_EmailUsers"].ToString();

            }
            catch { }
            finally { connect.Close(); }

            resultado = retorno.Equals("") ? false : true;

            return resultado;
        }

        /// <summary>
        /// Metodo publico inseri usuário no banco
        /// </summary>
        /// <param name="c_EmailUsers"></param>
        /// <param name="c_NameUsers"></param>
        /// <param name="c_LogginUsers"></param>
        public void SaveUser(string c_EmailUsers, string c_NameUsers, string c_LogginUsers, string c_PasswUsers)
        {
            string QuerySql = "INSERT INTO controleambientesdb.users VALUES('" + c_EmailUsers + "','" + c_NameUsers + "', '" + c_LogginUsers + "', md5('" + c_PasswUsers + "'),'" + DateTime.Now.ToString(dataFormat) + "')";

            MySqlConnection connect = new MySqlConnection(path);
            MySqlCommand comand = new MySqlCommand(QuerySql, connect);

            try
            {
                connect.Open();
                comand.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                if (e.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Para salvar alteração de usuário já salvos, primeiro exclua-o.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na gravação do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }
        }

        /// <summary>
        /// Metodo publico deleta usuário
        /// </summary>
        /// <param name="c_EmailUsers"></param>
        public void DeleteUser(string c_EmailUsers)
        {
            string QuerySql = "DELETE FROM controleambientesdb.users WHERE c_EmailUsers = '" + c_EmailUsers + "'";

            MySqlConnection connect = new MySqlConnection(path);
            MySqlCommand comand = new MySqlCommand(QuerySql, connect);

            try
            {
                connect.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Deletar Usuário do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }
        }

        /// <summary>
        /// Metodo publico carrega datagrid na 
        /// tela de usuários
        /// </summary>
        /// <returns></returns>
        public DataSet FillDataGrid()
        {
            string QuerySql = "SELECT c_NameUsers, c_EmailUsers FROM controleambientesdb.users";

            MySqlConnection connect = new MySqlConnection(path);

            DataSet retorno = new DataSet();

            try
            {
                connect.Open();
                MySqlCommand comand = new MySqlCommand(QuerySql, connect);
                MySqlDataAdapter adp = new MySqlDataAdapter(comand);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                retorno = ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Carregar Usuários cadastrado no banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }

            return retorno;

        }

        /// <summary>
        /// Metodo publico reload usuario cadastrado
        /// para realizar devidas correções 
        /// </summary>
        /// <param name="c_EmailUsers"></param>
        /// <param name="c_NameUsers"></param>
        /// <param name="c_LogginUsers"></param>
        public void ReloadUsers(ref string c_EmailUsers, ref string c_NameUsers, ref string c_LogginUsers)
        {
            string QuerySql = "SELECT c_NameUsers, c_LogginUsers FROM controleambientesdb.users Where c_EmailUsers = '" + c_EmailUsers + "'";

            MySqlConnection connect = new MySqlConnection(path);

            try
            {

                connect.Open();

                MySqlCommand comand = new MySqlCommand(QuerySql, connect);
                MySqlDataReader comandReader = comand.ExecuteReader();

                comandReader.Read();

                c_NameUsers = comandReader["c_NameUsers"].ToString();
                c_LogginUsers = comandReader["c_NameUsers"].ToString();


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Carregar Usuários cadastrado no banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }

        }

        /// <summary>
        /// Metodo publico captura dados de ação das saidas mantendo assim
        /// um histórico de consumo pra consulta posterior
        /// </summary>
        /// <param name="Event"></param>
        /// <param name="Action"></param>
        /// <param name="Wats"></param>
        public void InsertActions(string Event, string Action, int Wats)
        {
            string QuerySql = "INSERT INTO controleambientesdb.dataevent VALUES (null, '" + DateTime.Now.ToString(dataFormat) + "','" + Event + "','" + Action + "', " + Wats + ")";

            MySqlConnection connect = new MySqlConnection(path);
            MySqlCommand comand = new MySqlCommand(QuerySql, connect);

            try
            {
                connect.Open();
                comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na gravação do banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }
        }

        /// <summary>
        /// Metodo publico carrega dados capturados dos eventos
        /// </summary>
        /// <param name="dateStart"></param>
        /// <param name="dateEnd"></param>
        /// <returns></returns>
        public DataSet FillDataGridData(string dateStart, string dateEnd)
        {
            string QuerySql = "SELECT * FROM controleambientesdb.dataevent where d_DataEvent >= '" + dateStart + "' and d_DataEvent <= '" + dateEnd + "'";

            MySqlConnection connect = new MySqlConnection(path);

            DataSet retorno = new DataSet();

            try
            {
                connect.Open();
                MySqlCommand comand = new MySqlCommand(QuerySql, connect);
                MySqlDataAdapter adp = new MySqlDataAdapter(comand);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                retorno = ds;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Carregar Usuários cadastrado no banco: " + e.ToString(), "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { connect.Close(); }

            return retorno;

        }

    }

}

