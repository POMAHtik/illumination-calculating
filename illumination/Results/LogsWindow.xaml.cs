using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Shapes;
using illumination;
namespace illumination.Results
{
    /// <summary>
    /// Логика взаимодействия для LogsWindow.xaml
    /// </summary>
    public partial class LogsWindow : Window
    {
        public int NumberOfCalculations = 1;

        public string Log = "";

        public LogsWindow()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            LogBox.Text = Log;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("log.txt");
                sw.WriteLine(LogBox.Text);
                sw.Close();
                sw.Dispose();
            }
            catch(IOException)
            {
                MessageBox.Show("Невідома помилка при роботі з файлом");
                return;
            }
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   
            Log = "";
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
