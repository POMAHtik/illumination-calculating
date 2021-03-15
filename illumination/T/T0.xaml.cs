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
using System.Windows.Shapes;
using System.Collections.Specialized;
using System.ComponentModel;

namespace illumination.T
{
    /// <summary>
    /// Interaction logic for T0.xaml
    /// </summary>
    public partial class T0 : Window
    {

        private double tmpT1 = -1;
        private double tmpT2 = -1;
        private double tmpT3 = -1; //Для бокового освітлення T3=1
        private double tmpT4 = -1;

        public double T1 = -1;
        public double T2 = -1;
        public double T3 = -1; //Для бокового освітлення T3=1
        public double T4 = -1;
        public double T5 = 1;
        public double t0 = -1;

        public T0(bool T3_needed)
        {
            InitializeComponent();
            if (!T3_needed)
            {
                Width -= 320;
                T3 = 1;
                T3_.Visibility = Visibility.Collapsed;
            }
        }
        private void BtnT0Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //T1
        private void GlType_0_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.89;
        }

        private void GlType_1_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.88;
        }

        private void GlType_2_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.87;
        }

        private void GlType_3_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.86;
        }

        private void GlType_4_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.85;
        }

        private void GlType_5_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.83;
        }

        private void GlType_6_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.81;
        }

        private void GlType_7_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.79;
        }

        private void GlType_8_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.76;
        }

        private void GlType_9_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.72;
        }

        private void GlType_10_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.67;
        }

        private void GlType_11_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.6;
        }

        private void GlType_12_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.65;
        }

        private void GlType_13_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.65;
        }

        private void GlType_14_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.75;
        }

        private void GlType_15_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.9;
        }

        private void GlType_16_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.6;
        }

        private void GlType_17_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.5;
        }

        private void GlType_18_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.55;
        }

        private void GlType_19_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.8;
        }

        private void GlType_20_Checked(object sender, RoutedEventArgs e)
        {
            T1 = 0.65;
        }

        //T4
        private void SunGuard_0_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 1;
        }

        private void SunGuard_1_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.75;
        }

        private void SunGuard_2_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.35;
        }

        private void SunGuard_3_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.4;
        }

        private void SunGuard_4_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.65;
        }

        private void SunGuard_5_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.82;
        }

        private void SunGuard_6_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.95;
        }

        private void SunGuard_7_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.6;
        }

        private void SunGuard_8_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.8;
        }

        private void SunGuard_9_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.95;
        }

        private void SunGuard_10_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.95;
        }

        private void SunGuard_11_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.85;
        }

        private void SunGuard_12_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.7;
        }

        private void SunGuard_13_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.6;
        }

        private void SunGuard_14_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.57;
        }

        private void SunGuard_15_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.61;
        }

        private void SunGuard_16_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.54;
        }

        private void SunGuard_17_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.62;
        }

        private void SunGuard_18_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.7;
        }

        private void SunGuard_19_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.55;
        }

        private void SunGuard_20_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.48;
        }

        private void SunGuard_21_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.54;
        }

        private void SunGuard_22_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.52;
        }

        private void SunGuard_23_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.45;
        }

        private void SunGuard_24_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.61;
        }

        private void SunGuard_25_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.5;
        }

        private void SunGuard_26_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.57;
        }

        private void SunGuard_27_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.56;
        }

        private void SunGuard_28_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.49;
        }

        private void SunGuard_29_Checked(object sender, RoutedEventArgs e)
        {
            T4 = 0.32;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            T3 = 0.9;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            T3 = 0.8;
        }


        private void T0Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (T5Check.IsChecked == true)
            {
                T5 = 0.9;
            }
            else T5 = 1;

            if (T1 == -1)
            {
                MessageBox.Show("Виберіть тип скла!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            
            if (T3 == -1)
            {
                MessageBox.Show("Виберіть несучу конструкцію!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            
            if (T4 == -1)
            {
                MessageBox.Show("Виберіть тип сонцезахисного пристрою!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (T2 == -1)
            {
                MessageBox.Show("Виберіть матеріал рами вікна!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            tmpT1 = T1;
            tmpT2 = T2;
            tmpT3 = T3;
            tmpT4 = T4;
            t0 = T1 * T2 * T3 * T4 * T5;
            
            this.Close();
            //тестовий вивід результату
            //MessageBox.Show($"T0 = {t0}\nT1 = {T1}\nT2 = {T2}\nT3 = {T3}\nT4 = {T4}\nT5 = {T5}\n", "Info", MessageBoxButton.OK);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void T2Check_0_Checked(object sender, RoutedEventArgs e)
        {
            T2 = 0.75;
        }

        private void T2Check_1_Checked(object sender, RoutedEventArgs e)
        {
            T2 = 0.85;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            T1 = tmpT1;
            T2 = tmpT2;
            T3 = tmpT3;
            T4 = tmpT4;
            e.Cancel = true;
            Hide();
        }

    }
}
