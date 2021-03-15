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
using illumination;
using illumination.Results;

namespace illumination.Top_illumination
{
    /// <summary>
    /// Логика взаимодействия для MainTopillumination.xaml
    /// </summary>
    public partial class MainTopillumination : Page
    {
        public MainTopillumination()
        {
            InitializeComponent();
        }

        private static Extras.Calculations.TopCalculations topCalculations = new Extras.Calculations.TopCalculations();
        public static double LengthOfRoom;
        public static double WidthOfRoom;
        public static double HeightOfRoom;
        public static int CountProgon;
        public static double WidthProgon;
        public static double LengthToWindow;
        public static double AverageCoefficient;
        public static double Kl;

        MainResults mainResults = new MainResults();







        private void BtnS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LengthOfRoom = double.Parse(TxtLengthOfRoom.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну довжину приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                WidthOfRoom = double.Parse(TxtWidthOfRoom.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну ширину приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                HeightOfRoom = double.Parse(TxtHeightOfRoom.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну висоту приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                WidthProgon = double.Parse(TxtWidthProgon.Text);
                if (WidthProgon > LengthOfRoom)
                {
                    MessageBox.Show("Ширина прогону не може бути більше довжини приміщення!", "Помилка!", MessageBoxButton.OK);
                    return;
                }
                else if (HeightOfRoom / WidthProgon < 0.2 || HeightOfRoom / WidthProgon > 1)
                {
                    MessageBox.Show("Відношення між висотою приміщення і шириною прогону\nмає бути [0.2; 1]!", "Помилка!", MessageBoxButton.OK);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введіть коректну ширину прогону!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                CountProgon = int.Parse(TxtCountProgon.Text);
                if (CountProgon > 3)
                {
                    CountProgon = 3;
                }
            }
            catch
            {
                MessageBox.Show("Введіть коректну кількість прогонів!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (TxtTypeOfLight.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть тип ліхтаря!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (TxtTypeOfLight.SelectedIndex == 0 || TxtTypeOfLight.SelectedIndex == 1)
            {
                if (nl_Extra.lp == -1)
                {
                    MessageBox.Show("Необхідно обрахувати nl!", "Помилка", MessageBoxButton.OK);
                    ShowNl();
                    return;
                }

                if (nl_Extra.s1 == -1 || nl_Extra.s2 == -1 || nl_Extra.sb == -1 || nl_Extra.H == -1 || nl_Extra.lp == -1)
                {
                    MessageBox.Show("Введіть всі данні пов'язані з nл", "Помилка!", MessageBoxButton.OK);
                    return;
                }

                if (nl_Extra.lp > WidthOfRoom)
                {
                    MessageBox.Show("Через зміну ширини приміщення необхідно перерахувати nl!", "Помилка", MessageBoxButton.OK);
                    ShowNl();
                    return;
                }

            }

            try
            {
                LengthToWindow = double.Parse(TxtLengthToWindow.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну відстань від робочої поверхні до нижньої границі засклення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (LengthToWindow > Height)
            {
                MessageBox.Show("Висота від робочої поверхні до нижньої границі засклення\nне може бути більше висоти приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                AverageCoefficient = double.Parse(TxtAverageCoefficient.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректний середньозважений коефіцієнт світловідбивання!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (AverageCoefficient < 0 || AverageCoefficient > 1)
            {
                MessageBox.Show("Середньозважений коефіцієнт світловідбивання має лежати в межах [0, 1]!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            if (MainClass.kPODh.dhValue == -1)
            {
                MessageBox.Show("Розрахуйте Dн!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (MainClass.Region == -1)
            {
                MessageBox.Show("Виберіть область!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (MainClass.kz.kzValue == -1)
            {
                MessageBox.Show("Розрахуйте Kз!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (t0.t0 == -1)
            {
                MessageBox.Show("Розрахуйте τ0!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (LengthOfRoom <= 0)
            {
                MessageBox.Show("Довжина приміщення введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (WidthOfRoom <= 0)
            {
                MessageBox.Show("Ширина приміщення введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(HeightOfRoom <= 0)
            {
                MessageBox.Show("Висота приміщення введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (WidthProgon <= 0)
            {
                MessageBox.Show("Ширина прогону введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (CountProgon <= 0)
            {
                MessageBox.Show("Кількість прогонів введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (LengthToWindow <= 0)
            {
                MessageBox.Show("Відстань від робочої поверхні до нижньої грані засклення введена не коректно!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            MainClass.logsWindow.Log += $"\nОбчислення №{MainClass.logsWindow.NumberOfCalculations++}\n";
            MainClass.logsWindow.Log += "Верхнє освітлення:\n";
            
            MainClass.logsWindow.Log += "\nВхідні данні:\n";
            MainClass.logsWindow.Log += $"Довжина приміщення {LengthOfRoom}\n";
            MainClass.logsWindow.Log += $"Ширина приміщення {WidthOfRoom}\n";
            MainClass.logsWindow.Log += $"Висота приміщення {HeightOfRoom}\n";
            MainClass.logsWindow.Log += $"Ширина прогону {WidthProgon}\n";
            MainClass.logsWindow.Log += $"Кількість прогонів {CountProgon}\n";
            MainClass.logsWindow.Log += $"Тип ліхтаря {TxtTypeOfLight.SelectedItem} (kl = {Kl})\n";
            MainClass.logsWindow.Log += $"Відстань від робочої поверхні до нижньої грані засклення {LengthToWindow}\n";
            MainClass.logsWindow.Log += $"Коефіцієнт відбивання {AverageCoefficient}\n";
            if(TxtTypeOfLight.SelectedIndex > 1)
            {
                MainClass.logsWindow.Log += $"Площа вхідного отвору {nl_Extra.s1}\n";
                MainClass.logsWindow.Log += $"Площа вихідного отвору {nl_Extra.s2}\n";
                MainClass.logsWindow.Log += $"Площа бічної поверхні {nl_Extra.sb}\n";
                MainClass.logsWindow.Log += $"Довжина приміщення вздовж осі прогонів {nl_Extra.lp}\n";
                MainClass.logsWindow.Log += $"Висота покрівлі над робочою поверхнею {nl_Extra.H}\n";

            }
            MainClass.logsWindow.Log += "\nОбрахунки:\n";

            double m = topCalculations.mGet(ref MainClass.logsWindow.Log);
            double n;
            if (TxtTypeOfLight.SelectedIndex > 1) n = topCalculations.nGet(CountProgon, HeightOfRoom, LengthOfRoom,WidthProgon, TxtTypeOfLight.SelectedIndex, ref MainClass.logsWindow.Log);
            else n = topCalculations.nGet(nl_Extra.lp, WidthOfRoom, nl_Extra.H, nl_Extra.s2, nl_Extra.s1, nl_Extra.sb, ref MainClass.logsWindow.Log);
            double r2 = topCalculations.r2Get(CountProgon, AverageCoefficient, LengthToWindow, WidthProgon, ref MainClass.logsWindow.Log);
            
            MainClass.logsWindow.Log += $"t0 = {t0.t0}, T1 = {t0.T1}, T2 = {t0.T2}, T3 = {t0.T3}, T4 = {t0.T4}, T5 = 1\n";
            
            mainResults.Refresh(topCalculations.Calculate(MainClass.kPODh.dhValue, MainClass.kz.kzValue, n, m, t0.t0, r2, Kl, LengthOfRoom, WidthOfRoom, ref MainClass.logsWindow.Log));
            mainResults.Show();
            MainClass.logsWindow.Log += "_______________________________________________________________________________________________________________\n";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        T.T0 t0 = new T.T0(true);
        private void BtnT0_Click(object sender, RoutedEventArgs e)
        {
            t0.ShowDialog();
            Focus();
        }

        Nl_extra nl_Extra = new Nl_extra();
        private void TxtTypeOfLight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox thisItem = (ComboBox)sender;
            if (thisItem.SelectedIndex == 1 || thisItem.SelectedIndex == 0)
            {
                ExtraButton.Visibility = Visibility.Visible;
                thisItem.Width = 260;
                ShowNl();
            }
            else
            {
                ExtraButton.Visibility = Visibility.Collapsed;
                thisItem.Width = 300;
            }
            switch (thisItem.SelectedIndex)
            {
                case 0:
                    Kl = 1;
                    break;
                case 1:
                    Kl = 1.1;
                    break;
                case 2:
                    Kl = 1.15;
                    break;
                case 3:
                    Kl = 1.2;
                    break;
                case 4:
                    Kl = 1.3;
                    break;
                case 5:
                    Kl = 1.4;
                    break;
            }

        }
        private void ShowNl()
        {
            try
            {
                WidthOfRoom = double.Parse(TxtWidthOfRoom.Text);
            }
            catch
            {
                MessageBox.Show("Не забудьте ввести ширину приміщення!", "Помилка", MessageBoxButton.OK);
                return;
            }
            nl_Extra.widthOfRoom = WidthOfRoom;
            nl_Extra.ShowDialog();

        }
        private void ExtraButton_Click(object sender, RoutedEventArgs e)
        {
            ShowNl();
        }
    }
}
    