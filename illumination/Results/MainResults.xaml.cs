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
using System.Windows.Shapes;

namespace illumination.Results
{
    /// <summary>
    /// Логика взаимодействия для MainResults.xaml
    /// </summary>
    public partial class MainResults : Window
    {
        public MainResults()
        {
            InitializeComponent();
        }
        
        public void Refresh(string answer)
        {
            Lbl0.Content = answer;
        }

        private void BtnGood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
