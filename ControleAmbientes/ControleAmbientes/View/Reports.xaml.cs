using System; 
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Reports.xaml
    /// </summary>
    public partial class Reports : Window
    {

        Class.CRUD crud = new Class.CRUD();

        public Reports()
        {
            InitializeComponent();
        }

        private void btFiltrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridData.DataContext = crud.FillDataGridData(dataInicial.SelectedDate.Value.ToString("yyyy/MM/dd 00:00:00"), dataFinal.SelectedDate.Value.ToString("yyyy/MM/dd 23:59:59"));
            }
            catch
            {
                MessageBox.Show("Favor informar datas para realizar uma consulta", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        DateTime[] inicio = new DateTime[32];
        DateTime[] fim = new DateTime[32];
        TimeSpan[] total = new TimeSpan[32];
        TimeSpan soma = TimeSpan.Zero;

        double[] consumo = new double[32];
        double consumoTotal = 0.0;

        int loop = -1;

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            dataGridData.SelectedIndex = -1;

            if (dataGridData.Items.Count > 0)
            {
                while (loop < (dataGridData.Items.Count-1))
                {
                    loop += 1;
                    dataGridData.SelectedIndex = loop;

                    DataRowView dataRow = (DataRowView)dataGridData.SelectedItem;
                    string obejto = dataRow.Row.ItemArray[2].ToString();
                    string action = dataRow.Row.ItemArray[3].ToString();
                    string watts = dataRow.Row.ItemArray[4].ToString();
                    DateTime date = DateTime.Parse(dataRow.Row.ItemArray[1].ToString());

                    #region Grupo Coluna 1

                    //Calcula tempo do Objeto IO_C1L1
                    if (obejto == "IO_C1L1" && action.Substring(0, 1) == "H" && inicio[0] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[0] = date;
                    }

                    if (obejto == "IO_C1L1" && action.Substring(0, 1) == "D")
                    {
                        fim[0] = date;

                        total[0] += fim[0].Subtract(inicio[0]);

                        inicio[0] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[0] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[0].Seconds.ToString()) + (int.Parse(total[0].Minutes.ToString()) * 60) + (int.Parse(total[0].Hours.ToString()) * 3600) + (int.Parse(total[0].Days.ToString()) * 86400);

                        consumo[0] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L2
                    if (obejto == "IO_C1L2" && action.Substring(0, 1) == "H" && inicio[1] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[1] = date;
                    }

                    if (obejto == "IO_C1L2" && action.Substring(0, 1) == "D")
                    {
                        fim[1] = date;

                        total[1] += fim[1].Subtract(inicio[1]);

                        inicio[1] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[1] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[1].Seconds.ToString()) + (int.Parse(total[1].Minutes.ToString()) * 60) + (int.Parse(total[1].Hours.ToString()) * 3600) + (int.Parse(total[1].Days.ToString()) * 86400);

                        consumo[1] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L3
                    if (obejto == "IO_C1L3" && action.Substring(0, 1) == "H" && inicio[2] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[2] = date;
                    }

                    if (obejto == "IO_C1L3" && action.Substring(0, 1) == "D")
                    {
                        fim[2] = date;

                        total[2] += fim[2].Subtract(inicio[2]);

                        inicio[2] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[2] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[2].Seconds.ToString()) + (int.Parse(total[2].Minutes.ToString()) * 60) + (int.Parse(total[2].Hours.ToString()) * 3600) + (int.Parse(total[2].Days.ToString()) * 86400);

                        consumo[2] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L4
                    if (obejto == "IO_C1L4" && action.Substring(0, 1) == "H" && inicio[3] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[3] = date;
                    }

                    if (obejto == "IO_C1L4" && action.Substring(0, 1) == "D")
                    {
                        fim[3] = date;

                        total[3] += fim[3].Subtract(inicio[3]);

                        inicio[3] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[3] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[3].Seconds.ToString()) + (int.Parse(total[3].Minutes.ToString()) * 60) + (int.Parse(total[3].Hours.ToString()) * 3600) + (int.Parse(total[3].Days.ToString()) * 86400);

                        consumo[3] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L5
                    if (obejto == "IO_C1L5" && action.Substring(0, 1) == "H" && inicio[4] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[4] = date;
                    }

                    if (obejto == "IO_C1L5" && action.Substring(0, 1) == "D")
                    {
                        fim[4] = date;

                        total[4] += fim[4].Subtract(inicio[4]);

                        inicio[4] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[4] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[4].Seconds.ToString()) + (int.Parse(total[4].Minutes.ToString()) * 60) + (int.Parse(total[4].Hours.ToString()) * 3600) + (int.Parse(total[4].Days.ToString()) * 86400);

                        consumo[4] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L6
                    if (obejto == "IO_C1L6" && action.Substring(0, 1) == "H" && inicio[5] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[5] = date;
                    }

                    if (obejto == "IO_C1L6" && action.Substring(0, 1) == "D")
                    {
                        fim[5] = date;

                        total[5] += fim[5].Subtract(inicio[5]);

                        inicio[5] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[5] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[5].Seconds.ToString()) + (int.Parse(total[5].Minutes.ToString()) * 60) + (int.Parse(total[5].Hours.ToString()) * 3600) + (int.Parse(total[5].Days.ToString()) * 86400);

                        consumo[5] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L7
                    if (obejto == "IO_C1L7" && action.Substring(0, 1) == "H" && inicio[6] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[6] = date;
                    }

                    if (obejto == "IO_C1L7" && action.Substring(0, 1) == "D")
                    {
                        fim[6] = date;

                        total[6] += fim[6].Subtract(inicio[6]);

                        inicio[6] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[6] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[6].Seconds.ToString()) + (int.Parse(total[6].Minutes.ToString()) * 60) + (int.Parse(total[6].Hours.ToString()) * 3600) + (int.Parse(total[6].Days.ToString()) * 86400);

                        consumo[6] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C1L8
                    if (obejto == "IO_C1L8" && action.Substring(0, 1) == "H" && inicio[7] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[7] = date;
                    }

                    if (obejto == "IO_C1L8" && action.Substring(0, 1) == "D")
                    {
                        fim[7] = date;

                        total[7] += fim[7].Subtract(inicio[7]);

                        inicio[7] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[7] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[7].Seconds.ToString()) + (int.Parse(total[7].Minutes.ToString()) * 60) + (int.Parse(total[7].Hours.ToString()) * 3600) + (int.Parse(total[7].Days.ToString()) * 86400);

                        consumo[7] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    #endregion

                    #region Grupo Coluna 2

                    //Calcula tempo do Objeto IO_C2L1
                    if (obejto == "IO_C2L1" && action.Substring(0, 1) == "H" && inicio[8] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[8] = date;
                    }

                    if (obejto == "IO_C2L1" && action.Substring(0, 1) == "D")
                    {
                        fim[8] = date;

                        total[8] += fim[8].Subtract(inicio[8]);

                        inicio[8] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[8] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[8].Seconds.ToString()) + (int.Parse(total[8].Minutes.ToString()) * 60) + (int.Parse(total[8].Hours.ToString()) * 3600) + (int.Parse(total[8].Days.ToString()) * 86400);

                        consumo[8] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L2
                    if (obejto == "IO_C2L2" && action.Substring(0, 1) == "H" && inicio[9] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[9] = date;
                    }

                    if (obejto == "IO_C2L2" && action.Substring(0, 1) == "D")
                    {
                        fim[9] = date;

                        total[9] += fim[9].Subtract(inicio[9]);

                        inicio[9] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[9] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[9].Seconds.ToString()) + (int.Parse(total[9].Minutes.ToString()) * 60) + (int.Parse(total[9].Hours.ToString()) * 3600) + (int.Parse(total[9].Days.ToString()) * 86400);

                        consumo[9] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L3
                    if (obejto == "IO_C2L3" && action.Substring(0, 1) == "H" && inicio[10] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[10] = date;
                    }

                    if (obejto == "IO_C2L3" && action.Substring(0, 1) == "D")
                    {
                        fim[10] = date;

                        total[10] += fim[10].Subtract(inicio[10]);

                        inicio[10] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[10] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[10].Seconds.ToString()) + (int.Parse(total[10].Minutes.ToString()) * 60) + (int.Parse(total[10].Hours.ToString()) * 3600) + (int.Parse(total[10].Days.ToString()) * 86400);

                        consumo[10] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L4
                    if (obejto == "IO_C2L4" && action.Substring(0, 1) == "H" && inicio[11] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[11] = date;
                    }

                    if (obejto == "IO_C2L4" && action.Substring(0, 1) == "D")
                    {
                        fim[11] = date;

                        total[11] += fim[11].Subtract(inicio[11]);

                        inicio[11] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[11] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[11].Seconds.ToString()) + (int.Parse(total[11].Minutes.ToString()) * 60) + (int.Parse(total[11].Hours.ToString()) * 3600) + (int.Parse(total[11].Days.ToString()) * 86400);

                        consumo[11] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L5
                    if (obejto == "IO_C2L5" && action.Substring(0, 1) == "H" && inicio[12] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[12] = date;
                    }

                    if (obejto == "IO_C2L5" && action.Substring(0, 1) == "D")
                    {
                        fim[12] = date;

                        total[12] += fim[12].Subtract(inicio[12]);

                        inicio[12] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[12] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[12].Seconds.ToString()) + (int.Parse(total[12].Minutes.ToString()) * 60) + (int.Parse(total[12].Hours.ToString()) * 3600) + (int.Parse(total[12].Days.ToString()) * 86400);

                        consumo[12] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L6
                    if (obejto == "IO_C2L6" && action.Substring(0, 1) == "H" && inicio[13] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[13] = date;
                    }

                    if (obejto == "IO_C2L6" && action.Substring(0, 1) == "D")
                    {
                        fim[13] = date;

                        total[13] += fim[13].Subtract(inicio[13]);

                        inicio[13] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[13] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[13].Seconds.ToString()) + (int.Parse(total[13].Minutes.ToString()) * 60) + (int.Parse(total[13].Hours.ToString()) * 3600) + (int.Parse(total[13].Days.ToString()) * 86400);

                        consumo[13] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L7
                    if (obejto == "IO_C2L7" && action.Substring(0, 1) == "H" && inicio[14] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[14] = date;
                    }

                    if (obejto == "IO_C2L7" && action.Substring(0, 1) == "D")
                    {
                        fim[14] = date;

                        total[14] += fim[14].Subtract(inicio[14]);

                        inicio[14] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[14] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[14].Seconds.ToString()) + (int.Parse(total[14].Minutes.ToString()) * 60) + (int.Parse(total[14].Hours.ToString()) * 3600) + (int.Parse(total[14].Days.ToString()) * 86400);

                        consumo[14] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C2L8
                    if (obejto == "IO_C2L8" && action.Substring(0, 1) == "H" && inicio[15] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[15] = date;
                    }

                    if (obejto == "IO_C2L8" && action.Substring(0, 1) == "D")
                    {
                        fim[15] = date;

                        total[15] += fim[15].Subtract(inicio[15]);

                        inicio[15] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[15] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[15].Seconds.ToString()) + (int.Parse(total[15].Minutes.ToString()) * 60) + (int.Parse(total[15].Hours.ToString()) * 3600) + (int.Parse(total[15].Days.ToString()) * 86400);

                        consumo[15] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    #endregion

                    #region Grupo Coluna 3

                    //Calcula tempo do Objeto IO_C3L1
                    if (obejto == "IO_C3L1" && action.Substring(0, 1) == "H" && inicio[16] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[16] = date;
                    }

                    if (obejto == "IO_C3L1" && action.Substring(0, 1) == "D")
                    {
                        fim[16] = date;

                        total[16] += fim[16].Subtract(inicio[16]);

                        inicio[16] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[16] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[16].Seconds.ToString()) + (int.Parse(total[16].Minutes.ToString()) * 60) + (int.Parse(total[16].Hours.ToString()) * 3600) + (int.Parse(total[16].Days.ToString()) * 86400);

                        consumo[16] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L2
                    if (obejto == "IO_C3L2" && action.Substring(0, 1) == "H" && inicio[17] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[17] = date;
                    }

                    if (obejto == "IO_C3L2" && action.Substring(0, 1) == "D")
                    {
                        fim[17] = date;

                        total[17] += fim[17].Subtract(inicio[17]);

                        inicio[17] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[17] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[17].Seconds.ToString()) + (int.Parse(total[17].Minutes.ToString()) * 60) + (int.Parse(total[17].Hours.ToString()) * 3600) + (int.Parse(total[17].Days.ToString()) * 86400);

                        consumo[17] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L3
                    if (obejto == "IO_C3L3" && action.Substring(0, 1) == "H" && inicio[18] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[18] = date;
                    }

                    if (obejto == "IO_C3L3" && action.Substring(0, 1) == "D")
                    {
                        fim[18] = date;

                        total[18] += fim[18].Subtract(inicio[18]);

                        inicio[18] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[18] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[18].Seconds.ToString()) + (int.Parse(total[18].Minutes.ToString()) * 60) + (int.Parse(total[18].Hours.ToString()) * 3600) + (int.Parse(total[18].Days.ToString()) * 86400);

                        consumo[18] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L4
                    if (obejto == "IO_C3L4" && action.Substring(0, 1) == "H" && inicio[19] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[19] = date;
                    }

                    if (obejto == "IO_C3L4" && action.Substring(0, 1) == "D")
                    {
                        fim[19] = date;

                        total[19] += fim[19].Subtract(inicio[19]);

                        inicio[19] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[19] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[19].Seconds.ToString()) + (int.Parse(total[19].Minutes.ToString()) * 60) + (int.Parse(total[19].Hours.ToString()) * 3600) + (int.Parse(total[19].Days.ToString()) * 86400);

                        consumo[19] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L5
                    if (obejto == "IO_C3L5" && action.Substring(0, 1) == "H" && inicio[20] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[20] = date;
                    }

                    if (obejto == "IO_C3L5" && action.Substring(0, 1) == "D")
                    {
                        fim[20] = date;

                        total[20] += fim[20].Subtract(inicio[20]);

                        inicio[20] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[20] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[20].Seconds.ToString()) + (int.Parse(total[20].Minutes.ToString()) * 60) + (int.Parse(total[20].Hours.ToString()) * 3600) + (int.Parse(total[20].Days.ToString()) * 86400);

                        consumo[20] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L6
                    if (obejto == "IO_C3L6" && action.Substring(0, 1) == "H" && inicio[21] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[21] = date;
                    }

                    if (obejto == "IO_C3L6" && action.Substring(0, 1) == "D")
                    {
                        fim[21] = date;

                        total[21] += fim[21].Subtract(inicio[21]);

                        inicio[21] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[21] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[21].Seconds.ToString()) + (int.Parse(total[21].Minutes.ToString()) * 60) + (int.Parse(total[21].Hours.ToString()) * 3600) + (int.Parse(total[21].Days.ToString()) * 86400);

                        consumo[21] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L7
                    if (obejto == "IO_C3L7" && action.Substring(0, 1) == "H" && inicio[22] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[22] = date;
                    }

                    if (obejto == "IO_C3L7" && action.Substring(0, 1) == "D")
                    {
                        fim[22] = date;

                        total[22] += fim[22].Subtract(inicio[22]);

                        inicio[22] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[22] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[22].Seconds.ToString()) + (int.Parse(total[22].Minutes.ToString()) * 60) + (int.Parse(total[22].Hours.ToString()) * 3600) + (int.Parse(total[22].Days.ToString()) * 86400);

                        consumo[22] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C3L8
                    if (obejto == "IO_C3L8" && action.Substring(0, 1) == "H" && inicio[23] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[23] = date;
                    }

                    if (obejto == "IO_C3L8" && action.Substring(0, 1) == "D")
                    {
                        fim[23] = date;

                        total[23] += fim[23].Subtract(inicio[23]);

                        inicio[23] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[23] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[23].Seconds.ToString()) + (int.Parse(total[23].Minutes.ToString()) * 60) + (int.Parse(total[23].Hours.ToString()) * 3600) + (int.Parse(total[23].Days.ToString()) * 86400);

                        consumo[23] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    #endregion

                    #region Grupo Coluna 4

                    //Calcula tempo do Objeto IO_C4L1
                    if (obejto == "IO_C4L1" && action.Substring(0, 1) == "H" && inicio[24] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[24] = date;
                    }

                    if (obejto == "IO_C4L1" && action.Substring(0, 1) == "D")
                    {
                        fim[24] = date;

                        total[24] += fim[24].Subtract(inicio[24]);

                        inicio[24] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[24] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[24].Seconds.ToString()) + (int.Parse(total[24].Minutes.ToString()) * 60) + (int.Parse(total[24].Hours.ToString()) * 3600) + (int.Parse(total[24].Days.ToString()) * 86400);

                        consumo[24] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L2
                    if (obejto == "IO_C4L2" && action.Substring(0, 1) == "H" && inicio[25] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[25] = date;
                    }

                    if (obejto == "IO_C4L2" && action.Substring(0, 1) == "D")
                    {
                        fim[25] = date;

                        total[25] += fim[25].Subtract(inicio[25]);

                        inicio[25] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[25] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[25].Seconds.ToString()) + (int.Parse(total[25].Minutes.ToString()) * 60) + (int.Parse(total[25].Hours.ToString()) * 3600) + (int.Parse(total[25].Days.ToString()) * 86400);

                        consumo[25] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L3
                    if (obejto == "IO_C4L3" && action.Substring(0, 1) == "H" && inicio[26] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[26] = date;
                    }

                    if (obejto == "IO_C4L3" && action.Substring(0, 1) == "D")
                    {
                        fim[26] = date;

                        total[26] += fim[26].Subtract(inicio[26]);

                        inicio[26] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[26] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[26].Seconds.ToString()) + (int.Parse(total[26].Minutes.ToString()) * 60) + (int.Parse(total[26].Hours.ToString()) * 3600) + (int.Parse(total[26].Days.ToString()) * 86400);

                        consumo[26] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L4
                    if (obejto == "IO_C4L4" && action.Substring(0, 1) == "H" && inicio[27] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[27] = date;
                    }

                    if (obejto == "IO_C4L4" && action.Substring(0, 1) == "D")
                    {
                        fim[27] = date;

                        total[27] += fim[27].Subtract(inicio[27]);

                        inicio[27] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[27] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[27].Seconds.ToString()) + (int.Parse(total[27].Minutes.ToString()) * 60) + (int.Parse(total[27].Hours.ToString()) * 3600) + (int.Parse(total[27].Days.ToString()) * 86400);

                        consumo[27] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L5
                    if (obejto == "IO_C4L5" && action.Substring(0, 1) == "H" && inicio[28] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[28] = date;
                    }

                    if (obejto == "IO_C4L5" && action.Substring(0, 1) == "D")
                    {
                        fim[28] = date;

                        total[28] += fim[28].Subtract(inicio[28]);

                        inicio[28] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[28] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[28].Seconds.ToString()) + (int.Parse(total[28].Minutes.ToString()) * 60) + (int.Parse(total[28].Hours.ToString()) * 3600) + (int.Parse(total[28].Days.ToString()) * 86400);

                        consumo[28] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L6
                    if (obejto == "IO_C4L6" && action.Substring(0, 1) == "H" && inicio[29] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[29] = date;
                    }

                    if (obejto == "IO_C4L6" && action.Substring(0, 1) == "D")
                    {
                        fim[29] = date;

                        total[29] += fim[29].Subtract(inicio[29]);

                        inicio[29] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[29] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[29].Seconds.ToString()) + (int.Parse(total[29].Minutes.ToString()) * 60) + (int.Parse(total[29].Hours.ToString()) * 3600) + (int.Parse(total[29].Days.ToString()) * 86400);

                        consumo[29] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L7
                    if (obejto == "IO_C4L7" && action.Substring(0, 1) == "H" && inicio[30] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[30] = date;
                    }

                    if (obejto == "IO_C4L7" && action.Substring(0, 1) == "D")
                    {
                        fim[30] = date;

                        total[30] += fim[30].Subtract(inicio[30]);

                        inicio[30] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[30] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[30].Seconds.ToString()) + (int.Parse(total[30].Minutes.ToString()) * 60) + (int.Parse(total[30].Hours.ToString()) * 3600) + (int.Parse(total[30].Days.ToString()) * 86400);

                        consumo[30] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    //Calcula tempo do Objeto IO_C4L8
                    if (obejto == "IO_C4L8" && action.Substring(0, 1) == "H" && inicio[31] == DateTime.Parse("01/01/0001 00:00:00"))
                    {
                        inicio[31] = date;
                    }

                    if (obejto == "IO_C4L8" && action.Substring(0, 1) == "D")
                    {
                        fim[31] = date;

                        total[31] += fim[31].Subtract(inicio[31]);

                        inicio[31] = DateTime.Parse("01/01/0001 00:00:00");
                        fim[31] = DateTime.Parse("01/01/0001 00:00:00");

                        int time = int.Parse(total[31].Seconds.ToString()) + (int.Parse(total[31].Minutes.ToString()) * 60) + (int.Parse(total[31].Hours.ToString()) * 3600) + (int.Parse(total[31].Days.ToString()) * 86400);

                        consumo[31] += time * ((double.Parse(watts) / 3600)/1000);
                    }

                    #endregion

                }

                for (int x = 0; x <= 31; x++)
                {

                    if (total[x] != TimeSpan.Zero)
                    {
                        soma += total[x];
                        consumoTotal += consumo[x];
                        inicio.SetValue(DateTime.Parse("01/01/0001 00:00:00"), x);
                        fim.SetValue(DateTime.Parse("01/01/0001 00:00:00"), x);
                        total.SetValue(TimeSpan.Zero, x);
                        consumo.SetValue(0.0, x);

                    }

                }

                double valorTotal = consumoTotal * double.Parse(tarifa.Text);

                MessageBox.Show($"Você tem {soma} horas de cargas, \ngerando {consumoTotal.ToString("F3")} Kw de consumo.\nTotal aproximado de R$ {valorTotal.ToString("F2")}.", "! ! ! Resultado do Consumo ! ! !", MessageBoxButton.OK, MessageBoxImage.Information);

                soma = TimeSpan.Zero;
                consumoTotal = 0.0;

                loop = -1;
            }
        }

        private void tarifa_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9,]");
        }
    }
}
