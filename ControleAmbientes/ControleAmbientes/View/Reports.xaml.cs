using System;
using System.Windows;

namespace ControleAmbientes.View
{
    /// <summary>
    /// Lógica interna para Reports.xaml
    /// </summary>
    public partial class Reports : Window
    {

        Class.CRUD crud = new Class.CRUD();

        public Reports()
        {
            InitializeComponent();
        }

        private void btFiltrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridData.DataContext = crud.FillDataGridData(dataInicial.SelectedDate.Value.ToString("yyyy/MM/dd 00:00:00"), dataFinal.SelectedDate.Value.ToString("yyyy/MM/dd 23:59:59"));
            }
            catch
            {
                MessageBox.Show("Favor informar datas para realizar uma consulta", "! ! ! Atenção ! ! !", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
