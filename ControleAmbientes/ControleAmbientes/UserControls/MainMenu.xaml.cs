using ControleAmbientes.Class;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ControleAmbientes.UserControls
{
    /// <summary>
    /// Interação lógica para MainMenu.xam
    /// </summary>
    public partial class MainMenu : UserControl
    {

        public MainMenu()
        {
            InitializeComponent();

            if (Class.Variables.userLoggin)
            {
                changeColor();
            }
        }

        //Botão Sair da Aplicação
        private void btExit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação", "! ! ! Atenção ! ! !", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        //Botão Tela Seleção
        private void btSelect_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Class.Variables.userLoggin)
            {
                Views.viewSelect.Visibility = Visibility.Visible;
                Views.viewConfiguration.Visibility = Visibility.Hidden;
                Views.viewReports.Visibility = Visibility.Hidden;
                Views.viewUsers.Visibility = Visibility.Hidden;
            }
        }

        //Botão Tela Configuração
        private void btConfig_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Class.Variables.userLoggin)
            {
                Views.viewConfiguration.Visibility = Visibility.Visible;
                Views.viewSelect.Visibility = Visibility.Hidden;
                Views.viewReports.Visibility = Visibility.Hidden;
                Views.viewUsers.Visibility = Visibility.Hidden;
            }
        }

        //Botão Tela Relatorios
        private void btReport_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Class.Variables.userLoggin)
            {
                Views.viewReports.Visibility = Visibility.Visible;
                Views.viewSelect.Visibility = Visibility.Hidden;
                Views.viewConfiguration.Visibility = Visibility.Hidden;
                Views.viewUsers.Visibility = Visibility.Hidden;
            }
        }

        //Botão Tela Usuarios
        private void btUsers_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Class.Variables.userLoggin)
            {
                Views.viewUsers.Visibility = Visibility.Visible;
                Views.viewUsers.ShowDialog();
            }
        }

        private void changeColor()
        {
            Uri fileUri_A = new Uri("/Img/btSelectColor.png", UriKind.Relative);
            btSelect.Source = new BitmapImage(fileUri_A);

            Uri fileUri_B = new Uri("/Img/btConfigColor.png", UriKind.Relative);
            btConfig.Source = new BitmapImage(fileUri_B);

            Uri fileUri_C = new Uri("/Img/btReportColor.png", UriKind.Relative);
            btReport.Source = new BitmapImage(fileUri_C);

            Uri fileUri_D = new Uri("/Img/btUserColor.png", UriKind.Relative);
            btUsers.Source = new BitmapImage(fileUri_D);

            Uri fileUri_E = new Uri("/Img/HeaderGreen.png", UriKind.Relative);
            header.Source = new BitmapImage(fileUri_E);
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (Class.Variables.userLoggin)
            {
                Views.viewUsers.Visibility = Visibility.Hidden;
                Views.viewSelect.Visibility = Visibility.Hidden;
                Views.viewConfiguration.Visibility = Visibility.Hidden;
                Views.viewReports.Visibility = Visibility.Hidden;

                Class.Variables.userLoggin = false;
            }
        }

    }
}
