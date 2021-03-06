using System;
using System.Collections.Generic;
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

        public ModbusTCP.Master MBmaster = new ModbusTCP.Master();
        public Configuration()
        {
            InitializeComponent();
            timerUpdateValues.Interval = System.TimeSpan.FromMilliseconds(500);
            timerUpdateValues.Tick += TimerUpdateValues_Tick;
            timerUpdateValues.Start();
        }

        /// <summary>
        /// Metodo atualiza dados quando 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            updateConfig();

            //Update variaveis globais estaticas
            updateGlobalVar();

            //Atualiza variaveis globais seletoras
            enableButtonSelect();

            //Limpa os dados da Lista utilizada
            Class.Variables.enableButton.Clear();

            //Adicona valores novos a Lista Limpa 
            Class.Variables.enableButton.AddRange(Class.Variables.enableButtonSelect);
        }

        private void TimerUpdateValues_Tick(object sender, System.EventArgs e)
        {
            UpdateCombosTextsBlock_A();
            UpdateCombosTextsBlock_B();
            UpdateCombosTextsBlock_C();
            UpdateCombosTextsBlock_D();
        }

        #region Somente campos numericos e validação de Valores 

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
            if (Class.Variables.admin)
            {
                if (MessageBox.Show("Definir esses dados como padrão?", "! ! ! Atenção ! ! !", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    //Update variaveis globais estaticas
                    updateGlobalVar();

                    //Atualiza variaveis globais seletoras
                    enableButtonSelect();

                    //Lista que faz uma pre verificação de dados em conflito
                    List<String> verifyValue = new List<String>(54);
                    verifyValue.Clear(); verifyValue.AddRange(Class.Variables.enableButtonSelect);

                    //Código de proteção que interrompe o ciclo de salvamento por inconsistência
                    for (int z = 0; z < 54; z++)
                    {
                        int count = 0;

                        for (int y = 0; y < 54; y++)
                        {

                            count = (verifyValue[z].Equals(verifyValue[y]) && int.Parse(verifyValue[z].Substring(0, 1)) > 1 && !verifyValue[z].Equals("0-1-1")) ? count + 1 : count;
                        }

                        if (count > 1)
                        {
                            string mensagem = "! ! ! Dados em conflito ! ! ! \n NÃO podemos ter 2 IO Tipo Saída. \n Com o mesmo tipo de ação.";

                            MessageBox.Show(mensagem, "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }

                    }

                    //Limpa os dados da Lista utilizada
                    Class.Variables.enableButton.Clear();

                    //Adicona valores novos a Lista Limpa 
                    Class.Variables.enableButton.AddRange(Class.Variables.enableButtonSelect);

                    //Concatena valores dos octetos para formar o IP do arduino
                    string ip_Arduino = txtFirstOcteto.Text + "." + txtSecondOcteto.Text + "." + txtThirdOcteto.Text + "." + txtFourthOcteto.Text;

                    Class.Variables.d_DateTime = System.DateTime.Now;

                    //Salva dados no banco, aqui eu utilizo apenas 1 registro pois não quero ter mais de uma configuração, mas poderia ter controle de alterações apenas
                    //mudando o valor 1 para uma valor sequencial.
                    crud.SaveConfig(1, Class.Variables.d_DateTime, ip_Arduino, Class.Variables.typeIO_DB, Class.Variables.actionCol_DB, Class.Variables.actionRow_DB, Class.Variables.watts_DB);

                    MessageBox.Show("Dados Salvos com Sucesso", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Information);

                    setListPot();
                    updateActionModbus();

                }
            }
            else
            {
                MessageBox.Show("Função destinada somente a Administradores.", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            
        }


        private void btUploadData_Click(object sender, RoutedEventArgs e)
        {
            updateConfig();
        }

        private void btSendArduino_Click(object sender, RoutedEventArgs e)
        {
            if (!MBmaster.connected) { MBmaster.connect(Class.Variables.c_IpArduinoConfig, 502, false); }

            if (MBmaster.connected) { MessageBox.Show("Conectado com Sucesso", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Information); }
            else { MessageBox.Show("Falha na Conexão", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Information); }

        }

        /// <summary>
        /// Método publico utilizado para ligar e desligar
        /// o IO no arduino atraves da biblioteca ModBusTCP
        /// </summary>
        /// <param name="StartAddress"></param>
        /// <param name="data"></param>
        public void actionCoilModbus(ushort StartAddress, bool data)
        {
            ushort ID = 5;
            byte unit = Convert.ToByte("0");

            MBmaster.WriteSingleCoils(ID, unit, StartAddress, data);
        }

        public void updateGlobalVar()
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
            Class.Variables.actionCol_DB[40] = comboCol38.SelectedIndex;
            Class.Variables.actionCol_DB[41] = comboCol39.SelectedIndex;
            Class.Variables.actionCol_DB[42] = comboCol40.SelectedIndex;
            Class.Variables.actionCol_DB[43] = comboCol41.SelectedIndex;

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

            #region Block Watts
            //Block Watts
            Class.Variables.watts_DB[0] = !txtWats_A0.Text.Equals("") ? int.Parse(txtWats_A0.Text) : Class.Variables.watts_DB[0]; Class.Variables.watts_DB[1] = !txtWats_A1.Text.Equals("") ? int.Parse(txtWats_A1.Text) : Class.Variables.watts_DB[1];
            Class.Variables.watts_DB[2] = !txtWats_A2.Text.Equals("") ? int.Parse(txtWats_A2.Text) : Class.Variables.watts_DB[2]; Class.Variables.watts_DB[3] = !txtWats_A3.Text.Equals("") ? int.Parse(txtWats_A3.Text) : Class.Variables.watts_DB[3];
            Class.Variables.watts_DB[4] = !txtWats_A4.Text.Equals("") ? int.Parse(txtWats_A4.Text) : Class.Variables.watts_DB[4]; Class.Variables.watts_DB[5] = !txtWats_A5.Text.Equals("") ? int.Parse(txtWats_A5.Text) : Class.Variables.watts_DB[5];
            Class.Variables.watts_DB[6] = !txtWats_A6.Text.Equals("") ? int.Parse(txtWats_A6.Text) : Class.Variables.watts_DB[6]; Class.Variables.watts_DB[7] = !txtWats_A7.Text.Equals("") ? int.Parse(txtWats_A7.Text) : Class.Variables.watts_DB[7];
            Class.Variables.watts_DB[8] = !txtWats_A8.Text.Equals("") ? int.Parse(txtWats_A8.Text) : Class.Variables.watts_DB[8]; Class.Variables.watts_DB[9] = !txtWats_A9.Text.Equals("") ? int.Parse(txtWats_A9.Text) : Class.Variables.watts_DB[9];
            Class.Variables.watts_DB[10] = !txtWats_A10.Text.Equals("") ? int.Parse(txtWats_A10.Text) : Class.Variables.watts_DB[10]; Class.Variables.watts_DB[11] = !txtWats_A11.Text.Equals("") ? int.Parse(txtWats_A11.Text) : Class.Variables.watts_DB[11];
            Class.Variables.watts_DB[12] = !txtWats_A12.Text.Equals("") ? int.Parse(txtWats_A12.Text) : Class.Variables.watts_DB[12]; Class.Variables.watts_DB[13] = !txtWats_A13.Text.Equals("") ? int.Parse(txtWats_A13.Text) : Class.Variables.watts_DB[13];
            Class.Variables.watts_DB[14] = !txtWats_A14.Text.Equals("") ? int.Parse(txtWats_A14.Text) : Class.Variables.watts_DB[14]; Class.Variables.watts_DB[15] = !txtWats_A15.Text.Equals("") ? int.Parse(txtWats_A15.Text) : Class.Variables.watts_DB[15];
            Class.Variables.watts_DB[16] = !txtWats_2.Text.Equals("") ? int.Parse(txtWats_2.Text) : Class.Variables.watts_DB[16]; Class.Variables.watts_DB[17] = !txtWats_3.Text.Equals("") ? int.Parse(txtWats_3.Text) : Class.Variables.watts_DB[17];
            Class.Variables.watts_DB[18] = !txtWats_4.Text.Equals("") ? int.Parse(txtWats_4.Text) : Class.Variables.watts_DB[18]; Class.Variables.watts_DB[19] = !txtWats_5.Text.Equals("") ? int.Parse(txtWats_5.Text) : Class.Variables.watts_DB[19];
            Class.Variables.watts_DB[20] = !txtWats_6.Text.Equals("") ? int.Parse(txtWats_6.Text) : Class.Variables.watts_DB[20]; Class.Variables.watts_DB[21] = !txtWats_7.Text.Equals("") ? int.Parse(txtWats_7.Text) : Class.Variables.watts_DB[21];
            Class.Variables.watts_DB[22] = !txtWats_8.Text.Equals("") ? int.Parse(txtWats_8.Text) : Class.Variables.watts_DB[22]; Class.Variables.watts_DB[23] = !txtWats_9.Text.Equals("") ? int.Parse(txtWats_9.Text) : Class.Variables.watts_DB[23];
            Class.Variables.watts_DB[24] = !txtWats_22.Text.Equals("") ? int.Parse(txtWats_22.Text) : Class.Variables.watts_DB[24]; Class.Variables.watts_DB[25] = !txtWats_23.Text.Equals("") ? int.Parse(txtWats_23.Text) : Class.Variables.watts_DB[25];
            Class.Variables.watts_DB[26] = !txtWats_24.Text.Equals("") ? int.Parse(txtWats_24.Text) : Class.Variables.watts_DB[26]; Class.Variables.watts_DB[27] = !txtWats_25.Text.Equals("") ? int.Parse(txtWats_25.Text) : Class.Variables.watts_DB[27];
            Class.Variables.watts_DB[28] = !txtWats_26.Text.Equals("") ? int.Parse(txtWats_26.Text) : Class.Variables.watts_DB[28]; Class.Variables.watts_DB[29] = !txtWats_27.Text.Equals("") ? int.Parse(txtWats_27.Text) : Class.Variables.watts_DB[29];
            Class.Variables.watts_DB[30] = !txtWats_28.Text.Equals("") ? int.Parse(txtWats_28.Text) : Class.Variables.watts_DB[30]; Class.Variables.watts_DB[31] = !txtWats_29.Text.Equals("") ? int.Parse(txtWats_29.Text) : Class.Variables.watts_DB[31];
            Class.Variables.watts_DB[32] = !txtWats_30.Text.Equals("") ? int.Parse(txtWats_30.Text) : Class.Variables.watts_DB[32]; Class.Variables.watts_DB[33] = !txtWats_31.Text.Equals("") ? int.Parse(txtWats_31.Text) : Class.Variables.watts_DB[33];
            Class.Variables.watts_DB[34] = !txtWats_32.Text.Equals("") ? int.Parse(txtWats_32.Text) : Class.Variables.watts_DB[34]; Class.Variables.watts_DB[35] = !txtWats_33.Text.Equals("") ? int.Parse(txtWats_33.Text) : Class.Variables.watts_DB[35];
            Class.Variables.watts_DB[36] = !txtWats_34.Text.Equals("") ? int.Parse(txtWats_34.Text) : Class.Variables.watts_DB[36]; Class.Variables.watts_DB[37] = !txtWats_35.Text.Equals("") ? int.Parse(txtWats_35.Text) : Class.Variables.watts_DB[37];
            Class.Variables.watts_DB[38] = !txtWats_36.Text.Equals("") ? int.Parse(txtWats_36.Text) : Class.Variables.watts_DB[38]; Class.Variables.watts_DB[39] = !txtWats_37.Text.Equals("") ? int.Parse(txtWats_37.Text) : Class.Variables.watts_DB[39];
            Class.Variables.watts_DB[40] = !txtWats_38.Text.Equals("") ? int.Parse(txtWats_38.Text) : Class.Variables.watts_DB[40]; Class.Variables.watts_DB[41] = !txtWats_39.Text.Equals("") ? int.Parse(txtWats_39.Text) : Class.Variables.watts_DB[41];
            Class.Variables.watts_DB[42] = !txtWats_40.Text.Equals("") ? int.Parse(txtWats_40.Text) : Class.Variables.watts_DB[42]; Class.Variables.watts_DB[43] = !txtWats_41.Text.Equals("") ? int.Parse(txtWats_41.Text) : Class.Variables.watts_DB[43];
            Class.Variables.watts_DB[44] = !txtWats_42.Text.Equals("") ? int.Parse(txtWats_42.Text) : Class.Variables.watts_DB[44]; Class.Variables.watts_DB[45] = !txtWats_43.Text.Equals("") ? int.Parse(txtWats_43.Text) : Class.Variables.watts_DB[45];
            Class.Variables.watts_DB[46] = !txtWats_44.Text.Equals("") ? int.Parse(txtWats_44.Text) : Class.Variables.watts_DB[46]; Class.Variables.watts_DB[47] = !txtWats_45.Text.Equals("") ? int.Parse(txtWats_45.Text) : Class.Variables.watts_DB[47];
            Class.Variables.watts_DB[48] = !txtWats_46.Text.Equals("") ? int.Parse(txtWats_46.Text) : Class.Variables.watts_DB[48]; Class.Variables.watts_DB[49] = !txtWats_47.Text.Equals("") ? int.Parse(txtWats_47.Text) : Class.Variables.watts_DB[49];
            Class.Variables.watts_DB[50] = !txtWats_48.Text.Equals("") ? int.Parse(txtWats_48.Text) : Class.Variables.watts_DB[50]; Class.Variables.watts_DB[51] = !txtWats_49.Text.Equals("") ? int.Parse(txtWats_49.Text) : Class.Variables.watts_DB[51];
            Class.Variables.watts_DB[52] = !txtWats_50.Text.Equals("") ? int.Parse(txtWats_50.Text) : Class.Variables.watts_DB[52]; Class.Variables.watts_DB[53] = !txtWats_51.Text.Equals("") ? int.Parse(txtWats_51.Text) : Class.Variables.watts_DB[53];

            #endregion
        }

        /// <summary>
        /// Método privado atualiza campos da tela configurações com base
        /// na classe variaveis que manipula os dados de forma estática 
        /// servindo como memória de acesso global.
        /// </summary>
        public void updateConfig()
        {
            crud.UpdateConfig(ref Class.Variables.d_DateTime, ref Class.Variables.c_IpArduinoConfig, ref Class.Variables.typeIO_DB, ref Class.Variables.actionCol_DB, ref Class.Variables.actionRow_DB, ref Class.Variables.watts_DB);

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
        /// Método publico utilizado para atualizar tela de botões, com base
        /// nas seleções dos combobox eu concateno formando um numero único 
        /// para identificar quais botões serão habilitados em função de saidas
        /// casdastradas.
        /// </summary>
        public void enableButtonSelect()
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

        /// <summary>
        /// Metodo publico cria lista com as cargas para lincar na base de dados
        /// quando os botões sofrerem ações
        /// </summary>
       public void setListPot()
        {
            try
            {
                Class.Variables.watts.Clear();
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[0], txtWats_A0.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[1], txtWats_A1.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[2], txtWats_A2.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[3], txtWats_A3.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[4], txtWats_A4.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[5], txtWats_A5.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[6], txtWats_A6.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[7], txtWats_A7.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[8], txtWats_A8.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[9], txtWats_A9.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[10], txtWats_A10.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[11], txtWats_A11.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[12], txtWats_A12.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[13], txtWats_A13.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[14], txtWats_A14.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[15], txtWats_A15.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[16], txtWats_2.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[17], txtWats_3.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[18], txtWats_4.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[19], txtWats_5.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[20], txtWats_6.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[21], txtWats_7.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[22], txtWats_8.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[23], txtWats_9.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[24], txtWats_22.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[25], txtWats_23.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[26], txtWats_24.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[27], txtWats_25.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[28], txtWats_26.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[29], txtWats_27.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[30], txtWats_28.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[31], txtWats_29.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[32], txtWats_30.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[33], txtWats_31.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[34], txtWats_32.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[35], txtWats_33.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[36], txtWats_34.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[37], txtWats_35.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[38], txtWats_36.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[39], txtWats_37.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[40], txtWats_38.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[41], txtWats_39.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[42], txtWats_40.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[43], txtWats_41.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[44], txtWats_42.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[45], txtWats_43.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[46], txtWats_44.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[47], txtWats_45.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[48], txtWats_46.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[49], txtWats_47.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[50], txtWats_48.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[51], txtWats_49.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[52], txtWats_50.Text));
                Class.Variables.watts.Add(new Class.Watts(Class.Variables.enableButtonSelect[53], txtWats_51.Text));
            }
            catch {; }
            finally
            {
                for (int p = 0; p <= 53; p++)
                {
                    Class.Variables.poten[0] = (Class.Variables.watts[p].ID == "200" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[0];
                    Class.Variables.poten[1] = (Class.Variables.watts[p].ID == "201" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[1];
                    Class.Variables.poten[2] = (Class.Variables.watts[p].ID == "202" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[2];
                    Class.Variables.poten[3] = (Class.Variables.watts[p].ID == "203" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[3];
                    Class.Variables.poten[4] = (Class.Variables.watts[p].ID == "204" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[4];
                    Class.Variables.poten[5] = (Class.Variables.watts[p].ID == "205" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[5];
                    Class.Variables.poten[6] = (Class.Variables.watts[p].ID == "206" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[6];
                    Class.Variables.poten[7] = (Class.Variables.watts[p].ID == "207" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[7];

                    Class.Variables.poten[8] = (Class.Variables.watts[p].ID == "210" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[8];
                    Class.Variables.poten[9] = (Class.Variables.watts[p].ID == "211" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[9];
                    Class.Variables.poten[10] = (Class.Variables.watts[p].ID == "212" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[10];
                    Class.Variables.poten[11] = (Class.Variables.watts[p].ID == "213" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[11];
                    Class.Variables.poten[12] = (Class.Variables.watts[p].ID == "214" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[12];
                    Class.Variables.poten[13] = (Class.Variables.watts[p].ID == "215" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[13];
                    Class.Variables.poten[14] = (Class.Variables.watts[p].ID == "216" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[14];
                    Class.Variables.poten[15] = (Class.Variables.watts[p].ID == "217" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[15];

                    Class.Variables.poten[16] = (Class.Variables.watts[p].ID == "220" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[16];
                    Class.Variables.poten[17] = (Class.Variables.watts[p].ID == "221" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[17];
                    Class.Variables.poten[18] = (Class.Variables.watts[p].ID == "222" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[18];
                    Class.Variables.poten[19] = (Class.Variables.watts[p].ID == "223" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[19];
                    Class.Variables.poten[20] = (Class.Variables.watts[p].ID == "224" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[20];
                    Class.Variables.poten[21] = (Class.Variables.watts[p].ID == "225" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[21];
                    Class.Variables.poten[22] = (Class.Variables.watts[p].ID == "226" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[22];
                    Class.Variables.poten[23] = (Class.Variables.watts[p].ID == "227" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[23];

                    Class.Variables.poten[24] = (Class.Variables.watts[p].ID == "230" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[24];
                    Class.Variables.poten[25] = (Class.Variables.watts[p].ID == "231" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[25];
                    Class.Variables.poten[26] = (Class.Variables.watts[p].ID == "232" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[26];
                    Class.Variables.poten[27] = (Class.Variables.watts[p].ID == "233" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[27];
                    Class.Variables.poten[28] = (Class.Variables.watts[p].ID == "234" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[28];
                    Class.Variables.poten[29] = (Class.Variables.watts[p].ID == "235" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[29];
                    Class.Variables.poten[30] = (Class.Variables.watts[p].ID == "236" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[30];
                    Class.Variables.poten[31] = (Class.Variables.watts[p].ID == "237" && Class.Variables.watts[p].POT != "") ? int.Parse(Class.Variables.watts[p].POT) : Class.Variables.poten[31];

                }
            }
        }

        /// <summary>
        /// Metodo publico responsável por setar as tabelas de ModBus TCP
        /// ao IO do Arduino com o botão para ligar e desligar
        /// </summary>
        public void updateActionModbus()
        {
            int[] selectModBus = new int[54];

            selectModBus[0] = comboTypeA0.SelectedIndex.Equals(2) ? int.Parse(comboTypeA0.SelectedIndex.ToString() + comboColA0.SelectedIndex.ToString() + comboRowA0.SelectedIndex.ToString()) : -1;
            selectModBus[1] = comboTypeA1.SelectedIndex.Equals(2) ? int.Parse(comboTypeA1.SelectedIndex.ToString() + comboColA1.SelectedIndex.ToString() + comboRowA1.SelectedIndex.ToString()) : -1;
            selectModBus[2] = comboTypeA2.SelectedIndex.Equals(2) ? int.Parse(comboTypeA2.SelectedIndex.ToString() + comboColA2.SelectedIndex.ToString() + comboRowA2.SelectedIndex.ToString()) : -1;
            selectModBus[3] = comboTypeA3.SelectedIndex.Equals(2) ? int.Parse(comboTypeA3.SelectedIndex.ToString() + comboColA3.SelectedIndex.ToString() + comboRowA3.SelectedIndex.ToString()) : -1;
            selectModBus[4] = comboTypeA4.SelectedIndex.Equals(2) ? int.Parse(comboTypeA4.SelectedIndex.ToString() + comboColA4.SelectedIndex.ToString() + comboRowA4.SelectedIndex.ToString()) : -1;
            selectModBus[5] = comboTypeA5.SelectedIndex.Equals(2) ? int.Parse(comboTypeA5.SelectedIndex.ToString() + comboColA5.SelectedIndex.ToString() + comboRowA5.SelectedIndex.ToString()) : -1;
            selectModBus[6] = comboTypeA6.SelectedIndex.Equals(2) ? int.Parse(comboTypeA6.SelectedIndex.ToString() + comboColA6.SelectedIndex.ToString() + comboRowA6.SelectedIndex.ToString()) : -1;
            selectModBus[7] = comboTypeA7.SelectedIndex.Equals(2) ? int.Parse(comboTypeA7.SelectedIndex.ToString() + comboColA7.SelectedIndex.ToString() + comboRowA7.SelectedIndex.ToString()) : -1;
            selectModBus[8] = comboTypeA8.SelectedIndex.Equals(2) ? int.Parse(comboTypeA8.SelectedIndex.ToString() + comboColA8.SelectedIndex.ToString() + comboRowA8.SelectedIndex.ToString()) : -1;
            selectModBus[9] = comboTypeA9.SelectedIndex.Equals(2) ? int.Parse(comboTypeA9.SelectedIndex.ToString() + comboColA9.SelectedIndex.ToString() + comboRowA9.SelectedIndex.ToString()) : -1;
            selectModBus[10] = comboTypeA10.SelectedIndex.Equals(2) ? int.Parse(comboTypeA10.SelectedIndex.ToString() + comboColA10.SelectedIndex.ToString() + comboRowA10.SelectedIndex.ToString()) : -1;
            selectModBus[11] = comboTypeA11.SelectedIndex.Equals(2) ? int.Parse(comboTypeA11.SelectedIndex.ToString() + comboColA11.SelectedIndex.ToString() + comboRowA11.SelectedIndex.ToString()) : -1;
            selectModBus[12] = comboTypeA12.SelectedIndex.Equals(2) ? int.Parse(comboTypeA12.SelectedIndex.ToString() + comboColA12.SelectedIndex.ToString() + comboRowA12.SelectedIndex.ToString()) : -1;
            selectModBus[13] = comboTypeA13.SelectedIndex.Equals(2) ? int.Parse(comboTypeA13.SelectedIndex.ToString() + comboColA13.SelectedIndex.ToString() + comboRowA13.SelectedIndex.ToString()) : -1;
            selectModBus[14] = comboTypeA14.SelectedIndex.Equals(2) ? int.Parse(comboTypeA14.SelectedIndex.ToString() + comboColA14.SelectedIndex.ToString() + comboRowA14.SelectedIndex.ToString()) : -1;
            selectModBus[15] = comboTypeA15.SelectedIndex.Equals(2) ? int.Parse(comboTypeA15.SelectedIndex.ToString() + comboColA15.SelectedIndex.ToString() + comboRowA15.SelectedIndex.ToString()) : -1;
            selectModBus[16] = comboType2.SelectedIndex.Equals(2) ? int.Parse(comboType2.SelectedIndex.ToString() + comboCol2.SelectedIndex.ToString() + comboRow2.SelectedIndex.ToString()) : -1;
            selectModBus[17] = comboType3.SelectedIndex.Equals(2) ? int.Parse(comboType3.SelectedIndex.ToString() + comboCol3.SelectedIndex.ToString() + comboRow3.SelectedIndex.ToString()) : -1;
            selectModBus[18] = comboType4.SelectedIndex.Equals(2) ? int.Parse(comboType4.SelectedIndex.ToString() + comboCol4.SelectedIndex.ToString() + comboRow4.SelectedIndex.ToString()) : -1;
            selectModBus[19] = comboType5.SelectedIndex.Equals(2) ? int.Parse(comboType5.SelectedIndex.ToString() + comboCol5.SelectedIndex.ToString() + comboRow5.SelectedIndex.ToString()) : -1;
            selectModBus[20] = comboType6.SelectedIndex.Equals(2) ? int.Parse(comboType6.SelectedIndex.ToString() + comboCol6.SelectedIndex.ToString() + comboRow6.SelectedIndex.ToString()) : -1;
            selectModBus[21] = comboType7.SelectedIndex.Equals(2) ? int.Parse(comboType7.SelectedIndex.ToString() + comboCol7.SelectedIndex.ToString() + comboRow7.SelectedIndex.ToString()) : -1;
            selectModBus[22] = comboType8.SelectedIndex.Equals(2) ? int.Parse(comboType8.SelectedIndex.ToString() + comboCol8.SelectedIndex.ToString() + comboRow8.SelectedIndex.ToString()) : -1;
            selectModBus[23] = comboType9.SelectedIndex.Equals(2) ? int.Parse(comboType9.SelectedIndex.ToString() + comboCol9.SelectedIndex.ToString() + comboRow9.SelectedIndex.ToString()) : -1;
            selectModBus[24] = comboType22.SelectedIndex.Equals(2) ? int.Parse(comboType22.SelectedIndex.ToString() + comboCol22.SelectedIndex.ToString() + comboRow22.SelectedIndex.ToString()) : -1;
            selectModBus[25] = comboType23.SelectedIndex.Equals(2) ? int.Parse(comboType23.SelectedIndex.ToString() + comboCol23.SelectedIndex.ToString() + comboRow23.SelectedIndex.ToString()) : -1;
            selectModBus[26] = comboType24.SelectedIndex.Equals(2) ? int.Parse(comboType24.SelectedIndex.ToString() + comboCol24.SelectedIndex.ToString() + comboRow24.SelectedIndex.ToString()) : -1;
            selectModBus[27] = comboType25.SelectedIndex.Equals(2) ? int.Parse(comboType25.SelectedIndex.ToString() + comboCol25.SelectedIndex.ToString() + comboRow25.SelectedIndex.ToString()) : -1;
            selectModBus[28] = comboType26.SelectedIndex.Equals(2) ? int.Parse(comboType26.SelectedIndex.ToString() + comboCol26.SelectedIndex.ToString() + comboRow26.SelectedIndex.ToString()) : -1;
            selectModBus[29] = comboType27.SelectedIndex.Equals(2) ? int.Parse(comboType27.SelectedIndex.ToString() + comboCol27.SelectedIndex.ToString() + comboRow27.SelectedIndex.ToString()) : -1;
            selectModBus[30] = comboType28.SelectedIndex.Equals(2) ? int.Parse(comboType28.SelectedIndex.ToString() + comboCol28.SelectedIndex.ToString() + comboRow28.SelectedIndex.ToString()) : -1;
            selectModBus[31] = comboType29.SelectedIndex.Equals(2) ? int.Parse(comboType29.SelectedIndex.ToString() + comboCol29.SelectedIndex.ToString() + comboRow29.SelectedIndex.ToString()) : -1;
            selectModBus[32] = comboType30.SelectedIndex.Equals(2) ? int.Parse(comboType30.SelectedIndex.ToString() + comboCol30.SelectedIndex.ToString() + comboRow30.SelectedIndex.ToString()) : -1;
            selectModBus[33] = comboType31.SelectedIndex.Equals(2) ? int.Parse(comboType31.SelectedIndex.ToString() + comboCol31.SelectedIndex.ToString() + comboRow31.SelectedIndex.ToString()) : -1;
            selectModBus[34] = comboType32.SelectedIndex.Equals(2) ? int.Parse(comboType32.SelectedIndex.ToString() + comboCol32.SelectedIndex.ToString() + comboRow32.SelectedIndex.ToString()) : -1;
            selectModBus[35] = comboType33.SelectedIndex.Equals(2) ? int.Parse(comboType33.SelectedIndex.ToString() + comboCol33.SelectedIndex.ToString() + comboRow33.SelectedIndex.ToString()) : -1;
            selectModBus[36] = comboType34.SelectedIndex.Equals(2) ? int.Parse(comboType34.SelectedIndex.ToString() + comboCol34.SelectedIndex.ToString() + comboRow34.SelectedIndex.ToString()) : -1;
            selectModBus[37] = comboType35.SelectedIndex.Equals(2) ? int.Parse(comboType35.SelectedIndex.ToString() + comboCol35.SelectedIndex.ToString() + comboRow35.SelectedIndex.ToString()) : -1;
            selectModBus[38] = comboType36.SelectedIndex.Equals(2) ? int.Parse(comboType36.SelectedIndex.ToString() + comboCol36.SelectedIndex.ToString() + comboRow36.SelectedIndex.ToString()) : -1;
            selectModBus[39] = comboType37.SelectedIndex.Equals(2) ? int.Parse(comboType37.SelectedIndex.ToString() + comboCol37.SelectedIndex.ToString() + comboRow37.SelectedIndex.ToString()) : -1;
            selectModBus[40] = comboType38.SelectedIndex.Equals(2) ? int.Parse(comboType38.SelectedIndex.ToString() + comboCol38.SelectedIndex.ToString() + comboRow38.SelectedIndex.ToString()) : -1;
            selectModBus[41] = comboType39.SelectedIndex.Equals(2) ? int.Parse(comboType39.SelectedIndex.ToString() + comboCol39.SelectedIndex.ToString() + comboRow39.SelectedIndex.ToString()) : -1;
            selectModBus[42] = comboType40.SelectedIndex.Equals(2) ? int.Parse(comboType40.SelectedIndex.ToString() + comboCol40.SelectedIndex.ToString() + comboRow40.SelectedIndex.ToString()) : -1;
            selectModBus[43] = comboType41.SelectedIndex.Equals(2) ? int.Parse(comboType41.SelectedIndex.ToString() + comboCol41.SelectedIndex.ToString() + comboRow41.SelectedIndex.ToString()) : -1;
            selectModBus[44] = comboType42.SelectedIndex.Equals(2) ? int.Parse(comboType42.SelectedIndex.ToString() + comboCol42.SelectedIndex.ToString() + comboRow42.SelectedIndex.ToString()) : -1;
            selectModBus[45] = comboType43.SelectedIndex.Equals(2) ? int.Parse(comboType43.SelectedIndex.ToString() + comboCol43.SelectedIndex.ToString() + comboRow43.SelectedIndex.ToString()) : -1;
            selectModBus[46] = comboType44.SelectedIndex.Equals(2) ? int.Parse(comboType44.SelectedIndex.ToString() + comboCol44.SelectedIndex.ToString() + comboRow44.SelectedIndex.ToString()) : -1;
            selectModBus[47] = comboType45.SelectedIndex.Equals(2) ? int.Parse(comboType45.SelectedIndex.ToString() + comboCol45.SelectedIndex.ToString() + comboRow45.SelectedIndex.ToString()) : -1;
            selectModBus[48] = comboType46.SelectedIndex.Equals(2) ? int.Parse(comboType46.SelectedIndex.ToString() + comboCol46.SelectedIndex.ToString() + comboRow46.SelectedIndex.ToString()) : -1;
            selectModBus[49] = comboType47.SelectedIndex.Equals(2) ? int.Parse(comboType47.SelectedIndex.ToString() + comboCol47.SelectedIndex.ToString() + comboRow47.SelectedIndex.ToString()) : -1;
            selectModBus[50] = comboType48.SelectedIndex.Equals(2) ? int.Parse(comboType48.SelectedIndex.ToString() + comboCol48.SelectedIndex.ToString() + comboRow48.SelectedIndex.ToString()) : -1;
            selectModBus[51] = comboType49.SelectedIndex.Equals(2) ? int.Parse(comboType49.SelectedIndex.ToString() + comboCol49.SelectedIndex.ToString() + comboRow49.SelectedIndex.ToString()) : -1;
            selectModBus[52] = comboType50.SelectedIndex.Equals(2) ? int.Parse(comboType50.SelectedIndex.ToString() + comboCol50.SelectedIndex.ToString() + comboRow50.SelectedIndex.ToString()) : -1;
            selectModBus[53] = comboType51.SelectedIndex.Equals(2) ? int.Parse(comboType51.SelectedIndex.ToString() + comboCol51.SelectedIndex.ToString() + comboRow51.SelectedIndex.ToString()) : -1;

            for (int x = 0; x <= 53; x++)
            {
                switch (selectModBus[x])
                {
                    #region Coluna 1
                    case 200:
                        Class.Variables.modBusAddres[0] = ushort.Parse(x.ToString());
                        break;
                    case 201:
                        Class.Variables.modBusAddres[1] = ushort.Parse(x.ToString());
                        break;
                    case 202:
                        Class.Variables.modBusAddres[2] = ushort.Parse(x.ToString());
                        break;
                    case 203:
                        Class.Variables.modBusAddres[3] = ushort.Parse(x.ToString());
                        break;
                    case 204:
                        Class.Variables.modBusAddres[4] = ushort.Parse(x.ToString());
                        break;
                    case 205:
                        Class.Variables.modBusAddres[5] = ushort.Parse(x.ToString());
                        break;
                    case 206:
                        Class.Variables.modBusAddres[6] = ushort.Parse(x.ToString());
                        break;
                    case 207:
                        Class.Variables.modBusAddres[7] = ushort.Parse(x.ToString());
                        break;
                    #endregion

                    #region Coluna 2
                    case 210:
                        Class.Variables.modBusAddres[8] = ushort.Parse(x.ToString());
                        break;
                    case 211:
                        Class.Variables.modBusAddres[9] = ushort.Parse(x.ToString());
                        break;
                    case 212:
                        Class.Variables.modBusAddres[10] = ushort.Parse(x.ToString());
                        break;
                    case 213:
                        Class.Variables.modBusAddres[11] = ushort.Parse(x.ToString());
                        break;
                    case 214:
                        Class.Variables.modBusAddres[12] = ushort.Parse(x.ToString());
                        break;
                    case 215:
                        Class.Variables.modBusAddres[13] = ushort.Parse(x.ToString());
                        break;
                    case 216:
                        Class.Variables.modBusAddres[14] = ushort.Parse(x.ToString());
                        break;
                    case 217:
                        Class.Variables.modBusAddres[15] = ushort.Parse(x.ToString());
                        break;
                    #endregion

                    #region Coluna 3
                    case 220:
                        Class.Variables.modBusAddres[16] = ushort.Parse(x.ToString());
                        break;
                    case 221:
                        Class.Variables.modBusAddres[17] = ushort.Parse(x.ToString());
                        break;
                    case 222:
                        Class.Variables.modBusAddres[18] = ushort.Parse(x.ToString());
                        break;
                    case 223:
                        Class.Variables.modBusAddres[19] = ushort.Parse(x.ToString());
                        break;
                    case 224:
                        Class.Variables.modBusAddres[20] = ushort.Parse(x.ToString());
                        break;
                    case 225:
                        Class.Variables.modBusAddres[21] = ushort.Parse(x.ToString());
                        break;
                    case 226:
                        Class.Variables.modBusAddres[22] = ushort.Parse(x.ToString());
                        break;
                    case 227:
                        Class.Variables.modBusAddres[23] = ushort.Parse(x.ToString());
                        break;
                    #endregion

                    #region Coluna 4
                    case 230:
                        Class.Variables.modBusAddres[24] = ushort.Parse(x.ToString());
                        break;
                    case 231:
                        Class.Variables.modBusAddres[25] = ushort.Parse(x.ToString());
                        break;
                    case 232:
                        Class.Variables.modBusAddres[26] = ushort.Parse(x.ToString());
                        break;
                    case 233:
                        Class.Variables.modBusAddres[27] = ushort.Parse(x.ToString());
                        break;
                    case 234:
                        Class.Variables.modBusAddres[28] = ushort.Parse(x.ToString());
                        break;
                    case 235:
                        Class.Variables.modBusAddres[29] = ushort.Parse(x.ToString());
                        break;
                    case 236:
                        Class.Variables.modBusAddres[30] = ushort.Parse(x.ToString());
                        break;
                    case 237:
                        Class.Variables.modBusAddres[31] = ushort.Parse(x.ToString());
                        break;
                        #endregion
                }
            }

        }

    }
}
