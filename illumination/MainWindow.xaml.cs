using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using illumination.KPO;
using illumination.ReserveRatio;
using illumination.Results;
using illumination.Side_illumination;
using illumination.Top_illumination;
namespace illumination
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        MainTopillumination topPage = new MainTopillumination();
        MainSideillumination sidePage = new MainSideillumination();
        public MainWindow()
        {
            InitializeComponent();
        }
            
        private void BtnKPO_Click(object sender, RoutedEventArgs e)
        {
            MainClass.kPODh.ShowDialog();
            Focus();
        }

        private void BtnCoefficientKz_Click(object sender, RoutedEventArgs e)
        {
            MainClass.kz.ShowDialog();
            Focus();
        }


        private void Region4_Checked(object sender, RoutedEventArgs e)
        {
            MainClass.Region = 3;
        }

        private void Region3_Checked(object sender, RoutedEventArgs e)
        {
            MainClass.Region = 2;
        }

        private void Region2_Checked(object sender, RoutedEventArgs e)
        {
            MainClass.Region = 1;
        }

        private void Region1_Checked(object sender, RoutedEventArgs e)
        {
            MainClass.Region = 0;
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox item = (ComboBox)sender;
            if (item.SelectedIndex == 0)
                Frame1.Content = sidePage;
            else if (item.SelectedIndex == 1)
                Frame1.Content = topPage;
        }
        private void ShowLog_Click(object sender, RoutedEventArgs e)
        {
            MainClass.logsWindow.refresh();
            MainClass.logsWindow.ShowDialog();
        }
    }
}
