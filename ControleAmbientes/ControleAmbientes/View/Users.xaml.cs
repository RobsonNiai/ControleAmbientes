using System.Windows;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Label_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btSalve_Click(object sender, RoutedEventArgs e)
        {
            if (!txtPassword.Password.Equals(txtPasswordConfirma.Password) || txtPassword.Password.Equals("") || txtPasswordConfirma.Password.Equals(""))
            {
                MessageBox.Show("Falha no cadastro da Senha", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
