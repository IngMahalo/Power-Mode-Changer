using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PowerMode
{

    public class Element
    {
        public String Name { get; set; }
        public String Scheme { get; set; }
        public int Index { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Element> list = new List<Element>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void loadListOfPowerOptions()
        {
            string output = executeCommand("powercfg /L");
            int count = 0;
            foreach (var myString in output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (count > 1)
                {
                    var itemlist = myString.Substring(19).Split(' ').ToList();
                    list.Add(new Element { Scheme = itemlist[0], Name = itemlist[1] });
                }
                count++;
            }
            lvSchemes.ItemsSource = null;
            lvSchemes.ItemsSource = list;
        }

        public string executeCommand(string command)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                return result;
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            loadListOfPowerOptions();
        }

        private void miSetAsActive_Click(object sender, RoutedEventArgs e)
        {
            if (lvSchemes.SelectedValue == null)
            {
                return ;
            }
            MessageBox.Show(((Element)lvSchemes.SelectedItem).Name);
        }
    }
}
