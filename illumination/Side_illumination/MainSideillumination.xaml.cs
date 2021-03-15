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
using illumination.Results;
namespace illumination.Side_illumination
{
    /// <summary>
    /// Логика взаимодействия для MainSideillumination.xaml
    /// </summary>
    public partial class MainSideillumination : Page
    {
        private static Extras.Calculations.SideCalculations sideCalculations = new Extras.Calculations.SideCalculations();
        public static double HeightOfNeighbourBuilding;
        public static double LengthToNeighbourBuilding;
        public static double LengthOfBuilding;
        public static double WidthOfBuilding;
        public static double LengthToWindow;
        public static double LengthFromWindowToPoint;
        public static double AverageCoefficient;
        public static double Azimuth;
        public static double AzimuthB;

        MainResults mainResults = new MainResults();
        public MainSideillumination()
        {
            InitializeComponent();
        }
        



        private void BtnS_Click(object sender, RoutedEventArgs e)
        {
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

            if ((TxtLengthOfBuilding.Text == "") || (TxtWidthOfBuilding.Text == "") || (TxtLengthToNeighbourBuilding.Text == "") ||
                            (TxtHeightOfNeighbourBuilding.Text == "") || (TxtAzimuth.Text == "") || (TxtAverageCoefficient.Text == "") ||
                            (TxtLengthToWindow.Text == "") || (TxtLengthFromWindowToPoint.Text == ""))
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            try
            {
                LengthOfBuilding = double.Parse(TxtLengthOfBuilding.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну довжину приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                WidthOfBuilding = double.Parse(TxtWidthOfBuilding.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну ширину приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                LengthToNeighbourBuilding = double.Parse(TxtLengthToNeighbourBuilding.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну відстань до сусідньої будівлі!", "Помилка!", MessageBoxButton.OK);
                return;
            }
            
            try
            {
                HeightOfNeighbourBuilding = double.Parse(TxtHeightOfNeighbourBuilding.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну висоту сусідньої будівлі!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                Azimuth = double.Parse(TxtAzimuth.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректний азимут!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(TwoSideLight.IsChecked == true)
                try 
                {
                    AzimuthB = double.Parse(TxtAzimuthB.Text);
                }
                catch
                {
                    MessageBox.Show("Введіть коректний азимут B!", "Помилка!", MessageBoxButton.OK);
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

            try
            {
                LengthToWindow = double.Parse(TxtLengthToWindow.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну відстань від робочої поверхні до верху вікна!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            try
            {
                LengthFromWindowToPoint = double.Parse(TxtLengthFromWindowToPoint.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректну відстань від вікна до розрахункової точки!", "Помилка!", MessageBoxButton.OK);
                return;
            }


            //додаткові перевірки:

            if (WidthOfBuilding < LengthFromWindowToPoint)
            {
                MessageBox.Show("Відстань до розрахункової точки не може бути більше ширини приміщення!", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(Azimuth<0 || Azimuth>360)
            {
                MessageBox.Show("Азимут має лежати в межах [0,360], ну будь ласка", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (TwoSideLight.IsChecked == true)
                if (AzimuthB < 0 || AzimuthB > 360)
                {
                    MessageBox.Show("Азимут має лежати в межах [0,360], ну будь ласка", "Помилка!", MessageBoxButton.OK);
                    return;
                }
            if (LengthOfBuilding <= 0)
            {
                MessageBox.Show("Довжина приміщення не може дорівнювати нулю", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if (WidthOfBuilding <= 0)
            {
                MessageBox.Show("Ширина приміщення не може дорівнювати нулю", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(AverageCoefficient<= 0 ||AverageCoefficient>=1)
            {
                MessageBox.Show("Середньозважений коефіцієнт світловідбивання повинен лежати в межах [0,1]", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(LengthToWindow<=0)
            {
                MessageBox.Show("Відстань від робочої поверхні до верху вікна не може дорівнювати нулю", "Помилка!", MessageBoxButton.OK);
                return;
            }

            if(LengthFromWindowToPoint<0)
            {
                MessageBox.Show("Було допущено від'ємне значення у відстані від вікна до розрахункової точки", "Помилка!", MessageBoxButton.OK);
                return;
            }

            MainClass.logsWindow.Log += $"\nОбчислення №{MainClass.logsWindow.NumberOfCalculations++}\n";
            MainClass.logsWindow.Log += "Бокове освітлення";
            MainClass.logsWindow.Log += (TwoSideLight.IsChecked == true) ? "(Двостороннє):\n" : ":\n";

            MainClass.logsWindow.Log += "\nВхідні данні:\n";
            MainClass.logsWindow.Log += $"Довжина приміщення {LengthOfBuilding}\n";
            MainClass.logsWindow.Log += $"Ширина приміщення {WidthOfBuilding}\n";
            MainClass.logsWindow.Log += $"Відстань до сусіднього будинку {LengthToNeighbourBuilding}\n";
            MainClass.logsWindow.Log += $"Висота сусіднього будинку {HeightOfNeighbourBuilding}\n";
            MainClass.logsWindow.Log += $"Азимут {Azimuth}\n";
            if (TwoSideLight.IsChecked == true) MainClass.logsWindow.Log +=  $"Азимут 2 {AzimuthB}\n";
            MainClass.logsWindow.Log += $"Коефіцієнт відбивання {AverageCoefficient}\n";
            MainClass.logsWindow.Log += $"Відстань від робочої поверхні до верху вікна {LengthToWindow}\n";
            MainClass.logsWindow.Log += $"Відстань від вікна до розрахункової точки {LengthFromWindowToPoint}\n";
            
            MainClass.logsWindow.Log += "\nОбрахунки:\n";

            double n = sideCalculations.nGet(LengthOfBuilding, WidthOfBuilding, LengthToWindow, ref MainClass.logsWindow.Log);
            double Kbud = sideCalculations.KbudGet(LengthToNeighbourBuilding, HeightOfNeighbourBuilding, ref MainClass.logsWindow.Log);
            double m;
            if (TwoSideLight.IsChecked == false)m = sideCalculations.mGet(Azimuth, MainClass.Region, ref MainClass.logsWindow.Log);
            else m = sideCalculations.mGet(Azimuth, AzimuthB, MainClass.Region, ref MainClass.logsWindow.Log);
            double r1 = sideCalculations.r1Get(WidthOfBuilding, LengthToWindow, LengthFromWindowToPoint, AverageCoefficient, ref MainClass.logsWindow.Log);
            
            mainResults.Refresh(sideCalculations.Calculate(MainClass.kPODh.dhValue, MainClass.kz.kzValue, n, Kbud, m, t0.t0, r1, LengthOfBuilding, WidthOfBuilding, ref MainClass.logsWindow.Log));
            mainResults.ShowDialog();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        T.T0 t0 = new T.T0(false);
        private void BtnT0_Click(object sender, RoutedEventArgs e)
        {
            t0.ShowDialog();
            Focus();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TxtAzimuthB.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TxtAzimuthB.Visibility = Visibility.Collapsed;
        }
    }
}
