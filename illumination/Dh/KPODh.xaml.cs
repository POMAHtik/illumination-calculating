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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace illumination.KPO
{
    /// <summary>
    /// Логика взаимодействия для KPODh.xaml
    /// </summary>
    public partial class KPODh : Window
    {
        public double dhValue = -1;
        private ObservableCollection<Extras.Tables.DnTable.TableBase> activeMatrix;
        
        private void checkForEnabled()
        {
            if (activeMatrix == null) return;
            foreach(var row in activeMatrix)
            {
                if(DhMin.IsChecked == true&& DhSum.IsChecked == true)
                    row.isEnabled = (row.SumDhMin == -1)? false: true;
                else if (DhMin.IsChecked == true && DhSum.IsChecked == false)
                    row.isEnabled = (row.DhMin == -1)?false:true;
                else if (DhMin.IsChecked == false && DhSum.IsChecked == true)
                    row.isEnabled = (row.SumDhSer == -1)? false: true;
                else if (DhMin.IsChecked == false && DhSum.IsChecked == false)
                    row.isEnabled = (row.DhSer == -1)? false:true;
            }
        }

        private void updateValue()
        {
            if (CheckBoxHands.IsChecked == true) return;
            if (activeMatrix == null) return;
            var item = activeMatrix.Where(x => x.isChecked).FirstOrDefault();
            if(item == null)
            {
                HandsValue.Text = "-1";
                return;
            }
            if(item.isEnabled == false)
            {
                item.isChecked = false;
                HandsValue.Text = "-1";
                return;
            }

            if(DhMin.IsChecked == true)
            {
                if (DhSum.IsChecked == true) HandsValue.Text = item.SumDhMin.ToString();
                else HandsValue.Text = item.DhMin.ToString();
            }
            else
            {
                if (DhSum.IsChecked == true) HandsValue.Text = item.SumDhSer.ToString();
                else HandsValue.Text = item.DhSer.ToString();
            }
        }

        public KPODh()
        {
            InitializeComponent();
        }

        private void Rd0_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table1;
            checkForEnabled();
            updateValue();
        }

        private void Rd1_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table2;
            checkForEnabled();
            updateValue();
        }

        private void Rd2_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table3;
            checkForEnabled();
            updateValue();
        }

        private void Rd3_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table4;
            checkForEnabled();
            updateValue();
        }

        private void Rd4_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table5;
            checkForEnabled();
            updateValue();
        }

        private void Rd5_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table6;
            checkForEnabled();
            updateValue();
        }

        private void Rd6_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table7;
            checkForEnabled();
            updateValue();
        }

        private void Rd7_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table8;
            checkForEnabled();
            updateValue();
        }

        private void Rd8_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table9;
            checkForEnabled();
            updateValue();
        }

        private void Rd9_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table10;
            checkForEnabled();
            updateValue();
        }

        private void Rd10_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table11;
            checkForEnabled();
            updateValue();
        }

        private void Rd11_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table12;
            checkForEnabled();
            updateValue();
        }

        private void Rd12_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table13;
            checkForEnabled();
            updateValue();
        }

        private void Rd13_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table14;
            checkForEnabled();
            updateValue();
        }
        private void rd14_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table15;
            checkForEnabled();
            updateValue();
        }

        private void rd15_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table16;
            checkForEnabled();
            updateValue();
        }

        private void rd16_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table17;
            checkForEnabled();
            updateValue();
        }

        private void rd17_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table18;
            checkForEnabled();
            updateValue();
        }

        private void rd18_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table19;
            checkForEnabled();
            updateValue();
        }

        private void rd19_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table20;
            checkForEnabled();
            updateValue();
        }

        private void rd20_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = activeMatrix = Extras.Tables.DnTable.Table21;
            checkForEnabled();
            updateValue();
        }

        private void BtnDh_Click(object sender, RoutedEventArgs e)
        {
            updateValue();
            try
            {
                dhValue = double.Parse(HandsValue.Text);
                if (dhValue <= 0) throw null;
            }
            catch
            {
                MessageBox.Show("Некоректне значення!", "Помилка!");
                return;
            }

            this.Close();
        }

        
        private void CheckBoxHands_Unchecked(object sender, RoutedEventArgs e)
        {
            DhMin.IsEnabled =
                    DhSum.IsEnabled =
                    LstCivilianBuildings.IsEnabled =
                    KpoDataGrid.IsEnabled = true;
            HandsValue.IsEnabled = false;

            updateValue();
        }

        private void CheckBoxHands_Checked(object sender, RoutedEventArgs e)
        {
            DhMin.IsEnabled =
                DhSum.IsEnabled =
                LstCivilianBuildings.IsEnabled =
                KpoDataGrid.IsEnabled = false;
            HandsValue.IsEnabled = true;
            if (HandsValue.Text == "-1") HandsValue.Text = "";
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            checkForEnabled();
            updateValue();
        }
        private void CheckButton_Checked(object sender, RoutedEventArgs e)
        {
            KpoDataGrid.ItemsSource = null;
            KpoDataGrid.ItemsSource = activeMatrix;
            checkForEnabled();
            updateValue();
        }
    }

}
