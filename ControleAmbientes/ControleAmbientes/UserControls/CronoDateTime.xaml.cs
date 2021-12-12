using System.Windows.Threading;
using System.Windows.Controls;

namespace ControleAmbientes.UserControls
{
    /// <summary>
    /// Interação lógica para CronoDateTime.xam
    /// </summary>
    public partial class CronoDateTime : UserControl
    {

        DispatcherTimer timerUpdateValues = new DispatcherTimer();




        public CronoDateTime()
        {
            InitializeComponent();
            timerUpdateValues.Interval = System.TimeSpan.FromSeconds(1);
            timerUpdateValues.Tick += TimerUpdateValues_Tick;
            timerUpdateValues.Start();
        }

        public void TimerUpdateValues_Tick(object sender, System.EventArgs e)
        {
            data.Content = System.DateTime.Now.ToString("dd/MM/yy");
            hora.Content = System.DateTime.Now.ToString("hh:mm:ss");

        }

    }
}
