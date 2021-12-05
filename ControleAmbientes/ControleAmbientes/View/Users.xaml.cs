using System.Data;
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

        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtPassword.Password = "";
            txtPasswordConfirma.Password = "";
            seletorAdm.IsChecked = false;

            dataGridUsers.DataContext = crud.FillDataGrid();
        }

        private void Label_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtName.Text.Equals("") || txtLogin.Text.Equals(""))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] splitEmail = txtEmail.Text.Split('@');

            if (splitEmail.Length != 2)
            {
                MessageBox.Show("Email no formato inválido.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            crud.DeleteUser(txtEmail.Text);

            dataGridUsers.DataContext = crud.FillDataGrid();
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

            crud.SaveUser(txtEmail.Text, txtName.Text, txtLogin.Text, txtPasswordConfirma.Password.ToString(), seletorAdm.IsChecked.Value);

            dataGridUsers.DataContext = crud.FillDataGrid();

        }

        private void btLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView dataRow = (DataRowView)dataGridUsers.SelectedItem;
                string cellValue = dataRow.Row.ItemArray[1].ToString();

                string[] reLoadUser = new string[3];
                bool reLoadUserAdmin = false;
                reLoadUser[0] = cellValue;
                crud.ReloadUsers(ref reLoadUser[0], ref reLoadUser[1], ref reLoadUser[2], ref reLoadUserAdmin);

                txtName.Text = reLoadUser[1];
                txtEmail.Text = reLoadUser[0];
                txtLogin.Text = reLoadUser[2];
                seletorAdm.IsChecked = reLoadUserAdmin;
            }
            catch
            {
                MessageBox.Show("Nenhum Usuário selecionado.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

    }
}
