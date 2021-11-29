using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Select.xaml
    /// </summary>
    public partial class Select : Window
    {
        Uri fileUriOn = new Uri("/Img/btON.png", UriKind.Relative);
        Uri fileUriOFF = new Uri("/Img/btOFF.png", UriKind.Relative);
        Class.CRUD crud = new Class.CRUD();

        DispatcherTimer timerUpdateValues = new DispatcherTimer();

        public Select()
        {
            InitializeComponent();
            timerUpdateValues.Interval = System.TimeSpan.FromMilliseconds(500);
            timerUpdateValues.Tick += TimerUpdateValues_Tick;
            timerUpdateValues.Start();
        }

        private void TimerUpdateValues_Tick(object sender, EventArgs e)
        {
            update();
            updateTransition();
        }

        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //Consulta configuração de dados no banco
            Class.Views.viewConfiguration.updateConfig();

            //Update variaveis globais estaticas
            Class.Views.viewConfiguration.updateGlobalVar();

            //Atualiza variaveis globais seletoras
            Class.Views.viewConfiguration.enableButtonSelect();

            //Limpa os dados da Lista utilizada
            Class.Variables.enableButton.Clear();

            //Adicona valores novos a Lista Limpa 
            Class.Variables.enableButton.AddRange(Class.Variables.enableButtonSelect);
        }

        private void update()
        {
            //Bloco Botões Coluna 1
            btC1L1.Source = Class.Variables.btSelect[0] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[0] = !btC1L1.IsEnabled ? false : Class.Variables.btSelect[0];
            btC1L1.IsEnabled = Class.Variables.enableButton.Contains("200") ? true : false;
            btC1L1.Opacity = !btC1L1.IsEnabled ? 0.5 : 1.0;

            btC1L2.Source = Class.Variables.btSelect[1] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[1] = !btC1L2.IsEnabled ? false : Class.Variables.btSelect[1];
            btC1L2.IsEnabled = Class.Variables.enableButton.Contains("201") ? true : false;
            btC1L2.Opacity = !btC1L2.IsEnabled ? 0.5 : 1.0;

            btC1L3.Source = Class.Variables.btSelect[2] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[2] = !btC1L3.IsEnabled ? false : Class.Variables.btSelect[2];
            btC1L3.IsEnabled = Class.Variables.enableButton.Contains("202") ? true : false;
            btC1L3.Opacity = !btC1L3.IsEnabled ? 0.5 : 1.0;

            btC1L4.Source = Class.Variables.btSelect[3] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[3] = !btC1L4.IsEnabled ? false : Class.Variables.btSelect[3];
            btC1L4.IsEnabled = Class.Variables.enableButton.Contains("203") ? true : false;
            btC1L4.Opacity = !btC1L4.IsEnabled ? 0.5 : 1.0;

            btC1L5.Source = Class.Variables.btSelect[4] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[4] = !btC1L5.IsEnabled ? false : Class.Variables.btSelect[4];
            btC1L5.IsEnabled = Class.Variables.enableButton.Contains("204") ? true : false;
            btC1L5.Opacity = !btC1L5.IsEnabled ? 0.5 : 1.0;

            btC1L6.Source = Class.Variables.btSelect[5] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[5] = !btC1L6.IsEnabled ? false : Class.Variables.btSelect[5];
            btC1L6.IsEnabled = Class.Variables.enableButton.Contains("205") ? true : false;
            btC1L6.Opacity = !btC1L6.IsEnabled ? 0.5 : 1.0;

            btC1L7.Source = Class.Variables.btSelect[6] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[6] = !btC1L7.IsEnabled ? false : Class.Variables.btSelect[6];
            btC1L7.IsEnabled = Class.Variables.enableButton.Contains("206") ? true : false;
            btC1L7.Opacity = !btC1L7.IsEnabled ? 0.5 : 1.0;

            btC1L8.Source = Class.Variables.btSelect[7] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[7] = !btC1L8.IsEnabled ? false : Class.Variables.btSelect[7];
            btC1L8.IsEnabled = Class.Variables.enableButton.Contains("207") ? true : false;
            btC1L8.Opacity = !btC1L8.IsEnabled ? 0.5 : 1.0;

            //Bloco Botões Coluna 2
            btC2L1.Source = Class.Variables.btSelect[8] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[8] = !btC2L1.IsEnabled ? false : Class.Variables.btSelect[8];
            btC2L1.IsEnabled = Class.Variables.enableButton.Contains("210") ? true : false;
            btC2L1.Opacity = !btC2L1.IsEnabled ? 0.5 : 1.0;

            btC2L2.Source = Class.Variables.btSelect[9] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[9] = !btC2L2.IsEnabled ? false : Class.Variables.btSelect[9];
            btC2L2.IsEnabled = Class.Variables.enableButton.Contains("211") ? true : false;
            btC2L2.Opacity = !btC2L2.IsEnabled ? 0.5 : 1.0;

            btC2L3.Source = Class.Variables.btSelect[10] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[10] = !btC2L3.IsEnabled ? false : Class.Variables.btSelect[10];
            btC2L3.IsEnabled = Class.Variables.enableButton.Contains("212") ? true : false;
            btC2L3.Opacity = !btC2L3.IsEnabled ? 0.5 : 1.0;

            btC2L4.Source = Class.Variables.btSelect[11] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[11] = !btC2L4.IsEnabled ? false : Class.Variables.btSelect[11];
            btC2L4.IsEnabled = Class.Variables.enableButton.Contains("213") ? true : false;
            btC2L4.Opacity = !btC2L4.IsEnabled ? 0.5 : 1.0;

            btC2L5.Source = Class.Variables.btSelect[12] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[12] = !btC2L5.IsEnabled ? false : Class.Variables.btSelect[12];
            btC2L5.IsEnabled = Class.Variables.enableButton.Contains("214") ? true : false;
            btC2L5.Opacity = !btC2L5.IsEnabled ? 0.5 : 1.0;

            btC2L6.Source = Class.Variables.btSelect[13] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[13] = !btC2L6.IsEnabled ? false : Class.Variables.btSelect[13];
            btC2L6.IsEnabled = Class.Variables.enableButton.Contains("215") ? true : false;
            btC2L6.Opacity = !btC2L6.IsEnabled ? 0.5 : 1.0;

            btC2L7.Source = Class.Variables.btSelect[14] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[14] = !btC2L7.IsEnabled ? false : Class.Variables.btSelect[14];
            btC2L7.IsEnabled = Class.Variables.enableButton.Contains("216") ? true : false;
            btC2L7.Opacity = !btC2L7.IsEnabled ? 0.5 : 1.0;

            btC2L8.Source = Class.Variables.btSelect[15] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[15] = !btC2L8.IsEnabled ? false : Class.Variables.btSelect[15];
            btC2L8.IsEnabled = Class.Variables.enableButton.Contains("217") ? true : false;
            btC2L8.Opacity = !btC2L8.IsEnabled ? 0.5 : 1.0;

            //Bloco Botões Coluna 3
            btC3L1.Source = Class.Variables.btSelect[16] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[16] = !btC3L1.IsEnabled ? false : Class.Variables.btSelect[16];
            btC3L1.IsEnabled = Class.Variables.enableButton.Contains("220") ? true : false;
            btC3L1.Opacity = !btC3L1.IsEnabled ? 0.5 : 1.0;

            btC3L2.Source = Class.Variables.btSelect[17] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[17] = !btC3L2.IsEnabled ? false : Class.Variables.btSelect[17];
            btC3L2.IsEnabled = Class.Variables.enableButton.Contains("221") ? true : false;
            btC3L2.Opacity = !btC3L2.IsEnabled ? 0.5 : 1.0;

            btC3L3.Source = Class.Variables.btSelect[18] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[18] = !btC3L3.IsEnabled ? false : Class.Variables.btSelect[18];
            btC3L3.IsEnabled = Class.Variables.enableButton.Contains("222") ? true : false;
            btC3L3.Opacity = !btC3L3.IsEnabled ? 0.5 : 1.0;

            btC3L4.Source = Class.Variables.btSelect[19] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[19] = !btC3L4.IsEnabled ? false : Class.Variables.btSelect[19];
            btC3L4.IsEnabled = Class.Variables.enableButton.Contains("223") ? true : false;
            btC3L4.Opacity = !btC3L4.IsEnabled ? 0.5 : 1.0;

            btC3L5.Source = Class.Variables.btSelect[20] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[20] = !btC3L5.IsEnabled ? false : Class.Variables.btSelect[20];
            btC3L5.IsEnabled = Class.Variables.enableButton.Contains("224") ? true : false;
            btC3L5.Opacity = !btC3L5.IsEnabled ? 0.5 : 1.0;

            btC3L6.Source = Class.Variables.btSelect[21] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[21] = !btC3L6.IsEnabled ? false : Class.Variables.btSelect[21];
            btC3L6.IsEnabled = Class.Variables.enableButton.Contains("225") ? true : false;
            btC3L6.Opacity = !btC3L6.IsEnabled ? 0.5 : 1.0;

            btC3L7.Source = Class.Variables.btSelect[22] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[22] = !btC3L7.IsEnabled ? false : Class.Variables.btSelect[22];
            btC3L7.IsEnabled = Class.Variables.enableButton.Contains("226") ? true : false;
            btC3L7.Opacity = !btC3L7.IsEnabled ? 0.5 : 1.0;

            btC3L8.Source = Class.Variables.btSelect[23] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[23] = !btC3L8.IsEnabled ? false : Class.Variables.btSelect[23];
            btC3L8.IsEnabled = Class.Variables.enableButton.Contains("227") ? true : false;
            btC3L8.Opacity = !btC3L8.IsEnabled ? 0.5 : 1.0;

            //Bloco Botões Coluna 4
            btC4L1.Source = Class.Variables.btSelect[24] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[24] = !btC4L1.IsEnabled ? false : Class.Variables.btSelect[24];
            btC4L1.IsEnabled = Class.Variables.enableButton.Contains("230") ? true : false;
            btC4L1.Opacity = !btC4L1.IsEnabled ? 0.5 : 1.0;

            btC4L2.Source = Class.Variables.btSelect[25] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[25] = !btC4L2.IsEnabled ? false : Class.Variables.btSelect[25];
            btC4L2.IsEnabled = Class.Variables.enableButton.Contains("231") ? true : false;
            btC4L2.Opacity = !btC4L2.IsEnabled ? 0.5 : 1.0;

            btC4L3.Source = Class.Variables.btSelect[26] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[26] = !btC4L3.IsEnabled ? false : Class.Variables.btSelect[26];
            btC4L3.IsEnabled = Class.Variables.enableButton.Contains("232") ? true : false;
            btC4L3.Opacity = !btC4L3.IsEnabled ? 0.5 : 1.0;

            btC4L4.Source = Class.Variables.btSelect[27] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[27] = !btC4L4.IsEnabled ? false : Class.Variables.btSelect[27];
            btC4L4.IsEnabled = Class.Variables.enableButton.Contains("233") ? true : false;
            btC4L4.Opacity = !btC4L4.IsEnabled ? 0.5 : 1.0;

            btC4L5.Source = Class.Variables.btSelect[28] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[28] = !btC4L5.IsEnabled ? false : Class.Variables.btSelect[28];
            btC4L5.IsEnabled = Class.Variables.enableButton.Contains("234") ? true : false;
            btC4L5.Opacity = !btC4L5.IsEnabled ? 0.5 : 1.0;

            btC4L6.Source = Class.Variables.btSelect[29] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[29] = !btC4L6.IsEnabled ? false : Class.Variables.btSelect[29];
            btC4L6.IsEnabled = Class.Variables.enableButton.Contains("235") ? true : false;
            btC4L6.Opacity = !btC4L6.IsEnabled ? 0.5 : 1.0;

            btC4L7.Source = Class.Variables.btSelect[30] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[30] = !btC4L7.IsEnabled ? false : Class.Variables.btSelect[30];
            btC4L7.IsEnabled = Class.Variables.enableButton.Contains("236") ? true : false;
            btC4L7.Opacity = !btC4L7.IsEnabled ? 0.5 : 1.0;

            btC4L8.Source = Class.Variables.btSelect[31] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
            Class.Variables.btSelect[31] = !btC4L8.IsEnabled ? false : Class.Variables.btSelect[31];
            btC4L8.IsEnabled = Class.Variables.enableButton.Contains("237") ? true : false;
            btC4L8.Opacity = !btC4L8.IsEnabled ? 0.5 : 1.0;
        }

        private void updateTransition()
        {
            #region Coluna 1

            //C1L1 Registro da Ação
            if (Class.Variables.btSelect[0] != Class.Variables.btSelectTransition[0])
            {
                if (Class.Variables.btSelect[0]) { crud.InsertActions("IO_C1L1", "Enable", Class.Variables.watts_DB[0]); }
                if (!Class.Variables.btSelect[0]) { crud.InsertActions("IO_C1L1", "Disable", Class.Variables.watts_DB[0]); }

                Class.Variables.btSelectTransition[0] = Class.Variables.btSelect[0];
            }

            //C1L2 Registro da Ação
            if (Class.Variables.btSelect[1] != Class.Variables.btSelectTransition[1])
            {
                if (Class.Variables.btSelect[1]) { crud.InsertActions("IO_C1L2", "Enable", Class.Variables.watts_DB[1]); }
                if (!Class.Variables.btSelect[1]) { crud.InsertActions("IO_C1L2", "Disable", Class.Variables.watts_DB[1]); }

                Class.Variables.btSelectTransition[1] = Class.Variables.btSelect[1];
            }

            //C1L3 Registro da Ação
            if (Class.Variables.btSelect[2] != Class.Variables.btSelectTransition[2])
            {
                if (Class.Variables.btSelect[2]) { crud.InsertActions("IO_C1L3", "Enable", Class.Variables.watts_DB[2]); }
                if (!Class.Variables.btSelect[2]) { crud.InsertActions("IO_C1L3", "Disable", Class.Variables.watts_DB[2]); }

                Class.Variables.btSelectTransition[2] = Class.Variables.btSelect[2];
            }

            //C1L4 Registro da Ação
            if (Class.Variables.btSelect[3] != Class.Variables.btSelectTransition[3])
            {
                if (Class.Variables.btSelect[3]) { crud.InsertActions("IO_C1L4", "Enable", Class.Variables.watts_DB[3]); }
                if (!Class.Variables.btSelect[3]) { crud.InsertActions("IO_C1L4", "Disable", Class.Variables.watts_DB[3]); }

                Class.Variables.btSelectTransition[3] = Class.Variables.btSelect[3];
            }

            //C1L5 Registro da Ação
            if (Class.Variables.btSelect[4] != Class.Variables.btSelectTransition[4])
            {
                if (Class.Variables.btSelect[4]) { crud.InsertActions("IO_C1L5", "Enable", Class.Variables.watts_DB[4]); }
                if (!Class.Variables.btSelect[4]) { crud.InsertActions("IO_C1L5", "Disable", Class.Variables.watts_DB[4]); }

                Class.Variables.btSelectTransition[4] = Class.Variables.btSelect[4];
            }

            //C1L6 Registro da Ação
            if (Class.Variables.btSelect[5] != Class.Variables.btSelectTransition[5])
            {
                if (Class.Variables.btSelect[5]) { crud.InsertActions("IO_C1L6", "Enable", Class.Variables.watts_DB[5]); }
                if (!Class.Variables.btSelect[5]) { crud.InsertActions("IO_C1L6", "Disable", Class.Variables.watts_DB[5]); }

                Class.Variables.btSelectTransition[5] = Class.Variables.btSelect[5];
            }

            //C1L7 Registro da Ação
            if (Class.Variables.btSelect[6] != Class.Variables.btSelectTransition[6])
            {
                if (Class.Variables.btSelect[6]) { crud.InsertActions("IO_C1L7", "Enable", Class.Variables.watts_DB[6]); }
                if (!Class.Variables.btSelect[6]) { crud.InsertActions("IO_C1L7", "Disable", Class.Variables.watts_DB[6]); }

                Class.Variables.btSelectTransition[6] = Class.Variables.btSelect[6];
            }

            //C1L8 Registro da Ação
            if (Class.Variables.btSelect[7] != Class.Variables.btSelectTransition[7])
            {
                if (Class.Variables.btSelect[7]) { crud.InsertActions("IO_C1L8", "Enable", Class.Variables.watts_DB[7]); }
                if (!Class.Variables.btSelect[7]) { crud.InsertActions("IO_C1L8", "Disable", Class.Variables.watts_DB[7]); }

                Class.Variables.btSelectTransition[7] = Class.Variables.btSelect[7];
            }

            #endregion

            #region Coluna 2

            //C2L1 Registro da Ação
            if (Class.Variables.btSelect[8] != Class.Variables.btSelectTransition[8])
            {
                if (Class.Variables.btSelect[8]) { crud.InsertActions("IO_C2L1", "Enable", Class.Variables.watts_DB[8]); }
                if (!Class.Variables.btSelect[8]) { crud.InsertActions("IO_C2L1", "Disable", Class.Variables.watts_DB[8]); }

                Class.Variables.btSelectTransition[8] = Class.Variables.btSelect[8];
            }

            //C2L2 Registro da Ação
            if (Class.Variables.btSelect[9] != Class.Variables.btSelectTransition[9])
            {
                if (Class.Variables.btSelect[9]) { crud.InsertActions("IO_C2L2", "Enable", Class.Variables.watts_DB[9]); }
                if (!Class.Variables.btSelect[9]) { crud.InsertActions("IO_C2L2", "Disable", Class.Variables.watts_DB[9]); }

                Class.Variables.btSelectTransition[9] = Class.Variables.btSelect[9];
            }

            //C2L3 Registro da Ação
            if (Class.Variables.btSelect[10] != Class.Variables.btSelectTransition[10])
            {
                if (Class.Variables.btSelect[10]) { crud.InsertActions("IO_C2L3", "Enable", Class.Variables.watts_DB[10]); }
                if (!Class.Variables.btSelect[10]) { crud.InsertActions("IO_C2L3", "Disable", Class.Variables.watts_DB[10]); }

                Class.Variables.btSelectTransition[10] = Class.Variables.btSelect[10];
            }

            //C2L4 Registro da Ação
            if (Class.Variables.btSelect[11] != Class.Variables.btSelectTransition[11])
            {
                if (Class.Variables.btSelect[11]) { crud.InsertActions("IO_C2L4", "Enable", Class.Variables.watts_DB[11]); }
                if (!Class.Variables.btSelect[11]) { crud.InsertActions("IO_C2L4", "Disable", Class.Variables.watts_DB[11]); }

                Class.Variables.btSelectTransition[11] = Class.Variables.btSelect[11];
            }

            //C2L5 Registro da Ação
            if (Class.Variables.btSelect[12] != Class.Variables.btSelectTransition[12])
            {
                if (Class.Variables.btSelect[12]) { crud.InsertActions("IO_C2L5", "Enable", Class.Variables.watts_DB[12]); }
                if (!Class.Variables.btSelect[12]) { crud.InsertActions("IO_C2L5", "Disable", Class.Variables.watts_DB[12]); }

                Class.Variables.btSelectTransition[12] = Class.Variables.btSelect[12];
            }

            //C2L6 Registro da Ação
            if (Class.Variables.btSelect[13] != Class.Variables.btSelectTransition[13])
            {
                if (Class.Variables.btSelect[13]) { crud.InsertActions("IO_C2L6", "Enable", Class.Variables.watts_DB[13]); }
                if (!Class.Variables.btSelect[13]) { crud.InsertActions("IO_C2L6", "Disable", Class.Variables.watts_DB[13]); }

                Class.Variables.btSelectTransition[13] = Class.Variables.btSelect[13];
            }

            //C2L7 Registro da Ação
            if (Class.Variables.btSelect[14] != Class.Variables.btSelectTransition[14])
            {
                if (Class.Variables.btSelect[14]) { crud.InsertActions("IO_C2L7", "Enable", Class.Variables.watts_DB[14]); }
                if (!Class.Variables.btSelect[14]) { crud.InsertActions("IO_C2L7", "Disable", Class.Variables.watts_DB[14]); }

                Class.Variables.btSelectTransition[14] = Class.Variables.btSelect[14];
            }

            //C2L8 Registro da Ação
            if (Class.Variables.btSelect[15] != Class.Variables.btSelectTransition[15])
            {
                if (Class.Variables.btSelect[15]) { crud.InsertActions("IO_C2L8", "Enable", Class.Variables.watts_DB[15]); }
                if (!Class.Variables.btSelect[15]) { crud.InsertActions("IO_C2L8", "Disable", Class.Variables.watts_DB[15]); }

                Class.Variables.btSelectTransition[15] = Class.Variables.btSelect[15];
            }

            #endregion

            #region Coluna 3

            //C3L1 Registro da Ação
            if (Class.Variables.btSelect[16] != Class.Variables.btSelectTransition[16])
            {
                if (Class.Variables.btSelect[16]) { crud.InsertActions("IO_C3L1", "Enable", Class.Variables.watts_DB[16]); }
                if (!Class.Variables.btSelect[16]) { crud.InsertActions("IO_C3L1", "Disable", Class.Variables.watts_DB[16]); }

                Class.Variables.btSelectTransition[16] = Class.Variables.btSelect[16];
            }

            //C3L2 Registro da Ação
            if (Class.Variables.btSelect[17] != Class.Variables.btSelectTransition[17])
            {
                if (Class.Variables.btSelect[17]) { crud.InsertActions("IO_C3L2", "Enable", Class.Variables.watts_DB[17]); }
                if (!Class.Variables.btSelect[17]) { crud.InsertActions("IO_C3L2", "Disable", Class.Variables.watts_DB[17]); }

                Class.Variables.btSelectTransition[17] = Class.Variables.btSelect[17];
            }

            //C3L3 Registro da Ação
            if (Class.Variables.btSelect[18] != Class.Variables.btSelectTransition[18])
            {
                if (Class.Variables.btSelect[18]) { crud.InsertActions("IO_C3L3", "Enable", Class.Variables.watts_DB[18]); }
                if (!Class.Variables.btSelect[18]) { crud.InsertActions("IO_C3L3", "Disable", Class.Variables.watts_DB[18]); }

                Class.Variables.btSelectTransition[18] = Class.Variables.btSelect[18];
            }

            //C3L4 Registro da Ação
            if (Class.Variables.btSelect[19] != Class.Variables.btSelectTransition[19])
            {
                if (Class.Variables.btSelect[19]) { crud.InsertActions("IO_C3L4", "Enable", Class.Variables.watts_DB[19]); }
                if (!Class.Variables.btSelect[19]) { crud.InsertActions("IO_C3L4", "Disable", Class.Variables.watts_DB[19]); }

                Class.Variables.btSelectTransition[19] = Class.Variables.btSelect[19];
            }

            //C3L5 Registro da Ação
            if (Class.Variables.btSelect[20] != Class.Variables.btSelectTransition[20])
            {
                if (Class.Variables.btSelect[20]) { crud.InsertActions("IO_C3L5", "Enable", Class.Variables.watts_DB[20]); }
                if (!Class.Variables.btSelect[20]) { crud.InsertActions("IO_C3L5", "Disable", Class.Variables.watts_DB[20]); }

                Class.Variables.btSelectTransition[20] = Class.Variables.btSelect[20];
            }

            //C3L6 Registro da Ação
            if (Class.Variables.btSelect[21] != Class.Variables.btSelectTransition[21])
            {
                if (Class.Variables.btSelect[21]) { crud.InsertActions("IO_C3L6", "Enable", Class.Variables.watts_DB[21]); }
                if (!Class.Variables.btSelect[21]) { crud.InsertActions("IO_C3L6", "Disable", Class.Variables.watts_DB[21]); }

                Class.Variables.btSelectTransition[21] = Class.Variables.btSelect[21];
            }

            //C3L7 Registro da Ação
            if (Class.Variables.btSelect[22] != Class.Variables.btSelectTransition[22])
            {
                if (Class.Variables.btSelect[22]) { crud.InsertActions("IO_C3L7", "Enable", Class.Variables.watts_DB[22]); }
                if (!Class.Variables.btSelect[22]) { crud.InsertActions("IO_C3L7", "Disable", Class.Variables.watts_DB[22]); }

                Class.Variables.btSelectTransition[22] = Class.Variables.btSelect[22];
            }

            //C3L8 Registro da Ação
            if (Class.Variables.btSelect[23] != Class.Variables.btSelectTransition[23])
            {
                if (Class.Variables.btSelect[23]) { crud.InsertActions("IO_C3L8", "Enable", Class.Variables.watts_DB[23]); }
                if (!Class.Variables.btSelect[23]) { crud.InsertActions("IO_C3L8", "Disable", Class.Variables.watts_DB[23]); }

                Class.Variables.btSelectTransition[23] = Class.Variables.btSelect[23];
            }

            #endregion

            #region Coluna 4

            //C4L1 Registro da Ação
            if (Class.Variables.btSelect[24] != Class.Variables.btSelectTransition[24])
            {
                if (Class.Variables.btSelect[24]) { crud.InsertActions("IO_C4L1", "Enable", Class.Variables.watts_DB[24]); }
                if (!Class.Variables.btSelect[24]) { crud.InsertActions("IO_C4L1", "Disable", Class.Variables.watts_DB[24]); }

                Class.Variables.btSelectTransition[24] = Class.Variables.btSelect[24];
            }

            //C4L2 Registro da Ação
            if (Class.Variables.btSelect[25] != Class.Variables.btSelectTransition[25])
            {
                if (Class.Variables.btSelect[25]) { crud.InsertActions("IO_C4L2", "Enable", Class.Variables.watts_DB[25]); }
                if (!Class.Variables.btSelect[25]) { crud.InsertActions("IO_C4L2", "Disable", Class.Variables.watts_DB[25]); }

                Class.Variables.btSelectTransition[25] = Class.Variables.btSelect[25];
            }

            //C4L3 Registro da Ação
            if (Class.Variables.btSelect[26] != Class.Variables.btSelectTransition[26])
            {
                if (Class.Variables.btSelect[26]) { crud.InsertActions("IO_C4L3", "Enable", Class.Variables.watts_DB[26]); }
                if (!Class.Variables.btSelect[26]) { crud.InsertActions("IO_C4L3", "Disable", Class.Variables.watts_DB[26]); }

                Class.Variables.btSelectTransition[26] = Class.Variables.btSelect[26];
            }

            //C4L4 Registro da Ação
            if (Class.Variables.btSelect[27] != Class.Variables.btSelectTransition[27])
            {
                if (Class.Variables.btSelect[27]) { crud.InsertActions("IO_C4L4", "Enable", Class.Variables.watts_DB[27]); }
                if (!Class.Variables.btSelect[27]) { crud.InsertActions("IO_C4L4", "Disable", Class.Variables.watts_DB[27]); }

                Class.Variables.btSelectTransition[27] = Class.Variables.btSelect[27];
            }

            //C4L5 Registro da Ação
            if (Class.Variables.btSelect[28] != Class.Variables.btSelectTransition[28])
            {
                if (Class.Variables.btSelect[28]) { crud.InsertActions("IO_C4L5", "Enable", Class.Variables.watts_DB[28]); }
                if (!Class.Variables.btSelect[28]) { crud.InsertActions("IO_C4L5", "Disable", Class.Variables.watts_DB[28]); }

                Class.Variables.btSelectTransition[28] = Class.Variables.btSelect[28];
            }

            //C4L6 Registro da Ação
            if (Class.Variables.btSelect[29] != Class.Variables.btSelectTransition[29])
            {
                if (Class.Variables.btSelect[29]) { crud.InsertActions("IO_C4L6", "Enable", Class.Variables.watts_DB[29]); }
                if (!Class.Variables.btSelect[29]) { crud.InsertActions("IO_C4L6", "Disable", Class.Variables.watts_DB[29]); }

                Class.Variables.btSelectTransition[29] = Class.Variables.btSelect[29];
            }

            //C4L7 Registro da Ação
            if (Class.Variables.btSelect[30] != Class.Variables.btSelectTransition[30])
            {
                if (Class.Variables.btSelect[30]) { crud.InsertActions("IO_C4L7", "Enable", Class.Variables.watts_DB[30]); }
                if (!Class.Variables.btSelect[30]) { crud.InsertActions("IO_C4L7", "Disable", Class.Variables.watts_DB[30]); }

                Class.Variables.btSelectTransition[30] = Class.Variables.btSelect[30];
            }

            //C4L8 Registro da Ação
            if (Class.Variables.btSelect[31] != Class.Variables.btSelectTransition[31])
            {
                if (Class.Variables.btSelect[31]) { crud.InsertActions("IO_C4L8", "Enable", Class.Variables.watts_DB[31]); }
                if (!Class.Variables.btSelect[31]) { crud.InsertActions("IO_C4L8", "Disable", Class.Variables.watts_DB[31]); }

                Class.Variables.btSelectTransition[31] = Class.Variables.btSelect[31];
            }

            #endregion
        }

        #region Botões Coluna 1

        private void btC1L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[0] = !Class.Variables.btSelect[0];
        }

        private void btC1L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[1] = !Class.Variables.btSelect[1];
        }

        private void btC1L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[2] = !Class.Variables.btSelect[2];
        }

        private void btC1L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[3] = !Class.Variables.btSelect[3];
        }

        private void btC1L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[4] = !Class.Variables.btSelect[4];
        }

        private void btC1L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[5] = !Class.Variables.btSelect[5];
        }

        private void btC1L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[6] = !Class.Variables.btSelect[6];
        }

        private void btC1L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[7] = !Class.Variables.btSelect[7];
        }


        #endregion

        #region Botões Coluna 2

        private void btC2L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[8] = !Class.Variables.btSelect[8];
        }

        private void btC2L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[9] = !Class.Variables.btSelect[9];
        }

        private void btC2L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[10] = !Class.Variables.btSelect[10];
        }

        private void btC2L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[11] = !Class.Variables.btSelect[11];
        }

        private void btC2L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[12] = !Class.Variables.btSelect[12];
        }

        private void btC2L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[13] = !Class.Variables.btSelect[13];
        }

        private void btC2L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[14] = !Class.Variables.btSelect[14];
        }

        private void btC2L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[15] = !Class.Variables.btSelect[15];
        }

        #endregion

        #region Botões Coluna 3

        private void btC3L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[16] = !Class.Variables.btSelect[16];
        }

        private void btC3L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[17] = !Class.Variables.btSelect[17];
        }

        private void btC3L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[18] = !Class.Variables.btSelect[18];
        }

        private void btC3L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[19] = !Class.Variables.btSelect[19];
        }

        private void btC3L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[20] = !Class.Variables.btSelect[20];
        }

        private void btC3L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[21] = !Class.Variables.btSelect[21];
        }

        private void btC3L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[22] = !Class.Variables.btSelect[22];
        }

        private void btC3L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[23] = !Class.Variables.btSelect[23];
        }

        #endregion

        #region Botões Coluna 4

        private void btC4L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[24] = !Class.Variables.btSelect[24];
        }

        private void btC4L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[25] = !Class.Variables.btSelect[25];
        }

        private void btC4L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[26] = !Class.Variables.btSelect[26];
        }

        private void btC4L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[27] = !Class.Variables.btSelect[27];
        }

        private void btC4L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[28] = !Class.Variables.btSelect[28];
        }

        private void btC4L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[29] = !Class.Variables.btSelect[29];
        }

        private void btC4L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[30] = !Class.Variables.btSelect[30];
        }

        private void btC4L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[31] = !Class.Variables.btSelect[31];
        }


        #endregion

    }
}
