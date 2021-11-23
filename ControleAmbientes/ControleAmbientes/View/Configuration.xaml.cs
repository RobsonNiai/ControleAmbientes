using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        DispatcherTimer timerUpdateValues = new DispatcherTimer();
        Class.CRUD crud = new Class.CRUD();

        public Configuration()
        {
            InitializeComponent();
            timerUpdateValues.Interval = System.TimeSpan.FromMilliseconds(500);
            timerUpdateValues.Tick += TimerUpdateValues_Tick;
            timerUpdateValues.Start();
        }

        private void TimerUpdateValues_Tick(object sender, System.EventArgs e)
        {
            UpdateCombosTextsBlock_A();
            UpdateCombosTextsBlock_B();
            UpdateCombosTextsBlock_C();
            UpdateCombosTextsBlock_D();
        }

        #region Block IP Arduino 

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

        #region Block A - Watts
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

        #region Block B - Watts
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

        #region Block C - Watts
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

        #region Block D - Watts
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

        private void UpdateCombosTextsBlock_D()
        {
            #region 22 a 31

            comboCol22.IsEnabled = !comboType22.SelectedIndex.Equals(0) ? true : false;
            comboCol22.SelectedIndex = comboType22.SelectedIndex.Equals(0) ? -1 : comboCol22.SelectedIndex;
            comboRow22.IsEnabled = !comboType22.SelectedIndex.Equals(0) ? true : false;
            comboRow22.SelectedIndex = comboType22.SelectedIndex.Equals(0) ? -1 : comboRow22.SelectedIndex;
            txtWats_22.IsEnabled = comboType22.SelectedIndex.Equals(2) ? true : false;
            txtWats_22.Text = comboType22.SelectedIndex.Equals(2) ? txtWats_22.Text : null;

            comboCol23.IsEnabled = !comboType23.SelectedIndex.Equals(0) ? true : false;
            comboCol23.SelectedIndex = comboType23.SelectedIndex.Equals(0) ? -1 : comboCol23.SelectedIndex;
            comboRow23.IsEnabled = !comboType23.SelectedIndex.Equals(0) ? true : false;
            comboRow23.SelectedIndex = comboType23.SelectedIndex.Equals(0) ? -1 : comboRow23.SelectedIndex;
            txtWats_23.IsEnabled = comboType23.SelectedIndex.Equals(2) ? true : false;
            txtWats_23.Text = comboType23.SelectedIndex.Equals(2) ? txtWats_23.Text : null;

            comboCol24.IsEnabled = !comboType24.SelectedIndex.Equals(0) ? true : false;
            comboCol24.SelectedIndex = comboType24.SelectedIndex.Equals(0) ? -1 : comboCol24.SelectedIndex;
            comboRow24.IsEnabled = !comboType24.SelectedIndex.Equals(0) ? true : false;
            comboRow24.SelectedIndex = comboType24.SelectedIndex.Equals(0) ? -1 : comboRow24.SelectedIndex;
            txtWats_24.IsEnabled = comboType24.SelectedIndex.Equals(2) ? true : false;
            txtWats_24.Text = comboType24.SelectedIndex.Equals(2) ? txtWats_24.Text : null;

            comboCol25.IsEnabled = !comboType25.SelectedIndex.Equals(0) ? true : false;
            comboCol25.SelectedIndex = comboType25.SelectedIndex.Equals(0) ? -1 : comboCol25.SelectedIndex;
            comboRow25.IsEnabled = !comboType25.SelectedIndex.Equals(0) ? true : false;
            comboRow25.SelectedIndex = comboType25.SelectedIndex.Equals(0) ? -1 : comboRow25.SelectedIndex;
            txtWats_25.IsEnabled = comboType25.SelectedIndex.Equals(2) ? true : false;
            txtWats_25.Text = comboType25.SelectedIndex.Equals(2) ? txtWats_25.Text : null;

            comboCol26.IsEnabled = !comboType26.SelectedIndex.Equals(0) ? true : false;
            comboCol26.SelectedIndex = comboType26.SelectedIndex.Equals(0) ? -1 : comboCol26.SelectedIndex;
            comboRow26.IsEnabled = !comboType26.SelectedIndex.Equals(0) ? true : false;
            comboRow26.SelectedIndex = comboType26.SelectedIndex.Equals(0) ? -1 : comboRow26.SelectedIndex;
            txtWats_26.IsEnabled = comboType26.SelectedIndex.Equals(2) ? true : false;
            txtWats_26.Text = comboType26.SelectedIndex.Equals(2) ? txtWats_26.Text : null;

            comboCol27.IsEnabled = !comboType27.SelectedIndex.Equals(0) ? true : false;
            comboCol27.SelectedIndex = comboType27.SelectedIndex.Equals(0) ? -1 : comboCol27.SelectedIndex;
            comboRow27.IsEnabled = !comboType27.SelectedIndex.Equals(0) ? true : false;
            comboRow27.SelectedIndex = comboType27.SelectedIndex.Equals(0) ? -1 : comboRow27.SelectedIndex;
            txtWats_27.IsEnabled = comboType27.SelectedIndex.Equals(2) ? true : false;
            txtWats_27.Text = comboType27.SelectedIndex.Equals(2) ? txtWats_27.Text : null;

            comboCol28.IsEnabled = !comboType28.SelectedIndex.Equals(0) ? true : false;
            comboCol28.SelectedIndex = comboType28.SelectedIndex.Equals(0) ? -1 : comboCol28.SelectedIndex;
            comboRow28.IsEnabled = !comboType28.SelectedIndex.Equals(0) ? true : false;
            comboRow28.SelectedIndex = comboType28.SelectedIndex.Equals(0) ? -1 : comboRow28.SelectedIndex;
            txtWats_28.IsEnabled = comboType28.SelectedIndex.Equals(2) ? true : false;
            txtWats_28.Text = comboType28.SelectedIndex.Equals(2) ? txtWats_28.Text : null;

            comboCol29.IsEnabled = !comboType29.SelectedIndex.Equals(0) ? true : false;
            comboCol29.SelectedIndex = comboType29.SelectedIndex.Equals(0) ? -1 : comboCol29.SelectedIndex;
            comboRow29.IsEnabled = !comboType29.SelectedIndex.Equals(0) ? true : false;
            comboRow29.SelectedIndex = comboType29.SelectedIndex.Equals(0) ? -1 : comboRow29.SelectedIndex;
            txtWats_29.IsEnabled = comboType29.SelectedIndex.Equals(2) ? true : false;
            txtWats_29.Text = comboType29.SelectedIndex.Equals(2) ? txtWats_29.Text : null;

            comboCol30.IsEnabled = !comboType30.SelectedIndex.Equals(0) ? true : false;
            comboCol30.SelectedIndex = comboType30.SelectedIndex.Equals(0) ? -1 : comboCol30.SelectedIndex;
            comboRow30.IsEnabled = !comboType30.SelectedIndex.Equals(0) ? true : false;
            comboRow30.SelectedIndex = comboType30.SelectedIndex.Equals(0) ? -1 : comboRow30.SelectedIndex;
            txtWats_30.IsEnabled = comboType30.SelectedIndex.Equals(2) ? true : false;
            txtWats_30.Text = comboType30.SelectedIndex.Equals(2) ? txtWats_30.Text : null;

            comboCol31.IsEnabled = !comboType31.SelectedIndex.Equals(0) ? true : false;
            comboCol31.SelectedIndex = comboType31.SelectedIndex.Equals(0) ? -1 : comboCol31.SelectedIndex;
            comboRow31.IsEnabled = !comboType31.SelectedIndex.Equals(0) ? true : false;
            comboRow31.SelectedIndex = comboType31.SelectedIndex.Equals(0) ? -1 : comboRow31.SelectedIndex;
            txtWats_31.IsEnabled = comboType31.SelectedIndex.Equals(2) ? true : false;
            txtWats_31.Text = comboType31.SelectedIndex.Equals(2) ? txtWats_31.Text : null;

            #endregion

            #region 32 a 41

            comboCol32.IsEnabled = !comboType32.SelectedIndex.Equals(0) ? true : false;
            comboCol32.SelectedIndex = comboType32.SelectedIndex.Equals(0) ? -1 : comboCol32.SelectedIndex;
            comboRow32.IsEnabled = !comboType32.SelectedIndex.Equals(0) ? true : false;
            comboRow32.SelectedIndex = comboType32.SelectedIndex.Equals(0) ? -1 : comboRow32.SelectedIndex;
            txtWats_32.IsEnabled = comboType32.SelectedIndex.Equals(2) ? true : false;
            txtWats_32.Text = comboType32.SelectedIndex.Equals(2) ? txtWats_32.Text : null;

            comboCol33.IsEnabled = !comboType33.SelectedIndex.Equals(0) ? true : false;
            comboCol33.SelectedIndex = comboType33.SelectedIndex.Equals(0) ? -1 : comboCol33.SelectedIndex;
            comboRow33.IsEnabled = !comboType33.SelectedIndex.Equals(0) ? true : false;
            comboRow33.SelectedIndex = comboType33.SelectedIndex.Equals(0) ? -1 : comboRow33.SelectedIndex;
            txtWats_33.IsEnabled = comboType33.SelectedIndex.Equals(2) ? true : false;
            txtWats_33.Text = comboType33.SelectedIndex.Equals(2) ? txtWats_33.Text : null;

            comboCol34.IsEnabled = !comboType34.SelectedIndex.Equals(0) ? true : false;
            comboCol34.SelectedIndex = comboType34.SelectedIndex.Equals(0) ? -1 : comboCol34.SelectedIndex;
            comboRow34.IsEnabled = !comboType34.SelectedIndex.Equals(0) ? true : false;
            comboRow34.SelectedIndex = comboType34.SelectedIndex.Equals(0) ? -1 : comboRow34.SelectedIndex;
            txtWats_34.IsEnabled = comboType34.SelectedIndex.Equals(2) ? true : false;
            txtWats_34.Text = comboType34.SelectedIndex.Equals(2) ? txtWats_34.Text : null;

            comboCol35.IsEnabled = !comboType35.SelectedIndex.Equals(0) ? true : false;
            comboCol35.SelectedIndex = comboType35.SelectedIndex.Equals(0) ? -1 : comboCol35.SelectedIndex;
            comboRow35.IsEnabled = !comboType35.SelectedIndex.Equals(0) ? true : false;
            comboRow35.SelectedIndex = comboType35.SelectedIndex.Equals(0) ? -1 : comboRow35.SelectedIndex;
            txtWats_35.IsEnabled = comboType35.SelectedIndex.Equals(2) ? true : false;
            txtWats_35.Text = comboType35.SelectedIndex.Equals(2) ? txtWats_35.Text : null;

            comboCol36.IsEnabled = !comboType36.SelectedIndex.Equals(0) ? true : false;
            comboCol36.SelectedIndex = comboType36.SelectedIndex.Equals(0) ? -1 : comboCol36.SelectedIndex;
            comboRow36.IsEnabled = !comboType36.SelectedIndex.Equals(0) ? true : false;
            comboRow36.SelectedIndex = comboType36.SelectedIndex.Equals(0) ? -1 : comboRow36.SelectedIndex;
            txtWats_36.IsEnabled = comboType36.SelectedIndex.Equals(2) ? true : false;
            txtWats_36.Text = comboType36.SelectedIndex.Equals(2) ? txtWats_36.Text : null;

            comboCol37.IsEnabled = !comboType37.SelectedIndex.Equals(0) ? true : false;
            comboCol37.SelectedIndex = comboType37.SelectedIndex.Equals(0) ? -1 : comboCol37.SelectedIndex;
            comboRow37.IsEnabled = !comboType37.SelectedIndex.Equals(0) ? true : false;
            comboRow37.SelectedIndex = comboType37.SelectedIndex.Equals(0) ? -1 : comboRow37.SelectedIndex;
            txtWats_37.IsEnabled = comboType37.SelectedIndex.Equals(2) ? true : false;
            txtWats_37.Text = comboType37.SelectedIndex.Equals(2) ? txtWats_37.Text : null;

            comboCol38.IsEnabled = !comboType38.SelectedIndex.Equals(0) ? true : false;
            comboCol38.SelectedIndex = comboType38.SelectedIndex.Equals(0) ? -1 : comboCol38.SelectedIndex;
            comboRow38.IsEnabled = !comboType38.SelectedIndex.Equals(0) ? true : false;
            comboRow38.SelectedIndex = comboType38.SelectedIndex.Equals(0) ? -1 : comboRow38.SelectedIndex;
            txtWats_38.IsEnabled = comboType38.SelectedIndex.Equals(2) ? true : false;
            txtWats_38.Text = comboType38.SelectedIndex.Equals(2) ? txtWats_38.Text : null;

            comboCol39.IsEnabled = !comboType39.SelectedIndex.Equals(0) ? true : false;
            comboCol39.SelectedIndex = comboType39.SelectedIndex.Equals(0) ? -1 : comboCol39.SelectedIndex;
            comboRow39.IsEnabled = !comboType39.SelectedIndex.Equals(0) ? true : false;
            comboRow39.SelectedIndex = comboType39.SelectedIndex.Equals(0) ? -1 : comboRow39.SelectedIndex;
            txtWats_39.IsEnabled = comboType39.SelectedIndex.Equals(2) ? true : false;
            txtWats_39.Text = comboType39.SelectedIndex.Equals(2) ? txtWats_39.Text : null;

            comboCol40.IsEnabled = !comboType40.SelectedIndex.Equals(0) ? true : false;
            comboCol40.SelectedIndex = comboType40.SelectedIndex.Equals(0) ? -1 : comboCol40.SelectedIndex;
            comboRow40.IsEnabled = !comboType40.SelectedIndex.Equals(0) ? true : false;
            comboRow40.SelectedIndex = comboType40.SelectedIndex.Equals(0) ? -1 : comboRow40.SelectedIndex;
            txtWats_40.IsEnabled = comboType40.SelectedIndex.Equals(2) ? true : false;
            txtWats_40.Text = comboType40.SelectedIndex.Equals(2) ? txtWats_40.Text : null;

            comboCol41.IsEnabled = !comboType41.SelectedIndex.Equals(0) ? true : false;
            comboCol41.SelectedIndex = comboType41.SelectedIndex.Equals(0) ? -1 : comboCol41.SelectedIndex;
            comboRow41.IsEnabled = !comboType41.SelectedIndex.Equals(0) ? true : false;
            comboRow41.SelectedIndex = comboType41.SelectedIndex.Equals(0) ? -1 : comboRow41.SelectedIndex;
            txtWats_41.IsEnabled = comboType41.SelectedIndex.Equals(2) ? true : false;
            txtWats_41.Text = comboType41.SelectedIndex.Equals(2) ? txtWats_41.Text : null;

            #endregion

            #region 42 a 51

            comboCol42.IsEnabled = !comboType42.SelectedIndex.Equals(0) ? true : false;
            comboCol42.SelectedIndex = comboType42.SelectedIndex.Equals(0) ? -1 : comboCol42.SelectedIndex;
            comboRow42.IsEnabled = !comboType42.SelectedIndex.Equals(0) ? true : false;
            comboRow42.SelectedIndex = comboType42.SelectedIndex.Equals(0) ? -1 : comboRow42.SelectedIndex;
            txtWats_42.IsEnabled = comboType42.SelectedIndex.Equals(2) ? true : false;
            txtWats_42.Text = comboType42.SelectedIndex.Equals(2) ? txtWats_42.Text : null;

            comboCol43.IsEnabled = !comboType43.SelectedIndex.Equals(0) ? true : false;
            comboCol43.SelectedIndex = comboType43.SelectedIndex.Equals(0) ? -1 : comboCol43.SelectedIndex;
            comboRow43.IsEnabled = !comboType43.SelectedIndex.Equals(0) ? true : false;
            comboRow43.SelectedIndex = comboType43.SelectedIndex.Equals(0) ? -1 : comboRow43.SelectedIndex;
            txtWats_43.IsEnabled = comboType43.SelectedIndex.Equals(2) ? true : false;
            txtWats_43.Text = comboType43.SelectedIndex.Equals(2) ? txtWats_43.Text : null;

            comboCol44.IsEnabled = !comboType44.SelectedIndex.Equals(0) ? true : false;
            comboCol44.SelectedIndex = comboType44.SelectedIndex.Equals(0) ? -1 : comboCol44.SelectedIndex;
            comboRow44.IsEnabled = !comboType44.SelectedIndex.Equals(0) ? true : false;
            comboRow44.SelectedIndex = comboType44.SelectedIndex.Equals(0) ? -1 : comboRow44.SelectedIndex;
            txtWats_44.IsEnabled = comboType44.SelectedIndex.Equals(2) ? true : false;
            txtWats_44.Text = comboType44.SelectedIndex.Equals(2) ? txtWats_44.Text : null;

            comboCol45.IsEnabled = !comboType45.SelectedIndex.Equals(0) ? true : false;
            comboCol45.SelectedIndex = comboType45.SelectedIndex.Equals(0) ? -1 : comboCol45.SelectedIndex;
            comboRow45.IsEnabled = !comboType45.SelectedIndex.Equals(0) ? true : false;
            comboRow45.SelectedIndex = comboType45.SelectedIndex.Equals(0) ? -1 : comboRow45.SelectedIndex;
            txtWats_45.IsEnabled = comboType45.SelectedIndex.Equals(2) ? true : false;
            txtWats_45.Text = comboType45.SelectedIndex.Equals(2) ? txtWats_45.Text : null;

            comboCol46.IsEnabled = !comboType46.SelectedIndex.Equals(0) ? true : false;
            comboCol46.SelectedIndex = comboType46.SelectedIndex.Equals(0) ? -1 : comboCol46.SelectedIndex;
            comboRow46.IsEnabled = !comboType46.SelectedIndex.Equals(0) ? true : false;
            comboRow46.SelectedIndex = comboType46.SelectedIndex.Equals(0) ? -1 : comboRow46.SelectedIndex;
            txtWats_46.IsEnabled = comboType46.SelectedIndex.Equals(2) ? true : false;
            txtWats_46.Text = comboType46.SelectedIndex.Equals(2) ? txtWats_46.Text : null;

            comboCol47.IsEnabled = !comboType47.SelectedIndex.Equals(0) ? true : false;
            comboCol47.SelectedIndex = comboType47.SelectedIndex.Equals(0) ? -1 : comboCol47.SelectedIndex;
            comboRow47.IsEnabled = !comboType47.SelectedIndex.Equals(0) ? true : false;
            comboRow47.SelectedIndex = comboType47.SelectedIndex.Equals(0) ? -1 : comboRow47.SelectedIndex;
            txtWats_47.IsEnabled = comboType47.SelectedIndex.Equals(2) ? true : false;
            txtWats_47.Text = comboType47.SelectedIndex.Equals(2) ? txtWats_47.Text : null;

            comboCol48.IsEnabled = !comboType48.SelectedIndex.Equals(0) ? true : false;
            comboCol48.SelectedIndex = comboType48.SelectedIndex.Equals(0) ? -1 : comboCol48.SelectedIndex;
            comboRow48.IsEnabled = !comboType48.SelectedIndex.Equals(0) ? true : false;
            comboRow48.SelectedIndex = comboType48.SelectedIndex.Equals(0) ? -1 : comboRow48.SelectedIndex;
            txtWats_48.IsEnabled = comboType48.SelectedIndex.Equals(2) ? true : false;
            txtWats_48.Text = comboType48.SelectedIndex.Equals(2) ? txtWats_48.Text : null;

            comboCol49.IsEnabled = !comboType49.SelectedIndex.Equals(0) ? true : false;
            comboCol49.SelectedIndex = comboType49.SelectedIndex.Equals(0) ? -1 : comboCol49.SelectedIndex;
            comboRow49.IsEnabled = !comboType49.SelectedIndex.Equals(0) ? true : false;
            comboRow49.SelectedIndex = comboType49.SelectedIndex.Equals(0) ? -1 : comboRow49.SelectedIndex;
            txtWats_49.IsEnabled = comboType49.SelectedIndex.Equals(2) ? true : false;
            txtWats_49.Text = comboType49.SelectedIndex.Equals(2) ? txtWats_49.Text : null;

            comboCol50.IsEnabled = !comboType50.SelectedIndex.Equals(0) ? true : false;
            comboCol50.SelectedIndex = comboType50.SelectedIndex.Equals(0) ? -1 : comboCol50.SelectedIndex;
            comboRow50.IsEnabled = !comboType50.SelectedIndex.Equals(0) ? true : false;
            comboRow50.SelectedIndex = comboType50.SelectedIndex.Equals(0) ? -1 : comboRow50.SelectedIndex;
            txtWats_50.IsEnabled = comboType50.SelectedIndex.Equals(2) ? true : false;
            txtWats_50.Text = comboType50.SelectedIndex.Equals(2) ? txtWats_50.Text : null;

            comboCol51.IsEnabled = !comboType51.SelectedIndex.Equals(0) ? true : false;
            comboCol51.SelectedIndex = comboType51.SelectedIndex.Equals(0) ? -1 : comboCol51.SelectedIndex;
            comboRow51.IsEnabled = !comboType51.SelectedIndex.Equals(0) ? true : false;
            comboRow51.SelectedIndex = comboType51.SelectedIndex.Equals(0) ? -1 : comboRow51.SelectedIndex;
            txtWats_51.IsEnabled = comboType51.SelectedIndex.Equals(2) ? true : false;
            txtWats_51.Text = comboType51.SelectedIndex.Equals(2) ? txtWats_51.Text : null;

            #endregion

        }

        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Deseja resetar todos os campos?", "! ! ! Atenção ! ! !", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                #region Block A
                comboTypeA0.SelectedIndex = 0;
                comboTypeA1.SelectedIndex = 0;
                comboTypeA2.SelectedIndex = 0;
                comboTypeA3.SelectedIndex = 0;
                comboTypeA4.SelectedIndex = 0;
                comboTypeA5.SelectedIndex = 0;
                comboTypeA6.SelectedIndex = 0;
                comboTypeA7.SelectedIndex = 0;
                #endregion

                #region Block B
                comboTypeA8.SelectedIndex = 0;
                comboTypeA9.SelectedIndex = 0;
                comboTypeA10.SelectedIndex = 0;
                comboTypeA11.SelectedIndex = 0;
                comboTypeA12.SelectedIndex = 0;
                comboTypeA13.SelectedIndex = 0;
                comboTypeA14.SelectedIndex = 0;
                comboTypeA15.SelectedIndex = 0;
                #endregion

                #region Block C
                comboType2.SelectedIndex = 0;
                comboType3.SelectedIndex = 0;
                comboType4.SelectedIndex = 0;
                comboType5.SelectedIndex = 0;
                comboType6.SelectedIndex = 0;
                comboType7.SelectedIndex = 0;
                comboType8.SelectedIndex = 0;
                comboType9.SelectedIndex = 0;
                #endregion

                #region Block D
                comboType22.SelectedIndex = 0;
                comboType23.SelectedIndex = 0;
                comboType24.SelectedIndex = 0;
                comboType25.SelectedIndex = 0;
                comboType26.SelectedIndex = 0;
                comboType27.SelectedIndex = 0;
                comboType28.SelectedIndex = 0;
                comboType29.SelectedIndex = 0;
                comboType30.SelectedIndex = 0;
                comboType31.SelectedIndex = 0;
                comboType32.SelectedIndex = 0;
                comboType33.SelectedIndex = 0;
                comboType34.SelectedIndex = 0;
                comboType35.SelectedIndex = 0;
                comboType36.SelectedIndex = 0;
                comboType37.SelectedIndex = 0;
                comboType38.SelectedIndex = 0;
                comboType39.SelectedIndex = 0;
                comboType40.SelectedIndex = 0;
                comboType41.SelectedIndex = 0;
                comboType42.SelectedIndex = 0;
                comboType43.SelectedIndex = 0;
                comboType44.SelectedIndex = 0;
                comboType45.SelectedIndex = 0;
                comboType46.SelectedIndex = 0;
                comboType47.SelectedIndex = 0;
                comboType48.SelectedIndex = 0;
                comboType49.SelectedIndex = 0;
                comboType50.SelectedIndex = 0;
                comboType51.SelectedIndex = 0;
                #endregion
            }
        }

        private void btSalveData_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Definir esses dados como padrão?", "! ! ! Atenção ! ! !", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                saveData();
                enableButtonSelect();

                Class.Variables.enableButton.Clear();
                Class.Variables.enableButton.AddRange(Class.Variables.enableButtonSelect);

                string ip_Arduino = txtFirstOcteto.Text + "." + txtSecondOcteto.Text + "." + txtThirdOcteto.Text + "." + txtFourthOcteto.Text;

                int[] comboType = new int[54];
                int[] comboCol = new int[54];
                int[] comboRow = new int[54];
                int[] watts = new int[54];

                //Block Combo Type
                comboType[0] = comboTypeA0.SelectedIndex; comboType[1] = comboTypeA1.SelectedIndex; comboType[2] = comboTypeA2.SelectedIndex; comboType[3] = comboTypeA3.SelectedIndex;
                comboType[4] = comboTypeA4.SelectedIndex; comboType[5] = comboTypeA5.SelectedIndex; comboType[6] = comboTypeA6.SelectedIndex; comboType[7] = comboTypeA7.SelectedIndex;
                comboType[8] = comboTypeA8.SelectedIndex; comboType[9] = comboTypeA9.SelectedIndex; comboType[10] = comboTypeA10.SelectedIndex; comboType[11] = comboTypeA11.SelectedIndex;
                comboType[12] = comboTypeA12.SelectedIndex; comboType[13] = comboTypeA13.SelectedIndex; comboType[14] = comboTypeA14.SelectedIndex; comboType[15] = comboTypeA15.SelectedIndex;
                comboType[16] = comboType2.SelectedIndex; comboType[17] = comboType3.SelectedIndex; comboType[18] = comboType4.SelectedIndex; comboType[19] = comboType5.SelectedIndex;
                comboType[20] = comboType6.SelectedIndex; comboType[21] = comboType7.SelectedIndex; comboType[22] = comboType8.SelectedIndex; comboType[23] = comboType9.SelectedIndex;
                comboType[24] = comboType22.SelectedIndex; comboType[25] = comboType23.SelectedIndex; comboType[26] = comboType24.SelectedIndex; comboType[27] = comboType25.SelectedIndex;
                comboType[28] = comboType26.SelectedIndex; comboType[29] = comboType27.SelectedIndex; comboType[30] = comboType28.SelectedIndex; comboType[31] = comboType29.SelectedIndex;
                comboType[32] = comboType30.SelectedIndex; comboType[33] = comboType31.SelectedIndex; comboType[34] = comboType32.SelectedIndex; comboType[35] = comboType33.SelectedIndex;
                comboType[36] = comboType34.SelectedIndex; comboType[37] = comboType35.SelectedIndex; comboType[38] = comboType36.SelectedIndex; comboType[39] = comboType37.SelectedIndex;
                comboType[40] = comboType38.SelectedIndex; comboType[41] = comboType39.SelectedIndex; comboType[42] = comboType40.SelectedIndex; comboType[43] = comboType41.SelectedIndex;
                comboType[44] = comboType42.SelectedIndex; comboType[45] = comboType43.SelectedIndex; comboType[46] = comboType44.SelectedIndex; comboType[47] = comboType45.SelectedIndex;
                comboType[48] = comboType46.SelectedIndex; comboType[49] = comboType47.SelectedIndex; comboType[50] = comboType48.SelectedIndex; comboType[51] = comboType49.SelectedIndex;
                comboType[52] = comboType50.SelectedIndex; comboType[53] = comboType51.SelectedIndex;

                //Block Combo Column
                comboCol[0] = comboColA0.SelectedIndex; comboCol[1] = comboColA1.SelectedIndex; comboCol[2] = comboColA2.SelectedIndex; comboCol[3] = comboColA3.SelectedIndex;
                comboCol[4] = comboColA4.SelectedIndex; comboCol[5] = comboColA5.SelectedIndex; comboCol[6] = comboColA6.SelectedIndex; comboCol[7] = comboColA7.SelectedIndex;
                comboCol[8] = comboColA8.SelectedIndex; comboCol[9] = comboColA9.SelectedIndex; comboCol[10] = comboColA10.SelectedIndex; comboCol[11] = comboColA11.SelectedIndex;
                comboCol[12] = comboColA12.SelectedIndex; comboCol[13] = comboColA13.SelectedIndex; comboCol[14] = comboColA14.SelectedIndex; comboCol[15] = comboColA15.SelectedIndex;
                comboCol[16] = comboCol2.SelectedIndex; comboCol[17] = comboCol3.SelectedIndex; comboCol[18] = comboCol4.SelectedIndex; comboCol[19] = comboCol5.SelectedIndex;
                comboCol[20] = comboCol6.SelectedIndex; comboCol[21] = comboCol7.SelectedIndex; comboCol[22] = comboCol8.SelectedIndex; comboCol[23] = comboCol9.SelectedIndex;
                comboCol[24] = comboCol22.SelectedIndex; comboCol[25] = comboCol23.SelectedIndex; comboCol[26] = comboCol24.SelectedIndex; comboCol[27] = comboCol25.SelectedIndex;
                comboCol[28] = comboCol26.SelectedIndex; comboCol[29] = comboCol27.SelectedIndex; comboCol[30] = comboCol28.SelectedIndex; comboCol[31] = comboCol29.SelectedIndex;
                comboCol[32] = comboCol30.SelectedIndex; comboCol[33] = comboCol31.SelectedIndex; comboCol[34] = comboCol32.SelectedIndex; comboCol[35] = comboCol33.SelectedIndex;
                comboCol[36] = comboCol34.SelectedIndex; comboCol[37] = comboCol35.SelectedIndex; comboCol[38] = comboCol36.SelectedIndex; comboCol[39] = comboCol37.SelectedIndex;
                comboCol[40] = comboCol38.SelectedIndex; comboCol[41] = comboCol39.SelectedIndex; comboCol[42] = comboCol40.SelectedIndex; comboCol[43] = comboCol41.SelectedIndex;
                comboCol[44] = comboCol42.SelectedIndex; comboCol[45] = comboCol43.SelectedIndex; comboCol[46] = comboCol44.SelectedIndex; comboCol[47] = comboCol45.SelectedIndex;
                comboCol[48] = comboCol46.SelectedIndex; comboCol[49] = comboCol47.SelectedIndex; comboCol[50] = comboCol48.SelectedIndex; comboCol[51] = comboCol49.SelectedIndex;
                comboCol[52] = comboCol50.SelectedIndex; comboCol[53] = comboCol51.SelectedIndex;

                //Block Combo Row
                comboRow[0] = comboRowA0.SelectedIndex; comboRow[1] = comboRowA1.SelectedIndex; comboRow[2] = comboRowA2.SelectedIndex; comboRow[3] = comboRowA3.SelectedIndex;
                comboRow[4] = comboRowA4.SelectedIndex; comboRow[5] = comboRowA5.SelectedIndex; comboRow[6] = comboRowA6.SelectedIndex; comboRow[7] = comboRowA7.SelectedIndex;
                comboRow[8] = comboRowA8.SelectedIndex; comboRow[9] = comboRowA9.SelectedIndex; comboRow[10] = comboRowA10.SelectedIndex; comboRow[11] = comboRowA11.SelectedIndex;
                comboRow[12] = comboRowA12.SelectedIndex; comboRow[13] = comboRowA13.SelectedIndex; comboRow[14] = comboRowA14.SelectedIndex; comboRow[15] = comboRowA15.SelectedIndex;
                comboRow[16] = comboRow2.SelectedIndex; comboRow[17] = comboRow3.SelectedIndex; comboRow[18] = comboRow4.SelectedIndex; comboRow[19] = comboRow5.SelectedIndex;
                comboRow[20] = comboRow6.SelectedIndex; comboRow[21] = comboRow7.SelectedIndex; comboRow[22] = comboRow8.SelectedIndex; comboRow[23] = comboRow9.SelectedIndex;
                comboRow[24] = comboRow22.SelectedIndex; comboRow[25] = comboRow23.SelectedIndex; comboRow[26] = comboRow24.SelectedIndex; comboRow[27] = comboRow25.SelectedIndex;
                comboRow[28] = comboRow26.SelectedIndex; comboRow[29] = comboRow27.SelectedIndex; comboRow[30] = comboRow28.SelectedIndex; comboRow[31] = comboRow29.SelectedIndex;
                comboRow[32] = comboRow30.SelectedIndex; comboRow[33] = comboRow31.SelectedIndex; comboRow[34] = comboRow32.SelectedIndex; comboRow[35] = comboRow33.SelectedIndex;
                comboRow[36] = comboRow34.SelectedIndex; comboRow[37] = comboRow35.SelectedIndex; comboRow[38] = comboRow36.SelectedIndex; comboRow[39] = comboRow37.SelectedIndex;
                comboRow[40] = comboRow38.SelectedIndex; comboRow[41] = comboRow39.SelectedIndex; comboRow[42] = comboRow40.SelectedIndex; comboRow[43] = comboRow41.SelectedIndex;
                comboRow[44] = comboRow42.SelectedIndex; comboRow[45] = comboRow43.SelectedIndex; comboRow[46] = comboRow44.SelectedIndex; comboRow[47] = comboRow45.SelectedIndex;
                comboRow[48] = comboRow46.SelectedIndex; comboRow[49] = comboRow47.SelectedIndex; comboRow[50] = comboRow48.SelectedIndex; comboRow[51] = comboRow49.SelectedIndex;
                comboRow[52] = comboRow50.SelectedIndex; comboRow[53] = comboRow51.SelectedIndex;

                //Block Watts
                watts[0] = !txtWats_A0.Text.Equals("") ? int.Parse(txtWats_A0.Text) : watts[0]; watts[1] = !txtWats_A1.Text.Equals("") ? int.Parse(txtWats_A1.Text) : watts[1];
                watts[2] = !txtWats_A2.Text.Equals("") ? int.Parse(txtWats_A2.Text) : watts[2]; watts[3] = !txtWats_A3.Text.Equals("") ? int.Parse(txtWats_A3.Text) : watts[3];
                watts[4] = !txtWats_A4.Text.Equals("") ? int.Parse(txtWats_A4.Text) : watts[4]; watts[5] = !txtWats_A5.Text.Equals("") ? int.Parse(txtWats_A5.Text) : watts[5];
                watts[6] = !txtWats_A6.Text.Equals("") ? int.Parse(txtWats_A6.Text) : watts[6]; watts[7] = !txtWats_A7.Text.Equals("") ? int.Parse(txtWats_A7.Text) : watts[7];
                watts[8] = !txtWats_A8.Text.Equals("") ? int.Parse(txtWats_A8.Text) : watts[8]; watts[9] = !txtWats_A9.Text.Equals("") ? int.Parse(txtWats_A9.Text) : watts[9];
                watts[10] = !txtWats_A10.Text.Equals("") ? int.Parse(txtWats_A10.Text) : watts[10]; watts[11] = !txtWats_A11.Text.Equals("") ? int.Parse(txtWats_A11.Text) : watts[11];
                watts[12] = !txtWats_A12.Text.Equals("") ? int.Parse(txtWats_A12.Text) : watts[12]; watts[13] = !txtWats_A13.Text.Equals("") ? int.Parse(txtWats_A13.Text) : watts[13];
                watts[14] = !txtWats_A14.Text.Equals("") ? int.Parse(txtWats_A14.Text) : watts[14]; watts[15] = !txtWats_A15.Text.Equals("") ? int.Parse(txtWats_A15.Text) : watts[15];
                watts[16] = !txtWats_2.Text.Equals("") ? int.Parse(txtWats_2.Text) : watts[16]; watts[17] = !txtWats_3.Text.Equals("") ? int.Parse(txtWats_3.Text) : watts[17];
                watts[18] = !txtWats_4.Text.Equals("") ? int.Parse(txtWats_4.Text) : watts[18]; watts[19] = !txtWats_5.Text.Equals("") ? int.Parse(txtWats_5.Text) : watts[19];
                watts[20] = !txtWats_6.Text.Equals("") ? int.Parse(txtWats_6.Text) : watts[20]; watts[21] = !txtWats_7.Text.Equals("") ? int.Parse(txtWats_7.Text) : watts[21];
                watts[22] = !txtWats_8.Text.Equals("") ? int.Parse(txtWats_8.Text) : watts[22]; watts[23] = !txtWats_9.Text.Equals("") ? int.Parse(txtWats_9.Text) : watts[23];
                watts[24] = !txtWats_22.Text.Equals("") ? int.Parse(txtWats_22.Text) : watts[24]; watts[25] = !txtWats_23.Text.Equals("") ? int.Parse(txtWats_23.Text) : watts[25];
                watts[26] = !txtWats_24.Text.Equals("") ? int.Parse(txtWats_24.Text) : watts[26]; watts[27] = !txtWats_25.Text.Equals("") ? int.Parse(txtWats_25.Text) : watts[27];
                watts[28] = !txtWats_26.Text.Equals("") ? int.Parse(txtWats_26.Text) : watts[28]; watts[29] = !txtWats_27.Text.Equals("") ? int.Parse(txtWats_27.Text) : watts[29];
                watts[30] = !txtWats_28.Text.Equals("") ? int.Parse(txtWats_28.Text) : watts[30]; watts[31] = !txtWats_29.Text.Equals("") ? int.Parse(txtWats_29.Text) : watts[31];
                watts[32] = !txtWats_30.Text.Equals("") ? int.Parse(txtWats_30.Text) : watts[32]; watts[33] = !txtWats_31.Text.Equals("") ? int.Parse(txtWats_31.Text) : watts[33];
                watts[34] = !txtWats_32.Text.Equals("") ? int.Parse(txtWats_32.Text) : watts[34]; watts[35] = !txtWats_33.Text.Equals("") ? int.Parse(txtWats_33.Text) : watts[35];
                watts[36] = !txtWats_34.Text.Equals("") ? int.Parse(txtWats_34.Text) : watts[36]; watts[37] = !txtWats_35.Text.Equals("") ? int.Parse(txtWats_35.Text) : watts[37];
                watts[38] = !txtWats_36.Text.Equals("") ? int.Parse(txtWats_36.Text) : watts[38]; watts[39] = !txtWats_37.Text.Equals("") ? int.Parse(txtWats_37.Text) : watts[39];
                watts[40] = !txtWats_38.Text.Equals("") ? int.Parse(txtWats_38.Text) : watts[40]; watts[41] = !txtWats_39.Text.Equals("") ? int.Parse(txtWats_39.Text) : watts[41];
                watts[42] = !txtWats_40.Text.Equals("") ? int.Parse(txtWats_40.Text) : watts[42]; watts[43] = !txtWats_41.Text.Equals("") ? int.Parse(txtWats_41.Text) : watts[43];
                watts[44] = !txtWats_42.Text.Equals("") ? int.Parse(txtWats_42.Text) : watts[44]; watts[45] = !txtWats_43.Text.Equals("") ? int.Parse(txtWats_43.Text) : watts[45];
                watts[46] = !txtWats_44.Text.Equals("") ? int.Parse(txtWats_44.Text) : watts[46]; watts[47] = !txtWats_45.Text.Equals("") ? int.Parse(txtWats_45.Text) : watts[47];
                watts[48] = !txtWats_46.Text.Equals("") ? int.Parse(txtWats_46.Text) : watts[48]; watts[49] = !txtWats_47.Text.Equals("") ? int.Parse(txtWats_47.Text) : watts[49];
                watts[50] = !txtWats_48.Text.Equals("") ? int.Parse(txtWats_48.Text) : watts[50]; watts[51] = !txtWats_49.Text.Equals("") ? int.Parse(txtWats_49.Text) : watts[51];
                watts[52] = !txtWats_50.Text.Equals("") ? int.Parse(txtWats_50.Text) : watts[52]; watts[53] = !txtWats_51.Text.Equals("") ? int.Parse(txtWats_51.Text) : watts[53];

                Class.Variables.typeIO_DB = comboType;
                Class.Variables.actionCol_DB = comboCol;
                Class.Variables.actionRow_DB = comboRow;
                Class.Variables.watts_DB = watts;

                Class.Variables.d_DateTime = System.DateTime.Now;

                crud.SaveConfig(1, Class.Variables.d_DateTime, ip_Arduino, Class.Variables.typeIO_DB, Class.Variables.actionCol_DB, Class.Variables.actionRow_DB, Class.Variables.watts_DB);

            }
                
        }

        private void btUploadData_Click(object sender, RoutedEventArgs e)
        {
            crud.UpdateConfig(ref Class.Variables.d_DateTime, ref Class.Variables.c_IpArduinoConfig, ref Class.Variables.typeIO_DB, ref Class.Variables.actionCol_DB, ref Class.Variables.actionRow_DB, ref Class.Variables.watts_DB);

            updateScreenConfig();
            
        }

        private void btSendArduino_Click(object sender, RoutedEventArgs e)
        {
        }

        private void saveData()
        {
            #region Block A

            Class.Variables.typeIO_DB[0] = comboTypeA0.SelectedIndex;
            Class.Variables.typeIO_DB[1] = comboTypeA1.SelectedIndex;
            Class.Variables.typeIO_DB[2] = comboTypeA2.SelectedIndex;
            Class.Variables.typeIO_DB[3] = comboTypeA3.SelectedIndex;
            Class.Variables.typeIO_DB[4] = comboTypeA4.SelectedIndex;
            Class.Variables.typeIO_DB[5] = comboTypeA5.SelectedIndex;
            Class.Variables.typeIO_DB[6] = comboTypeA6.SelectedIndex;
            Class.Variables.typeIO_DB[7] = comboTypeA7.SelectedIndex;

            Class.Variables.actionCol_DB[0] = comboColA0.SelectedIndex;
            Class.Variables.actionCol_DB[1] = comboColA1.SelectedIndex;
            Class.Variables.actionCol_DB[2] = comboColA2.SelectedIndex;
            Class.Variables.actionCol_DB[3] = comboColA3.SelectedIndex;
            Class.Variables.actionCol_DB[4] = comboColA4.SelectedIndex;
            Class.Variables.actionCol_DB[5] = comboColA5.SelectedIndex;
            Class.Variables.actionCol_DB[6] = comboColA6.SelectedIndex;
            Class.Variables.actionCol_DB[7] = comboColA7.SelectedIndex;

            Class.Variables.actionRow_DB[0] = comboRowA0.SelectedIndex;
            Class.Variables.actionRow_DB[1] = comboRowA1.SelectedIndex;
            Class.Variables.actionRow_DB[2] = comboRowA2.SelectedIndex;
            Class.Variables.actionRow_DB[3] = comboRowA3.SelectedIndex;
            Class.Variables.actionRow_DB[4] = comboRowA4.SelectedIndex;
            Class.Variables.actionRow_DB[5] = comboRowA5.SelectedIndex;
            Class.Variables.actionRow_DB[6] = comboRowA6.SelectedIndex;
            Class.Variables.actionRow_DB[7] = comboRowA7.SelectedIndex;

            #endregion

            #region Block B

            Class.Variables.typeIO_DB[8] = comboTypeA8.SelectedIndex;
            Class.Variables.typeIO_DB[9] = comboTypeA9.SelectedIndex;
            Class.Variables.typeIO_DB[10] = comboTypeA10.SelectedIndex;
            Class.Variables.typeIO_DB[11] = comboTypeA11.SelectedIndex;
            Class.Variables.typeIO_DB[12] = comboTypeA12.SelectedIndex;
            Class.Variables.typeIO_DB[13] = comboTypeA13.SelectedIndex;
            Class.Variables.typeIO_DB[14] = comboTypeA14.SelectedIndex;
            Class.Variables.typeIO_DB[15] = comboTypeA15.SelectedIndex;

            Class.Variables.actionCol_DB[8] = comboColA8.SelectedIndex;
            Class.Variables.actionCol_DB[9] = comboColA9.SelectedIndex;
            Class.Variables.actionCol_DB[10] = comboColA10.SelectedIndex;
            Class.Variables.actionCol_DB[11] = comboColA11.SelectedIndex;
            Class.Variables.actionCol_DB[12] = comboColA12.SelectedIndex;
            Class.Variables.actionCol_DB[13] = comboColA13.SelectedIndex;
            Class.Variables.actionCol_DB[14] = comboColA14.SelectedIndex;
            Class.Variables.actionCol_DB[15] = comboColA15.SelectedIndex;

            Class.Variables.actionRow_DB[8] = comboRowA8.SelectedIndex;
            Class.Variables.actionRow_DB[9] = comboRowA9.SelectedIndex;
            Class.Variables.actionRow_DB[10] = comboRowA10.SelectedIndex;
            Class.Variables.actionRow_DB[11] = comboRowA11.SelectedIndex;
            Class.Variables.actionRow_DB[12] = comboRowA12.SelectedIndex;
            Class.Variables.actionRow_DB[13] = comboRowA13.SelectedIndex;
            Class.Variables.actionRow_DB[14] = comboRowA14.SelectedIndex;
            Class.Variables.actionRow_DB[15] = comboRowA15.SelectedIndex;

            #endregion

            #region Block C

            Class.Variables.typeIO_DB[16] = comboType2.SelectedIndex;
            Class.Variables.typeIO_DB[17] = comboType3.SelectedIndex;
            Class.Variables.typeIO_DB[18] = comboType4.SelectedIndex;
            Class.Variables.typeIO_DB[19] = comboType5.SelectedIndex;
            Class.Variables.typeIO_DB[20] = comboType6.SelectedIndex;
            Class.Variables.typeIO_DB[21] = comboType7.SelectedIndex;
            Class.Variables.typeIO_DB[22] = comboType8.SelectedIndex;
            Class.Variables.typeIO_DB[23] = comboType9.SelectedIndex;

            Class.Variables.actionCol_DB[16] = comboCol2.SelectedIndex;
            Class.Variables.actionCol_DB[17] = comboCol3.SelectedIndex;
            Class.Variables.actionCol_DB[18] = comboCol4.SelectedIndex;
            Class.Variables.actionCol_DB[19] = comboCol5.SelectedIndex;
            Class.Variables.actionCol_DB[20] = comboCol6.SelectedIndex;
            Class.Variables.actionCol_DB[21] = comboCol7.SelectedIndex;
            Class.Variables.actionCol_DB[22] = comboCol8.SelectedIndex;
            Class.Variables.actionCol_DB[23] = comboCol9.SelectedIndex;

            Class.Variables.actionRow_DB[16] = comboRow2.SelectedIndex;
            Class.Variables.actionRow_DB[17] = comboRow3.SelectedIndex;
            Class.Variables.actionRow_DB[18] = comboRow4.SelectedIndex;
            Class.Variables.actionRow_DB[19] = comboRow5.SelectedIndex;
            Class.Variables.actionRow_DB[20] = comboRow6.SelectedIndex;
            Class.Variables.actionRow_DB[21] = comboRow7.SelectedIndex;
            Class.Variables.actionRow_DB[22] = comboRow8.SelectedIndex;
            Class.Variables.actionRow_DB[23] = comboRow9.SelectedIndex;

            #endregion

            #region Block D

            #region 22-31

            Class.Variables.typeIO_DB[24] = comboType22.SelectedIndex;
            Class.Variables.typeIO_DB[25] = comboType23.SelectedIndex;
            Class.Variables.typeIO_DB[26] = comboType24.SelectedIndex;
            Class.Variables.typeIO_DB[27] = comboType25.SelectedIndex;
            Class.Variables.typeIO_DB[28] = comboType26.SelectedIndex;
            Class.Variables.typeIO_DB[29] = comboType27.SelectedIndex;
            Class.Variables.typeIO_DB[30] = comboType28.SelectedIndex;
            Class.Variables.typeIO_DB[31] = comboType29.SelectedIndex;
            Class.Variables.typeIO_DB[32] = comboType30.SelectedIndex;
            Class.Variables.typeIO_DB[33] = comboType31.SelectedIndex;

            Class.Variables.actionCol_DB[24] = comboCol22.SelectedIndex;
            Class.Variables.actionCol_DB[25] = comboCol23.SelectedIndex;
            Class.Variables.actionCol_DB[26] = comboCol24.SelectedIndex;
            Class.Variables.actionCol_DB[27] = comboCol25.SelectedIndex;
            Class.Variables.actionCol_DB[28] = comboCol26.SelectedIndex;
            Class.Variables.actionCol_DB[29] = comboCol27.SelectedIndex;
            Class.Variables.actionCol_DB[30] = comboCol28.SelectedIndex;
            Class.Variables.actionCol_DB[31] = comboCol29.SelectedIndex;
            Class.Variables.actionCol_DB[32] = comboCol30.SelectedIndex;
            Class.Variables.actionCol_DB[33] = comboCol31.SelectedIndex;

            Class.Variables.actionRow_DB[24] = comboRow22.SelectedIndex;
            Class.Variables.actionRow_DB[25] = comboRow23.SelectedIndex;
            Class.Variables.actionRow_DB[26] = comboRow24.SelectedIndex;
            Class.Variables.actionRow_DB[27] = comboRow25.SelectedIndex;
            Class.Variables.actionRow_DB[28] = comboRow26.SelectedIndex;
            Class.Variables.actionRow_DB[29] = comboRow27.SelectedIndex;
            Class.Variables.actionRow_DB[30] = comboRow28.SelectedIndex;
            Class.Variables.actionRow_DB[31] = comboRow29.SelectedIndex;
            Class.Variables.actionRow_DB[32] = comboRow30.SelectedIndex;
            Class.Variables.actionRow_DB[33] = comboRow31.SelectedIndex;

            #endregion

            #region 32-41

            Class.Variables.typeIO_DB[34] = comboType32.SelectedIndex;
            Class.Variables.typeIO_DB[35] = comboType33.SelectedIndex;
            Class.Variables.typeIO_DB[36] = comboType34.SelectedIndex;
            Class.Variables.typeIO_DB[37] = comboType35.SelectedIndex;
            Class.Variables.typeIO_DB[38] = comboType36.SelectedIndex;
            Class.Variables.typeIO_DB[39] = comboType37.SelectedIndex;
            Class.Variables.typeIO_DB[40] = comboType38.SelectedIndex;
            Class.Variables.typeIO_DB[41] = comboType39.SelectedIndex;
            Class.Variables.typeIO_DB[42] = comboType40.SelectedIndex;
            Class.Variables.typeIO_DB[43] = comboType41.SelectedIndex;

            Class.Variables.actionCol_DB[34] = comboCol32.SelectedIndex;
            Class.Variables.actionCol_DB[35] = comboCol33.SelectedIndex;
            Class.Variables.actionCol_DB[36] = comboCol34.SelectedIndex;
            Class.Variables.actionCol_DB[37] = comboCol35.SelectedIndex;
            Class.Variables.actionCol_DB[38] = comboCol36.SelectedIndex;
            Class.Variables.actionCol_DB[39] = comboCol37.SelectedIndex;
            Class.Variables.actionCol_DB[30] = comboCol38.SelectedIndex;
            Class.Variables.actionCol_DB[31] = comboCol39.SelectedIndex;
            Class.Variables.actionCol_DB[32] = comboCol40.SelectedIndex;
            Class.Variables.actionCol_DB[33] = comboCol41.SelectedIndex;

            Class.Variables.actionRow_DB[34] = comboRow32.SelectedIndex;
            Class.Variables.actionRow_DB[35] = comboRow33.SelectedIndex;
            Class.Variables.actionRow_DB[36] = comboRow34.SelectedIndex;
            Class.Variables.actionRow_DB[37] = comboRow35.SelectedIndex;
            Class.Variables.actionRow_DB[38] = comboRow36.SelectedIndex;
            Class.Variables.actionRow_DB[39] = comboRow37.SelectedIndex;
            Class.Variables.actionRow_DB[40] = comboRow38.SelectedIndex;
            Class.Variables.actionRow_DB[41] = comboRow39.SelectedIndex;
            Class.Variables.actionRow_DB[42] = comboRow40.SelectedIndex;
            Class.Variables.actionRow_DB[43] = comboRow41.SelectedIndex;

            #endregion

            #region 42-51

            Class.Variables.typeIO_DB[44] = comboType42.SelectedIndex;
            Class.Variables.typeIO_DB[45] = comboType43.SelectedIndex;
            Class.Variables.typeIO_DB[46] = comboType44.SelectedIndex;
            Class.Variables.typeIO_DB[47] = comboType45.SelectedIndex;
            Class.Variables.typeIO_DB[48] = comboType46.SelectedIndex;
            Class.Variables.typeIO_DB[49] = comboType47.SelectedIndex;
            Class.Variables.typeIO_DB[50] = comboType48.SelectedIndex;
            Class.Variables.typeIO_DB[51] = comboType49.SelectedIndex;
            Class.Variables.typeIO_DB[52] = comboType50.SelectedIndex;
            Class.Variables.typeIO_DB[53] = comboType51.SelectedIndex;

            Class.Variables.actionCol_DB[44] = comboCol42.SelectedIndex;
            Class.Variables.actionCol_DB[45] = comboCol43.SelectedIndex;
            Class.Variables.actionCol_DB[46] = comboCol44.SelectedIndex;
            Class.Variables.actionCol_DB[47] = comboCol45.SelectedIndex;
            Class.Variables.actionCol_DB[48] = comboCol46.SelectedIndex;
            Class.Variables.actionCol_DB[49] = comboCol47.SelectedIndex;
            Class.Variables.actionCol_DB[50] = comboCol48.SelectedIndex;
            Class.Variables.actionCol_DB[51] = comboCol49.SelectedIndex;
            Class.Variables.actionCol_DB[52] = comboCol50.SelectedIndex;
            Class.Variables.actionCol_DB[53] = comboCol51.SelectedIndex;

            Class.Variables.actionRow_DB[44] = comboRow42.SelectedIndex;
            Class.Variables.actionRow_DB[45] = comboRow43.SelectedIndex;
            Class.Variables.actionRow_DB[46] = comboRow44.SelectedIndex;
            Class.Variables.actionRow_DB[47] = comboRow45.SelectedIndex;
            Class.Variables.actionRow_DB[48] = comboRow46.SelectedIndex;
            Class.Variables.actionRow_DB[49] = comboRow47.SelectedIndex;
            Class.Variables.actionRow_DB[50] = comboRow48.SelectedIndex;
            Class.Variables.actionRow_DB[51] = comboRow49.SelectedIndex;
            Class.Variables.actionRow_DB[52] = comboRow50.SelectedIndex;
            Class.Variables.actionRow_DB[53] = comboRow51.SelectedIndex;

            #endregion

            #endregion
        }

        /// <summary>
        /// Método privado atualiza campos da tela configurações com base
        /// na classe variaveis que manipula os dados de forma estática 
        /// servindo como memória de acesso global.
        /// </summary>
        private void updateScreenConfig()
        {
            string[] ip = Class.Variables.c_IpArduinoConfig.Split(".");

            txtFirstOcteto.Text = ip[0];
            txtSecondOcteto.Text = ip[1];
            txtThirdOcteto.Text = ip[2];
            txtFourthOcteto.Text = ip[3];

            comboTypeA0.SelectedIndex = Class.Variables.typeIO_DB[0]; comboTypeA1.SelectedIndex = Class.Variables.typeIO_DB[1]; comboTypeA2.SelectedIndex = Class.Variables.typeIO_DB[2]; comboTypeA3.SelectedIndex = Class.Variables.typeIO_DB[3];
            comboTypeA4.SelectedIndex = Class.Variables.typeIO_DB[4]; comboTypeA5.SelectedIndex = Class.Variables.typeIO_DB[5]; comboTypeA6.SelectedIndex = Class.Variables.typeIO_DB[6]; comboTypeA7.SelectedIndex = Class.Variables.typeIO_DB[7];
            comboTypeA8.SelectedIndex = Class.Variables.typeIO_DB[8]; comboTypeA9.SelectedIndex = Class.Variables.typeIO_DB[9]; comboTypeA10.SelectedIndex = Class.Variables.typeIO_DB[10]; comboTypeA11.SelectedIndex = Class.Variables.typeIO_DB[11];
            comboTypeA12.SelectedIndex = Class.Variables.typeIO_DB[12]; comboTypeA13.SelectedIndex = Class.Variables.typeIO_DB[13]; comboTypeA14.SelectedIndex = Class.Variables.typeIO_DB[14]; comboTypeA15.SelectedIndex = Class.Variables.typeIO_DB[15];
            comboType2.SelectedIndex = Class.Variables.typeIO_DB[16]; comboType3.SelectedIndex = Class.Variables.typeIO_DB[17]; comboType4.SelectedIndex = Class.Variables.typeIO_DB[18]; comboType5.SelectedIndex = Class.Variables.typeIO_DB[19];
            comboType6.SelectedIndex = Class.Variables.typeIO_DB[20]; comboType7.SelectedIndex = Class.Variables.typeIO_DB[21]; comboType8.SelectedIndex = Class.Variables.typeIO_DB[22]; comboType9.SelectedIndex = Class.Variables.typeIO_DB[23];
            comboType22.SelectedIndex = Class.Variables.typeIO_DB[24]; comboType23.SelectedIndex = Class.Variables.typeIO_DB[25]; comboType24.SelectedIndex = Class.Variables.typeIO_DB[26]; comboType25.SelectedIndex = Class.Variables.typeIO_DB[27];
            comboType26.SelectedIndex = Class.Variables.typeIO_DB[28]; comboType27.SelectedIndex = Class.Variables.typeIO_DB[29]; comboType28.SelectedIndex = Class.Variables.typeIO_DB[30]; comboType29.SelectedIndex = Class.Variables.typeIO_DB[31];
            comboType30.SelectedIndex = Class.Variables.typeIO_DB[32]; comboType31.SelectedIndex = Class.Variables.typeIO_DB[33]; comboType32.SelectedIndex = Class.Variables.typeIO_DB[34]; comboType33.SelectedIndex = Class.Variables.typeIO_DB[35];
            comboType34.SelectedIndex = Class.Variables.typeIO_DB[36]; comboType35.SelectedIndex = Class.Variables.typeIO_DB[37]; comboType36.SelectedIndex = Class.Variables.typeIO_DB[38]; comboType37.SelectedIndex = Class.Variables.typeIO_DB[39];
            comboType38.SelectedIndex = Class.Variables.typeIO_DB[40]; comboType39.SelectedIndex = Class.Variables.typeIO_DB[41]; comboType40.SelectedIndex = Class.Variables.typeIO_DB[42]; comboType41.SelectedIndex = Class.Variables.typeIO_DB[43];
            comboType42.SelectedIndex = Class.Variables.typeIO_DB[44]; comboType43.SelectedIndex = Class.Variables.typeIO_DB[45]; comboType44.SelectedIndex = Class.Variables.typeIO_DB[46]; comboType45.SelectedIndex = Class.Variables.typeIO_DB[47];
            comboType46.SelectedIndex = Class.Variables.typeIO_DB[48]; comboType47.SelectedIndex = Class.Variables.typeIO_DB[49]; comboType48.SelectedIndex = Class.Variables.typeIO_DB[50]; comboType49.SelectedIndex = Class.Variables.typeIO_DB[51];
            comboType50.SelectedIndex = Class.Variables.typeIO_DB[52]; comboType51.SelectedIndex = Class.Variables.typeIO_DB[53];

            comboColA0.SelectedIndex = Class.Variables.actionCol_DB[0]; comboColA1.SelectedIndex = Class.Variables.actionCol_DB[1]; comboColA2.SelectedIndex = Class.Variables.actionCol_DB[2]; comboColA3.SelectedIndex = Class.Variables.actionCol_DB[3];
            comboColA4.SelectedIndex = Class.Variables.actionCol_DB[4]; comboColA5.SelectedIndex = Class.Variables.actionCol_DB[5]; comboColA6.SelectedIndex = Class.Variables.actionCol_DB[6]; comboColA7.SelectedIndex = Class.Variables.actionCol_DB[7];
            comboColA8.SelectedIndex = Class.Variables.actionCol_DB[8]; comboColA9.SelectedIndex = Class.Variables.actionCol_DB[9]; comboColA10.SelectedIndex = Class.Variables.actionCol_DB[10]; comboColA11.SelectedIndex = Class.Variables.actionCol_DB[11];
            comboColA12.SelectedIndex = Class.Variables.actionCol_DB[12]; comboColA13.SelectedIndex = Class.Variables.actionCol_DB[13]; comboColA14.SelectedIndex = Class.Variables.actionCol_DB[14]; comboColA15.SelectedIndex = Class.Variables.actionCol_DB[15];
            comboCol2.SelectedIndex = Class.Variables.actionCol_DB[16]; comboCol3.SelectedIndex = Class.Variables.actionCol_DB[17]; comboCol4.SelectedIndex = Class.Variables.actionCol_DB[18]; comboCol5.SelectedIndex = Class.Variables.actionCol_DB[19];
            comboCol6.SelectedIndex = Class.Variables.actionCol_DB[20]; comboCol7.SelectedIndex = Class.Variables.actionCol_DB[21]; comboCol8.SelectedIndex = Class.Variables.actionCol_DB[22]; comboCol9.SelectedIndex = Class.Variables.actionCol_DB[23];
            comboCol22.SelectedIndex = Class.Variables.actionCol_DB[24]; comboCol23.SelectedIndex = Class.Variables.actionCol_DB[25]; comboCol24.SelectedIndex = Class.Variables.actionCol_DB[26]; comboCol25.SelectedIndex = Class.Variables.actionCol_DB[27];
            comboCol26.SelectedIndex = Class.Variables.actionCol_DB[28]; comboCol27.SelectedIndex = Class.Variables.actionCol_DB[29]; comboCol28.SelectedIndex = Class.Variables.actionCol_DB[30]; comboCol29.SelectedIndex = Class.Variables.actionCol_DB[31];
            comboCol30.SelectedIndex = Class.Variables.actionCol_DB[32]; comboCol31.SelectedIndex = Class.Variables.actionCol_DB[33]; comboCol32.SelectedIndex = Class.Variables.actionCol_DB[34]; comboCol33.SelectedIndex = Class.Variables.actionCol_DB[35];
            comboCol34.SelectedIndex = Class.Variables.actionCol_DB[36]; comboCol35.SelectedIndex = Class.Variables.actionCol_DB[37]; comboCol36.SelectedIndex = Class.Variables.actionCol_DB[38]; comboCol37.SelectedIndex = Class.Variables.actionCol_DB[39];
            comboCol38.SelectedIndex = Class.Variables.actionCol_DB[40]; comboCol39.SelectedIndex = Class.Variables.actionCol_DB[41]; comboCol40.SelectedIndex = Class.Variables.actionCol_DB[42]; comboCol41.SelectedIndex = Class.Variables.actionCol_DB[43];
            comboCol42.SelectedIndex = Class.Variables.actionCol_DB[44]; comboCol43.SelectedIndex = Class.Variables.actionCol_DB[45]; comboCol44.SelectedIndex = Class.Variables.actionCol_DB[46]; comboCol45.SelectedIndex = Class.Variables.actionCol_DB[47];
            comboCol46.SelectedIndex = Class.Variables.actionCol_DB[48]; comboCol47.SelectedIndex = Class.Variables.actionCol_DB[49]; comboCol48.SelectedIndex = Class.Variables.actionCol_DB[50]; comboCol49.SelectedIndex = Class.Variables.actionCol_DB[51];
            comboCol50.SelectedIndex = Class.Variables.actionCol_DB[52]; comboCol51.SelectedIndex = Class.Variables.actionCol_DB[53];
            
            comboRowA0.SelectedIndex = Class.Variables.actionRow_DB[0]; comboRowA1.SelectedIndex = Class.Variables.actionRow_DB[1]; comboRowA2.SelectedIndex = Class.Variables.actionRow_DB[2]; comboRowA3.SelectedIndex = Class.Variables.actionRow_DB[3];
            comboRowA4.SelectedIndex = Class.Variables.actionRow_DB[4]; comboRowA5.SelectedIndex = Class.Variables.actionRow_DB[5]; comboRowA6.SelectedIndex = Class.Variables.actionRow_DB[6]; comboRowA7.SelectedIndex = Class.Variables.actionRow_DB[7];
            comboRowA8.SelectedIndex = Class.Variables.actionRow_DB[8]; comboRowA9.SelectedIndex = Class.Variables.actionRow_DB[9]; comboRowA10.SelectedIndex = Class.Variables.actionRow_DB[10]; comboRowA11.SelectedIndex = Class.Variables.actionRow_DB[11];
            comboRowA12.SelectedIndex = Class.Variables.actionRow_DB[12]; comboRowA13.SelectedIndex = Class.Variables.actionRow_DB[13]; comboRowA14.SelectedIndex = Class.Variables.actionRow_DB[14]; comboRowA15.SelectedIndex = Class.Variables.actionRow_DB[15];
            comboRow2.SelectedIndex = Class.Variables.actionRow_DB[16]; comboRow3.SelectedIndex = Class.Variables.actionRow_DB[17]; comboRow4.SelectedIndex = Class.Variables.actionRow_DB[18]; comboRow5.SelectedIndex = Class.Variables.actionRow_DB[19];
            comboRow6.SelectedIndex = Class.Variables.actionRow_DB[20]; comboRow7.SelectedIndex = Class.Variables.actionRow_DB[21]; comboRow8.SelectedIndex = Class.Variables.actionRow_DB[22]; comboRow9.SelectedIndex = Class.Variables.actionRow_DB[23];
            comboRow22.SelectedIndex = Class.Variables.actionRow_DB[24]; comboRow23.SelectedIndex = Class.Variables.actionRow_DB[25]; comboRow24.SelectedIndex = Class.Variables.actionRow_DB[26]; comboRow25.SelectedIndex = Class.Variables.actionRow_DB[27];
            comboRow26.SelectedIndex = Class.Variables.actionRow_DB[28]; comboRow27.SelectedIndex = Class.Variables.actionRow_DB[29]; comboRow28.SelectedIndex = Class.Variables.actionRow_DB[30]; comboRow29.SelectedIndex = Class.Variables.actionRow_DB[31];
            comboRow30.SelectedIndex = Class.Variables.actionRow_DB[32]; comboRow31.SelectedIndex = Class.Variables.actionRow_DB[33]; comboRow32.SelectedIndex = Class.Variables.actionRow_DB[34]; comboRow33.SelectedIndex = Class.Variables.actionRow_DB[35];
            comboRow34.SelectedIndex = Class.Variables.actionRow_DB[36]; comboRow35.SelectedIndex = Class.Variables.actionRow_DB[37]; comboRow36.SelectedIndex = Class.Variables.actionRow_DB[38]; comboRow37.SelectedIndex = Class.Variables.actionRow_DB[39];
            comboRow38.SelectedIndex = Class.Variables.actionRow_DB[40]; comboRow39.SelectedIndex = Class.Variables.actionRow_DB[41]; comboRow40.SelectedIndex = Class.Variables.actionRow_DB[42]; comboRow41.SelectedIndex = Class.Variables.actionRow_DB[43];
            comboRow42.SelectedIndex = Class.Variables.actionRow_DB[44]; comboRow43.SelectedIndex = Class.Variables.actionRow_DB[45]; comboRow44.SelectedIndex = Class.Variables.actionRow_DB[46]; comboRow45.SelectedIndex = Class.Variables.actionRow_DB[47];
            comboRow46.SelectedIndex = Class.Variables.actionRow_DB[48]; comboRow47.SelectedIndex = Class.Variables.actionRow_DB[49]; comboRow48.SelectedIndex = Class.Variables.actionRow_DB[50]; comboRow49.SelectedIndex = Class.Variables.actionRow_DB[51];
            comboRow50.SelectedIndex = Class.Variables.actionRow_DB[52]; comboRow51.SelectedIndex = Class.Variables.actionRow_DB[53];

            txtWats_A0.Text = Class.Variables.watts_DB[0].ToString(); txtWats_A1.Text = Class.Variables.watts_DB[1].ToString(); txtWats_A2.Text = Class.Variables.watts_DB[2].ToString(); txtWats_A3.Text = Class.Variables.watts_DB[3].ToString();
            txtWats_A4.Text = Class.Variables.watts_DB[4].ToString(); txtWats_A5.Text = Class.Variables.watts_DB[5].ToString(); txtWats_A6.Text = Class.Variables.watts_DB[6].ToString(); txtWats_A7.Text = Class.Variables.watts_DB[7].ToString();
            txtWats_A8.Text = Class.Variables.watts_DB[8].ToString(); txtWats_A9.Text = Class.Variables.watts_DB[9].ToString(); txtWats_A10.Text = Class.Variables.watts_DB[10].ToString(); txtWats_A11.Text = Class.Variables.watts_DB[11].ToString();
            txtWats_A12.Text = Class.Variables.watts_DB[12].ToString(); txtWats_A13.Text = Class.Variables.watts_DB[13].ToString(); txtWats_A14.Text = Class.Variables.watts_DB[14].ToString(); txtWats_A15.Text = Class.Variables.watts_DB[15].ToString();
            txtWats_2.Text = Class.Variables.watts_DB[16].ToString(); txtWats_3.Text = Class.Variables.watts_DB[17].ToString(); txtWats_4.Text = Class.Variables.watts_DB[18].ToString(); txtWats_5.Text = Class.Variables.watts_DB[19].ToString();
            txtWats_6.Text = Class.Variables.watts_DB[20].ToString(); txtWats_7.Text = Class.Variables.watts_DB[21].ToString(); txtWats_8.Text = Class.Variables.watts_DB[22].ToString(); txtWats_9.Text = Class.Variables.watts_DB[23].ToString();
            txtWats_22.Text = Class.Variables.watts_DB[24].ToString(); txtWats_23.Text = Class.Variables.watts_DB[25].ToString(); txtWats_24.Text = Class.Variables.watts_DB[26].ToString(); txtWats_25.Text = Class.Variables.watts_DB[27].ToString();
            txtWats_26.Text = Class.Variables.watts_DB[28].ToString(); txtWats_27.Text = Class.Variables.watts_DB[29].ToString(); txtWats_28.Text = Class.Variables.watts_DB[30].ToString(); txtWats_29.Text = Class.Variables.watts_DB[31].ToString();
            txtWats_30.Text = Class.Variables.watts_DB[32].ToString(); txtWats_31.Text = Class.Variables.watts_DB[33].ToString(); txtWats_32.Text = Class.Variables.watts_DB[34].ToString(); txtWats_33.Text = Class.Variables.watts_DB[35].ToString();
            txtWats_34.Text = Class.Variables.watts_DB[36].ToString(); txtWats_35.Text = Class.Variables.watts_DB[37].ToString(); txtWats_36.Text = Class.Variables.watts_DB[38].ToString(); txtWats_37.Text = Class.Variables.watts_DB[39].ToString();
            txtWats_38.Text = Class.Variables.watts_DB[40].ToString(); txtWats_39.Text = Class.Variables.watts_DB[41].ToString(); txtWats_40.Text = Class.Variables.watts_DB[42].ToString(); txtWats_41.Text = Class.Variables.watts_DB[43].ToString();
            txtWats_42.Text = Class.Variables.watts_DB[44].ToString(); txtWats_43.Text = Class.Variables.watts_DB[45].ToString(); txtWats_44.Text = Class.Variables.watts_DB[46].ToString(); txtWats_45.Text = Class.Variables.watts_DB[47].ToString();
            txtWats_46.Text = Class.Variables.watts_DB[48].ToString(); txtWats_47.Text = Class.Variables.watts_DB[49].ToString(); txtWats_48.Text = Class.Variables.watts_DB[50].ToString(); txtWats_49.Text = Class.Variables.watts_DB[51].ToString();
            txtWats_50.Text = Class.Variables.watts_DB[52].ToString(); txtWats_51.Text = Class.Variables.watts_DB[53].ToString();

        }

        /// <summary>
        /// Método privado utilizado para atualizar tela de botões, com base
        /// nas seleções dos combobox eu concateno formando um numero único 
        /// para identificar quais botões serão habilitados em função de saidas
        /// casdastradas.
        /// </summary>
        private void enableButtonSelect()
        {
            try
            {
                Class.Variables.enableButtonSelect[0] = comboTypeA0.SelectedIndex.ToString() + comboColA0.SelectedIndex.ToString() + comboRowA0.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[1] = comboTypeA1.SelectedIndex.ToString() + comboColA1.SelectedIndex.ToString() + comboRowA1.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[2] = comboTypeA2.SelectedIndex.ToString() + comboColA2.SelectedIndex.ToString() + comboRowA2.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[3] = comboTypeA3.SelectedIndex.ToString() + comboColA3.SelectedIndex.ToString() + comboRowA3.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[4] = comboTypeA4.SelectedIndex.ToString() + comboColA4.SelectedIndex.ToString() + comboRowA4.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[5] = comboTypeA5.SelectedIndex.ToString() + comboColA5.SelectedIndex.ToString() + comboRowA5.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[6] = comboTypeA6.SelectedIndex.ToString() + comboColA6.SelectedIndex.ToString() + comboRowA6.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[7] = comboTypeA7.SelectedIndex.ToString() + comboColA7.SelectedIndex.ToString() + comboRowA7.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[8] = comboTypeA8.SelectedIndex.ToString() + comboColA8.SelectedIndex.ToString() + comboRowA8.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[9] = comboTypeA9.SelectedIndex.ToString() + comboColA9.SelectedIndex.ToString() + comboRowA9.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[10] = comboTypeA10.SelectedIndex.ToString() + comboColA10.SelectedIndex.ToString() + comboRowA10.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[11] = comboTypeA11.SelectedIndex.ToString() + comboColA11.SelectedIndex.ToString() + comboRowA11.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[12] = comboTypeA12.SelectedIndex.ToString() + comboColA12.SelectedIndex.ToString() + comboRowA12.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[13] = comboTypeA13.SelectedIndex.ToString() + comboColA13.SelectedIndex.ToString() + comboRowA13.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[14] = comboTypeA14.SelectedIndex.ToString() + comboColA14.SelectedIndex.ToString() + comboRowA14.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[15] = comboTypeA15.SelectedIndex.ToString() + comboColA15.SelectedIndex.ToString() + comboRowA15.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[16] = comboType2.SelectedIndex.ToString() + comboCol2.SelectedIndex.ToString() + comboRow2.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[17] = comboType3.SelectedIndex.ToString() + comboCol3.SelectedIndex.ToString() + comboRow3.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[18] = comboType4.SelectedIndex.ToString() + comboCol4.SelectedIndex.ToString() + comboRow4.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[19] = comboType5.SelectedIndex.ToString() + comboCol5.SelectedIndex.ToString() + comboRow5.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[20] = comboType6.SelectedIndex.ToString() + comboCol6.SelectedIndex.ToString() + comboRow6.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[21] = comboType7.SelectedIndex.ToString() + comboCol7.SelectedIndex.ToString() + comboRow7.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[22] = comboType8.SelectedIndex.ToString() + comboCol8.SelectedIndex.ToString() + comboRow8.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[23] = comboType9.SelectedIndex.ToString() + comboCol9.SelectedIndex.ToString() + comboRow9.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[24] = comboType22.SelectedIndex.ToString() + comboCol22.SelectedIndex.ToString() + comboRow22.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[25] = comboType23.SelectedIndex.ToString() + comboCol23.SelectedIndex.ToString() + comboRow23.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[26] = comboType24.SelectedIndex.ToString() + comboCol24.SelectedIndex.ToString() + comboRow24.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[27] = comboType25.SelectedIndex.ToString() + comboCol25.SelectedIndex.ToString() + comboRow25.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[28] = comboType26.SelectedIndex.ToString() + comboCol26.SelectedIndex.ToString() + comboRow26.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[29] = comboType27.SelectedIndex.ToString() + comboCol27.SelectedIndex.ToString() + comboRow27.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[30] = comboType28.SelectedIndex.ToString() + comboCol28.SelectedIndex.ToString() + comboRow28.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[31] = comboType29.SelectedIndex.ToString() + comboCol29.SelectedIndex.ToString() + comboRow29.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[32] = comboType30.SelectedIndex.ToString() + comboCol30.SelectedIndex.ToString() + comboRow30.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[33] = comboType31.SelectedIndex.ToString() + comboCol31.SelectedIndex.ToString() + comboRow31.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[34] = comboType32.SelectedIndex.ToString() + comboCol32.SelectedIndex.ToString() + comboRow32.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[35] = comboType33.SelectedIndex.ToString() + comboCol33.SelectedIndex.ToString() + comboRow33.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[36] = comboType34.SelectedIndex.ToString() + comboCol34.SelectedIndex.ToString() + comboRow34.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[37] = comboType35.SelectedIndex.ToString() + comboCol35.SelectedIndex.ToString() + comboRow35.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[38] = comboType36.SelectedIndex.ToString() + comboCol36.SelectedIndex.ToString() + comboRow36.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[39] = comboType37.SelectedIndex.ToString() + comboCol37.SelectedIndex.ToString() + comboRow37.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[40] = comboType38.SelectedIndex.ToString() + comboCol38.SelectedIndex.ToString() + comboRow38.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[41] = comboType39.SelectedIndex.ToString() + comboCol39.SelectedIndex.ToString() + comboRow39.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[42] = comboType40.SelectedIndex.ToString() + comboCol40.SelectedIndex.ToString() + comboRow40.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[43] = comboType41.SelectedIndex.ToString() + comboCol41.SelectedIndex.ToString() + comboRow41.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[44] = comboType42.SelectedIndex.ToString() + comboCol42.SelectedIndex.ToString() + comboRow42.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[45] = comboType43.SelectedIndex.ToString() + comboCol43.SelectedIndex.ToString() + comboRow43.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[46] = comboType44.SelectedIndex.ToString() + comboCol44.SelectedIndex.ToString() + comboRow44.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[47] = comboType45.SelectedIndex.ToString() + comboCol45.SelectedIndex.ToString() + comboRow45.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[48] = comboType46.SelectedIndex.ToString() + comboCol46.SelectedIndex.ToString() + comboRow46.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[49] = comboType47.SelectedIndex.ToString() + comboCol47.SelectedIndex.ToString() + comboRow47.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[50] = comboType48.SelectedIndex.ToString() + comboCol48.SelectedIndex.ToString() + comboRow48.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[51] = comboType49.SelectedIndex.ToString() + comboCol49.SelectedIndex.ToString() + comboRow49.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[52] = comboType50.SelectedIndex.ToString() + comboCol50.SelectedIndex.ToString() + comboRow50.SelectedIndex.ToString();
                Class.Variables.enableButtonSelect[53] = comboType51.SelectedIndex.ToString() + comboCol51.SelectedIndex.ToString() + comboRow51.SelectedIndex.ToString();
            }
            catch {; }

        }

    }
}
