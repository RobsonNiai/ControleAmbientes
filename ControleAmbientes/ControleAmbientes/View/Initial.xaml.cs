using System.Windows;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Initial : Window
    {
        Class.CRUD crud = new Class.CRUD();

        public Initial()
        {
            InitializeComponent();
        }

        private void login_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.userLoggin = crud.LoginUser(txtLogin.Text, txtPassword.Password, ref Class.Variables.admin) ? true : false;

            if (Class.Variables.userLoggin)
            {
                MessageBox.Show("Login efetuado com Sucesso.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Information);
                Class.Views.viewSelect.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Falha no Login/Senha.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtLogin.Clear();
            txtPassword.Clear();

        }
    }
}
