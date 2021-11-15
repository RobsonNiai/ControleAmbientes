using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Select.xaml
    /// </summary>
    public partial class Select : Window
    {
        Uri fileUriOn = new Uri("/Img/btON.png", UriKind.Relative);
        Uri fileUriOFF = new Uri("/Img/btOFF.png", UriKind.Relative);

        public Select()
        {
            InitializeComponent();
        }

        #region Botões Coluna 1

        private void btC1L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[0] = !Class.Variables.btSelect[0];
            btC1L1.Source = Class.Variables.btSelect[0] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[1] = !Class.Variables.btSelect[1];
            btC1L2.Source = Class.Variables.btSelect[1] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[2] = !Class.Variables.btSelect[2];
            btC1L3.Source = Class.Variables.btSelect[2] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[3] = !Class.Variables.btSelect[3];
            btC1L4.Source = Class.Variables.btSelect[3] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[4] = !Class.Variables.btSelect[4];
            btC1L5.Source = Class.Variables.btSelect[4] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[5] = !Class.Variables.btSelect[5];
            btC1L6.Source = Class.Variables.btSelect[5] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[6] = !Class.Variables.btSelect[6];
            btC1L7.Source = Class.Variables.btSelect[6] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC1L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[7] = !Class.Variables.btSelect[7];
            btC1L8.Source = Class.Variables.btSelect[7] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }


        #endregion

        #region Botões Coluna 2

        private void btC2L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[8] = !Class.Variables.btSelect[8];
            btC2L1.Source = Class.Variables.btSelect[8] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[9] = !Class.Variables.btSelect[9];
            btC2L2.Source = Class.Variables.btSelect[9] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[10] = !Class.Variables.btSelect[10];
            btC2L3.Source = Class.Variables.btSelect[10] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[11] = !Class.Variables.btSelect[11];
            btC2L4.Source = Class.Variables.btSelect[11] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[12] = !Class.Variables.btSelect[12];
            btC2L5.Source = Class.Variables.btSelect[12] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[13] = !Class.Variables.btSelect[13];
            btC2L6.Source = Class.Variables.btSelect[13] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[14] = !Class.Variables.btSelect[14];
            btC2L7.Source = Class.Variables.btSelect[14] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC2L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[15] = !Class.Variables.btSelect[15];
            btC2L8.Source = Class.Variables.btSelect[15] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        #endregion

        #region Botões Coluna 3

        private void btC3L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[16] = !Class.Variables.btSelect[16];
            btC3L1.Source = Class.Variables.btSelect[16] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[17] = !Class.Variables.btSelect[17];
            btC3L2.Source = Class.Variables.btSelect[17] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[18] = !Class.Variables.btSelect[18];
            btC3L3.Source = Class.Variables.btSelect[18] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[19] = !Class.Variables.btSelect[19];
            btC3L4.Source = Class.Variables.btSelect[19] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[20] = !Class.Variables.btSelect[20];
            btC3L5.Source = Class.Variables.btSelect[20] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[21] = !Class.Variables.btSelect[21];
            btC3L6.Source = Class.Variables.btSelect[21] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[22] = !Class.Variables.btSelect[22];
            btC3L7.Source = Class.Variables.btSelect[22] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC3L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[23] = !Class.Variables.btSelect[23];
            btC3L8.Source = Class.Variables.btSelect[23] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        #endregion

        #region Botões Coluna 4

        private void btC4L1_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[24] = !Class.Variables.btSelect[24];
            btC4L1.Source = Class.Variables.btSelect[24] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L2_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[25] = !Class.Variables.btSelect[25];
            btC4L2.Source = Class.Variables.btSelect[25] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L3_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[26] = !Class.Variables.btSelect[26];
            btC4L3.Source = Class.Variables.btSelect[26] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L4_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[27] = !Class.Variables.btSelect[27];
            btC4L4.Source = Class.Variables.btSelect[27] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L5_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[28] = !Class.Variables.btSelect[28];
            btC4L5.Source = Class.Variables.btSelect[28] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L6_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[29] = !Class.Variables.btSelect[29];
            btC4L6.Source = Class.Variables.btSelect[29] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L7_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[30] = !Class.Variables.btSelect[30];
            btC4L7.Source = Class.Variables.btSelect[30] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        private void btC4L8_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.btSelect[31] = !Class.Variables.btSelect[31];
            btC4L8.Source = Class.Variables.btSelect[31] ? new BitmapImage(fileUriOn) : new BitmapImage(fileUriOFF);
        }

        #endregion
    }
}
