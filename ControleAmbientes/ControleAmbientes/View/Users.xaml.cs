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
    }
}
