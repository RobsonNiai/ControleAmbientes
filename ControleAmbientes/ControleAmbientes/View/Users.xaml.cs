using System.Windows;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Users.xaml
    /// </summary>
    public partial class Users : Window
    {

        Class.CRUD crud = new Class.CRUD();

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
            crud.DeleteUser(txtEmail.Text);
        }

        private void btSalve_Click(object sender, RoutedEventArgs e)
        {
            

            if (txtEmail.Text.Equals("") || txtName.Text.Equals("") || txtLogin.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!txtPassword.Password.Equals(txtPasswordConfirma.Password) || txtPassword.Password.Equals("") || txtPasswordConfirma.Password.Equals(""))
            {
                MessageBox.Show("Falha no cadastro da Senha.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] splitEmail = txtEmail.Text.Split('@');

            if (splitEmail.Length != 2)
            {
                MessageBox.Show("Email no formato inválido.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            crud.SaveUser(txtEmail.Text, txtName.Text, txtLogin.Text, txtPasswordConfirma.Password.ToString());

        }
    }
}
