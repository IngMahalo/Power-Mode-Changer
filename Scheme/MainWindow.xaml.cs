using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.IO;
using System.Diagnostics;

namespace Scheme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thread t = new Thread(() => {
                while (true)
                {
                    String currentContent = "";
                    try
                    {
                        String scheme = System.IO.File.ReadAllText($@"{Directory.GetCurrentDirectory()}\scheme.txt");
                        if (!String.IsNullOrWhiteSpace(scheme))
                        {
                            Process p = new Process();
                            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            p.StartInfo.FileName = @"CMD.Exe";
                            p.StartInfo.Arguments = $@"/c powercfg /S {scheme}";
                            p.Start();

                            currentContent = $"{DateTime.Now} - {scheme}";                            
                        }
                        else
                        {
                            currentContent = $"{DateTime.Now} - File empty";
                        }
                    }
                    catch (Exception e)
                    {
                        currentContent = $"{DateTime.Now} - {e.Message}";
                    }

                    Dispatcher.BeginInvoke(new Action(() => {
                        lblCurrentScheme.Content = currentContent;
                    }));
                    Thread.Sleep(1000);
                }
            });
            t.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory());
        }
    }
}
