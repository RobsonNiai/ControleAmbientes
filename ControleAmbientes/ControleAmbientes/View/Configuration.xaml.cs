using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        public Configuration()
        {
            InitializeComponent();
        }

        #region Bloco IP do Arduino 

        private void txtFirstOcteto_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        { 
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtSecondOcteto_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtThirdOcteto_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtFourthOcteto_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtFirstOcteto_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(txtFirstOcteto.Text) > 255)
                {
                    MessageBox.Show("Permitido Valores entre 1 e 255", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtFirstOcteto.Text = "";
                }
            }
            catch { }

        }

        private void txtSecondOcteto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(txtSecondOcteto.Text) > 255)
                {
                    MessageBox.Show("Permitido Valores entre 1 e 255", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSecondOcteto.Text = "";
                }
            }
            catch { }
        }

        private void txtThirdOcteto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(txtThirdOcteto.Text) > 255)
                {
                    MessageBox.Show("Permitido Valores entre 1 e 255", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtThirdOcteto.Text = "";
                }
            }
            catch { }
        }

        private void txtFourthOcteto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (int.Parse(txtFourthOcteto.Text) > 255)
                {
                    MessageBox.Show("Permitido Valores entre 1 e 255", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtFourthOcteto.Text = "";
                }
            }
            catch { }
        }

        #endregion

    }
}
