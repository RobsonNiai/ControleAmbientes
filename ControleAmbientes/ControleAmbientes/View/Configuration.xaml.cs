using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        DispatcherTimer timerUpdateValues = new DispatcherTimer();

        public Configuration()
        {
            InitializeComponent();
            timerUpdateValues.Interval = System.TimeSpan.FromMilliseconds(250);
            timerUpdateValues.Tick += TimerUpdateValues_Tick;
            timerUpdateValues.Start();
        }

        private void TimerUpdateValues_Tick(object sender, System.EventArgs e)
        {
            UpdateCombosTextsBlock_A();
            UpdateCombosTextsBlock_B();
            UpdateCombosTextsBlock_C();
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

        #region Bloco A - Watts
        private void txtWats_A0_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A1_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A2_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A3_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A4_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A5_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A6_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A7_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }


        #endregion

        #region Bloco B - Watts
        private void txtWats_A8_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A9_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A10_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A11_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A12_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A13_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A14_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_A15_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }


        #endregion

        #region Bloco C - Watts
        private void txtWats_2_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_3_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_4_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_5_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_6_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_7_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_8_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_9_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }


        #endregion

        #region Bloco D - Watts
        private void txtWats_22_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_23_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_24_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_25_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_26_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_27_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_28_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_29_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_30_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_31_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_32_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_33_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_34_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_35_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_36_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_37_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_38_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_39_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_40_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_41_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_42_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_43_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_44_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_45_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_46_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_47_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_48_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_49_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_50_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        private void txtWats_51_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]");
        }

        #endregion

        private void UpdateCombosTextsBlock_A()
        {
            comboColA0.IsEnabled = !comboTypeA0.SelectedIndex.Equals(0) ? true : false;
            comboColA0.SelectedIndex = comboTypeA0.SelectedIndex.Equals(0) ? -1 : comboColA0.SelectedIndex;
            comboRowA0.IsEnabled = !comboTypeA0.SelectedIndex.Equals(0) ? true : false;
            comboRowA0.SelectedIndex = comboTypeA0.SelectedIndex.Equals(0) ? -1 : comboRowA0.SelectedIndex;
            txtWats_A0.IsEnabled = comboTypeA0.SelectedIndex.Equals(2) ? true : false;
            txtWats_A0.Text = comboTypeA0.SelectedIndex.Equals(2) ? txtWats_A0.Text : null;

            comboColA1.IsEnabled = !comboTypeA1.SelectedIndex.Equals(0) ? true : false;
            comboColA1.SelectedIndex = comboTypeA1.SelectedIndex.Equals(0) ? -1 : comboColA1.SelectedIndex;
            comboRowA1.IsEnabled = !comboTypeA1.SelectedIndex.Equals(0) ? true : false;
            comboRowA1.SelectedIndex = comboTypeA1.SelectedIndex.Equals(0) ? -1 : comboRowA1.SelectedIndex;
            txtWats_A1.IsEnabled = comboTypeA1.SelectedIndex.Equals(2) ? true : false;
            txtWats_A1.Text = comboTypeA1.SelectedIndex.Equals(2) ? txtWats_A1.Text : null;

            comboColA2.IsEnabled = !comboTypeA2.SelectedIndex.Equals(0) ? true : false;
            comboColA2.SelectedIndex = comboTypeA2.SelectedIndex.Equals(0) ? -1 : comboColA2.SelectedIndex;
            comboRowA2.IsEnabled = !comboTypeA2.SelectedIndex.Equals(0) ? true : false;
            comboRowA2.SelectedIndex = comboTypeA2.SelectedIndex.Equals(0) ? -1 : comboRowA2.SelectedIndex;
            txtWats_A2.IsEnabled = comboTypeA2.SelectedIndex.Equals(2) ? true : false;
            txtWats_A2.Text = comboTypeA2.SelectedIndex.Equals(2) ? txtWats_A2.Text : null;

            comboColA3.IsEnabled = !comboTypeA3.SelectedIndex.Equals(0) ? true : false;
            comboColA3.SelectedIndex = comboTypeA3.SelectedIndex.Equals(0) ? -1 : comboColA3.SelectedIndex;
            comboRowA3.IsEnabled = !comboTypeA3.SelectedIndex.Equals(0) ? true : false;
            comboRowA3.SelectedIndex = comboTypeA3.SelectedIndex.Equals(0) ? -1 : comboRowA3.SelectedIndex;
            txtWats_A3.IsEnabled = comboTypeA3.SelectedIndex.Equals(2) ? true : false;
            txtWats_A3.Text = comboTypeA3.SelectedIndex.Equals(2) ? txtWats_A3.Text : null;

            comboColA4.IsEnabled = !comboTypeA4.SelectedIndex.Equals(0) ? true : false;
            comboColA4.SelectedIndex = comboTypeA4.SelectedIndex.Equals(0) ? -1 : comboColA4.SelectedIndex;
            comboRowA4.IsEnabled = !comboTypeA4.SelectedIndex.Equals(0) ? true : false;
            comboRowA4.SelectedIndex = comboTypeA4.SelectedIndex.Equals(0) ? -1 : comboRowA4.SelectedIndex;
            txtWats_A4.IsEnabled = comboTypeA4.SelectedIndex.Equals(2) ? true : false;
            txtWats_A4.Text = comboTypeA4.SelectedIndex.Equals(2) ? txtWats_A4.Text : null;

            comboColA5.IsEnabled = !comboTypeA5.SelectedIndex.Equals(0) ? true : false;
            comboColA5.SelectedIndex = comboTypeA5.SelectedIndex.Equals(0) ? -1 : comboColA5.SelectedIndex;
            comboRowA5.IsEnabled = !comboTypeA5.SelectedIndex.Equals(0) ? true : false;
            comboRowA5.SelectedIndex = comboTypeA5.SelectedIndex.Equals(0) ? -1 : comboRowA5.SelectedIndex;
            txtWats_A5.IsEnabled = comboTypeA5.SelectedIndex.Equals(2) ? true : false;
            txtWats_A5.Text = comboTypeA5.SelectedIndex.Equals(2) ? txtWats_A5.Text : null;

            comboColA6.IsEnabled = !comboTypeA6.SelectedIndex.Equals(0) ? true : false;
            comboColA6.SelectedIndex = comboTypeA6.SelectedIndex.Equals(0) ? -1 : comboColA6.SelectedIndex;
            comboRowA6.IsEnabled = !comboTypeA6.SelectedIndex.Equals(0) ? true : false;
            comboRowA6.SelectedIndex = comboTypeA6.SelectedIndex.Equals(0) ? -1 : comboRowA6.SelectedIndex;
            txtWats_A6.IsEnabled = comboTypeA6.SelectedIndex.Equals(2) ? true : false;
            txtWats_A6.Text = comboTypeA6.SelectedIndex.Equals(2) ? txtWats_A6.Text : null;

            comboColA7.IsEnabled = !comboTypeA7.SelectedIndex.Equals(0) ? true : false;
            comboColA7.SelectedIndex = comboTypeA7.SelectedIndex.Equals(0) ? -1 : comboColA7.SelectedIndex;
            comboRowA7.IsEnabled = !comboTypeA7.SelectedIndex.Equals(0) ? true : false;
            comboRowA7.SelectedIndex = comboTypeA7.SelectedIndex.Equals(0) ? -1 : comboRowA7.SelectedIndex;
            txtWats_A7.IsEnabled = comboTypeA7.SelectedIndex.Equals(2) ? true : false;
            txtWats_A7.Text = comboTypeA7.SelectedIndex.Equals(2) ? txtWats_A7.Text : null;
        }

        private void UpdateCombosTextsBlock_B()
        {
            comboColA8.IsEnabled = !comboTypeA8.SelectedIndex.Equals(0) ? true : false;
            comboColA8.SelectedIndex = comboTypeA8.SelectedIndex.Equals(0) ? -1 : comboColA8.SelectedIndex;
            comboRowA8.IsEnabled = !comboTypeA8.SelectedIndex.Equals(0) ? true : false;
            comboRowA8.SelectedIndex = comboTypeA8.SelectedIndex.Equals(0) ? -1 : comboRowA8.SelectedIndex;
            txtWats_A8.IsEnabled = comboTypeA8.SelectedIndex.Equals(2) ? true : false;
            txtWats_A8.Text = comboTypeA8.SelectedIndex.Equals(2) ? txtWats_A8.Text : null;

            comboColA9.IsEnabled = !comboTypeA9.SelectedIndex.Equals(0) ? true : false;
            comboColA9.SelectedIndex = comboTypeA9.SelectedIndex.Equals(0) ? -1 : comboColA9.SelectedIndex;
            comboRowA9.IsEnabled = !comboTypeA9.SelectedIndex.Equals(0) ? true : false;
            comboRowA9.SelectedIndex = comboTypeA9.SelectedIndex.Equals(0) ? -1 : comboRowA9.SelectedIndex;
            txtWats_A9.IsEnabled = comboTypeA9.SelectedIndex.Equals(2) ? true : false;
            txtWats_A9.Text = comboTypeA9.SelectedIndex.Equals(2) ? txtWats_A9.Text : null;

            comboColA10.IsEnabled = !comboTypeA10.SelectedIndex.Equals(0) ? true : false;
            comboColA10.SelectedIndex = comboTypeA10.SelectedIndex.Equals(0) ? -1 : comboColA10.SelectedIndex;
            comboRowA10.IsEnabled = !comboTypeA10.SelectedIndex.Equals(0) ? true : false;
            comboRowA10.SelectedIndex = comboTypeA10.SelectedIndex.Equals(0) ? -1 : comboRowA10.SelectedIndex;
            txtWats_A10.IsEnabled = comboTypeA10.SelectedIndex.Equals(2) ? true : false;
            txtWats_A10.Text = comboTypeA10.SelectedIndex.Equals(2) ? txtWats_A10.Text : null;

            comboColA11.IsEnabled = !comboTypeA11.SelectedIndex.Equals(0) ? true : false;
            comboColA11.SelectedIndex = comboTypeA11.SelectedIndex.Equals(0) ? -1 : comboColA11.SelectedIndex;
            comboRowA11.IsEnabled = !comboTypeA11.SelectedIndex.Equals(0) ? true : false;
            comboRowA11.SelectedIndex = comboTypeA11.SelectedIndex.Equals(0) ? -1 : comboRowA11.SelectedIndex;
            txtWats_A11.IsEnabled = comboTypeA11.SelectedIndex.Equals(2) ? true : false;
            txtWats_A11.Text = comboTypeA11.SelectedIndex.Equals(2) ? txtWats_A11.Text : null;

            comboColA12.IsEnabled = !comboTypeA12.SelectedIndex.Equals(0) ? true : false;
            comboColA12.SelectedIndex = comboTypeA12.SelectedIndex.Equals(0) ? -1 : comboColA12.SelectedIndex;
            comboRowA12.IsEnabled = !comboTypeA12.SelectedIndex.Equals(0) ? true : false;
            comboRowA12.SelectedIndex = comboTypeA12.SelectedIndex.Equals(0) ? -1 : comboRowA12.SelectedIndex;
            txtWats_A12.IsEnabled = comboTypeA12.SelectedIndex.Equals(2) ? true : false;
            txtWats_A12.Text = comboTypeA12.SelectedIndex.Equals(2) ? txtWats_A12.Text : null;

            comboColA13.IsEnabled = !comboTypeA13.SelectedIndex.Equals(0) ? true : false;
            comboColA13.SelectedIndex = comboTypeA13.SelectedIndex.Equals(0) ? -1 : comboColA13.SelectedIndex;
            comboRowA13.IsEnabled = !comboTypeA13.SelectedIndex.Equals(0) ? true : false;
            comboRowA13.SelectedIndex = comboTypeA13.SelectedIndex.Equals(0) ? -1 : comboRowA13.SelectedIndex;
            txtWats_A13.IsEnabled = comboTypeA13.SelectedIndex.Equals(2) ? true : false;
            txtWats_A13.Text = comboTypeA13.SelectedIndex.Equals(2) ? txtWats_A13.Text : null;

            comboColA14.IsEnabled = !comboTypeA14.SelectedIndex.Equals(0) ? true : false;
            comboColA14.SelectedIndex = comboTypeA14.SelectedIndex.Equals(0) ? -1 : comboColA14.SelectedIndex;
            comboRowA14.IsEnabled = !comboTypeA14.SelectedIndex.Equals(0) ? true : false;
            comboRowA14.SelectedIndex = comboTypeA14.SelectedIndex.Equals(0) ? -1 : comboRowA14.SelectedIndex;
            txtWats_A14.IsEnabled = comboTypeA14.SelectedIndex.Equals(2) ? true : false;
            txtWats_A14.Text = comboTypeA14.SelectedIndex.Equals(2) ? txtWats_A14.Text : null;

            comboColA15.IsEnabled = !comboTypeA15.SelectedIndex.Equals(0) ? true : false;
            comboColA15.SelectedIndex = comboTypeA15.SelectedIndex.Equals(0) ? -1 : comboColA15.SelectedIndex;
            comboRowA15.IsEnabled = !comboTypeA15.SelectedIndex.Equals(0) ? true : false;
            comboRowA15.SelectedIndex = comboTypeA15.SelectedIndex.Equals(0) ? -1 : comboRowA15.SelectedIndex;
            txtWats_A15.IsEnabled = comboTypeA15.SelectedIndex.Equals(2) ? true : false;
            txtWats_A15.Text = comboTypeA15.SelectedIndex.Equals(2) ? txtWats_A15.Text : null;
        }

        private void UpdateCombosTextsBlock_C()
        {
            comboCol2.IsEnabled = !comboType2.SelectedIndex.Equals(0) ? true : false;
            comboCol2.SelectedIndex = comboType2.SelectedIndex.Equals(0) ? -1 : comboCol2.SelectedIndex;
            comboRow2.IsEnabled = !comboType2.SelectedIndex.Equals(0) ? true : false;
            comboRow2.SelectedIndex = comboType2.SelectedIndex.Equals(0) ? -1 : comboRow2.SelectedIndex;
            txtWats_2.IsEnabled = comboType2.SelectedIndex.Equals(2) ? true : false;
            txtWats_2.Text = comboType2.SelectedIndex.Equals(2) ? txtWats_2.Text : null;

            comboCol3.IsEnabled = !comboType3.SelectedIndex.Equals(0) ? true : false;
            comboCol3.SelectedIndex = comboType3.SelectedIndex.Equals(0) ? -1 : comboCol3.SelectedIndex;
            comboRow3.IsEnabled = !comboType3.SelectedIndex.Equals(0) ? true : false;
            comboRow3.SelectedIndex = comboType3.SelectedIndex.Equals(0) ? -1 : comboRow3.SelectedIndex;
            txtWats_3.IsEnabled = comboType3.SelectedIndex.Equals(2) ? true : false;
            txtWats_3.Text = comboType3.SelectedIndex.Equals(2) ? txtWats_3.Text : null;

            comboCol4.IsEnabled = !comboType4.SelectedIndex.Equals(0) ? true : false;
            comboCol4.SelectedIndex = comboType4.SelectedIndex.Equals(0) ? -1 : comboCol4.SelectedIndex;
            comboRow4.IsEnabled = !comboType4.SelectedIndex.Equals(0) ? true : false;
            comboRow4.SelectedIndex = comboType4.SelectedIndex.Equals(0) ? -1 : comboRow4.SelectedIndex;
            txtWats_4.IsEnabled = comboType4.SelectedIndex.Equals(2) ? true : false;
            txtWats_4.Text = comboType4.SelectedIndex.Equals(2) ? txtWats_4.Text : null;

            comboCol5.IsEnabled = !comboType5.SelectedIndex.Equals(0) ? true : false;
            comboCol5.SelectedIndex = comboType5.SelectedIndex.Equals(0) ? -1 : comboCol5.SelectedIndex;
            comboRow5.IsEnabled = !comboType5.SelectedIndex.Equals(0) ? true : false;
            comboRow5.SelectedIndex = comboType5.SelectedIndex.Equals(0) ? -1 : comboRow5.SelectedIndex;
            txtWats_5.IsEnabled = comboType5.SelectedIndex.Equals(2) ? true : false;
            txtWats_5.Text = comboType5.SelectedIndex.Equals(2) ? txtWats_5.Text : null;

            comboCol6.IsEnabled = !comboType6.SelectedIndex.Equals(0) ? true : false;
            comboCol6.SelectedIndex = comboType6.SelectedIndex.Equals(0) ? -1 : comboCol6.SelectedIndex;
            comboRow6.IsEnabled = !comboType6.SelectedIndex.Equals(0) ? true : false;
            comboRow6.SelectedIndex = comboType6.SelectedIndex.Equals(0) ? -1 : comboRow6.SelectedIndex;
            txtWats_6.IsEnabled = comboType6.SelectedIndex.Equals(2) ? true : false;
            txtWats_6.Text = comboType6.SelectedIndex.Equals(2) ? txtWats_6.Text : null;

            comboCol7.IsEnabled = !comboType7.SelectedIndex.Equals(0) ? true : false;
            comboCol7.SelectedIndex = comboType7.SelectedIndex.Equals(0) ? -1 : comboCol7.SelectedIndex;
            comboRow7.IsEnabled = !comboType7.SelectedIndex.Equals(0) ? true : false;
            comboRow7.SelectedIndex = comboType7.SelectedIndex.Equals(0) ? -1 : comboRow7.SelectedIndex;
            txtWats_7.IsEnabled = comboType7.SelectedIndex.Equals(2) ? true : false;
            txtWats_7.Text = comboType7.SelectedIndex.Equals(2) ? txtWats_7.Text : null;

            comboCol8.IsEnabled = !comboType8.SelectedIndex.Equals(0) ? true : false;
            comboCol8.SelectedIndex = comboType8.SelectedIndex.Equals(0) ? -1 : comboCol8.SelectedIndex;
            comboRow8.IsEnabled = !comboType8.SelectedIndex.Equals(0) ? true : false;
            comboRow8.SelectedIndex = comboType8.SelectedIndex.Equals(0) ? -1 : comboRow8.SelectedIndex;
            txtWats_8.IsEnabled = comboType8.SelectedIndex.Equals(2) ? true : false;
            txtWats_8.Text = comboType8.SelectedIndex.Equals(2) ? txtWats_8.Text : null;

            comboCol9.IsEnabled = !comboType9.SelectedIndex.Equals(0) ? true : false;
            comboCol9.SelectedIndex = comboType9.SelectedIndex.Equals(0) ? -1 : comboCol9.SelectedIndex;
            comboRow9.IsEnabled = !comboType9.SelectedIndex.Equals(0) ? true : false;
            comboRow9.SelectedIndex = comboType9.SelectedIndex.Equals(0) ? -1 : comboRow9.SelectedIndex;
            txtWats_9.IsEnabled = comboType9.SelectedIndex.Equals(2) ? true : false;
            txtWats_9.Text = comboType9.SelectedIndex.Equals(2) ? txtWats_9.Text : null;
        }

    }
}
