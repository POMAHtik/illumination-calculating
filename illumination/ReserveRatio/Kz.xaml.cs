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

namespace illumination.ReserveRatio
{
    /// <summary>
    /// Логика взаимодействия для Kz.xaml
    /// </summary>
    public partial class Kz : Window
    {
        private ObservableCollection<Extras.Tables.KzTable.TableBase> activeMatrix;
        private int Angle = -1;
        public double kzValue = -1;
        public Kz()
        {
            InitializeComponent();
            ChooseTypeBox.SelectedIndex = 0;
        }



        private void BtnKz_Click(object sender, RoutedEventArgs e)
        {
            if(CheckBoxHands.IsChecked == true)
            {
                try
                {
                    kzValue = double.Parse(HandsValue.Text);
                    if (kzValue <= 0) throw null;
                }
                catch
                {
                    MessageBox.Show("Введено не коректне значення!", "Помилка!");
                    return;
                }
                this.Close();
                return;
            }

            var item = activeMatrix.Where(x => x.isChecked).FirstOrDefault();
            if (item == null)
            {
                MessageBox.Show("Виберіть один із варіантів з таблиці!", "Помилка!");
                return;
            }
            if(Angle == -1)
            {
                MessageBox.Show("Виберіть один кут нахилу!", "Помилка!");
                return;
            }
            kzValue = item.Coefficient[Angle];
            this.Close();
            return;
        }

        private void showCurrentKz()
        {
            if (CheckBoxHands.IsChecked == true) return;
            var item = activeMatrix.Where(x => x.isChecked).FirstOrDefault();
            if (item == null || Angle == -1)
                HandsValue.Text = "-";
            else HandsValue.Text = item.Coefficient[Angle].ToString();
        }

        private void Rd_0_Checked(object sender, RoutedEventArgs e)
        {
            Angle = 0;
            showCurrentKz();
        }

        private void Rd_1_Checked(object sender, RoutedEventArgs e)
        {
            Angle = 1;
            showCurrentKz();
        }

        private void Rd_2_Checked(object sender, RoutedEventArgs e)
        {
            Angle = 2;
            showCurrentKz();
        }

        private void Rd_3_Checked(object sender, RoutedEventArgs e)
        {
            Angle = 3;
            showCurrentKz();
        }



        private void Window_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void ChooseTypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ChooseTypeBox.SelectedIndex == 0)
                KzDataGrid.ItemsSource = activeMatrix = Extras.Tables.KzTable.Table1;
            else if(ChooseTypeBox.SelectedIndex == 1)
                KzDataGrid.ItemsSource = activeMatrix = Extras.Tables.KzTable.Table2;
            showCurrentKz();
        }

        private void CheckBoxHands_Checked(object sender, RoutedEventArgs e)
        {
            this.KzDataGrid.IsEnabled = 
            this.ChooseTypeBox.IsEnabled = 
            this.LstAngle.IsEnabled = false;
            this.HandsValue.IsEnabled = true;

            if (HandsValue.Text == "-") HandsValue.Text = "";
        }

        private void CheckBoxHands_Unchecked(object sender, RoutedEventArgs e)
        {
            this.KzDataGrid.IsEnabled =
            this.ChooseTypeBox.IsEnabled =
            this.LstAngle.IsEnabled = true;
            this.HandsValue.IsEnabled = false;
            showCurrentKz();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            showCurrentKz();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
