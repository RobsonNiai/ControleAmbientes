using System.Windows;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Initial : Window
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void login_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Class.Variables.userLoggin = true;
        }
    }
}
