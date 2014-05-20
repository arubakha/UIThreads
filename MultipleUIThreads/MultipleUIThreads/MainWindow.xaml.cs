using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace MultipleUIThreads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thread thread = Thread.CurrentThread;
            this.DataContext = new
            {
                ThreadId = thread.ManagedThreadId
            };
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                MainWindow w = new MainWindow();
                w.Show();

                w.Closed += (sender2, e2) => w.Dispatcher.InvokeShutdown();

                System.Windows.Threading.Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
