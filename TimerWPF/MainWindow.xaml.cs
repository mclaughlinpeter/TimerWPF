using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimerWPF
{
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        TimeSpan Duration = TimeSpan.Zero;

        public MainWindow()
        {
            InitializeComponent();

            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Duration += TimeSpan.FromSeconds(1);
            lbl_Timer.Content = Duration.ToString();
        }

        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            Duration = TimeSpan.Zero;
            lbl_Timer.Content = Duration.ToString();
        }

        private void btn_Nudge_Click(object sender, RoutedEventArgs e)
        {
            Duration += TimeSpan.FromMinutes(5);
            lbl_Timer.Content = Duration.ToString();
        }
    }
}
