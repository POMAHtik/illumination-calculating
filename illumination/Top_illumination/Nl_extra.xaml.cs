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

namespace illumination.Top_illumination
{
    /// <summary>
    /// Логика взаимодействия для Nl_extra.xaml
    /// </summary>
    public partial class Nl_extra : Window
    {

        public Nl_extra()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            getDataBack();
            Hide();
        }

        public double widthOfRoom = -1;
        public double s1 = -1;
        public double s2 = -1;
        public double sb = -1;

        public double lp = -1;
        public double H = -1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double tmp;
            if (!double.TryParse(TxtS1.Text, out tmp))
            {
                MessageBox.Show("Введіть площу вхідного отвору!", "Помилка", MessageBoxButton.OK);
                return;
            }
            
            if (!double.TryParse(TxtS2.Text, out tmp))
            {
                MessageBox.Show("Введіть площу вихідного отвору!", "Помилка", MessageBoxButton.OK);
                return;
            }
            
            if (!double.TryParse(TxtSb.Text, out tmp))
            {
                MessageBox.Show("Введіть площу бічної поверхні ліхтаря!", "Помилка", MessageBoxButton.OK);
                return;
            }
            
            if (!double.TryParse(TxtLp.Text, out tmp))
            {
                MessageBox.Show("Введіть довжину приміщення вздовж осі прогонів!", "Помилка", MessageBoxButton.OK);
                return;
            }

            if (tmp>widthOfRoom)
            {
                MessageBox.Show("Довжина приміщення вздовж осі прогонів не може бути більше ширини приміщення!", "Помилка", MessageBoxButton.OK);
                return;
            }   
            
            if(!double.TryParse(TxtH.Text, out tmp))
            {
                MessageBox.Show("Введіть висоту покрівлі над робочою поверхнею!", "Помилка", MessageBoxButton.OK);
                return;
            }

            lp = double.Parse(TxtLp.Text);
            s2 = double.Parse(TxtS2.Text);
            sb = double.Parse(TxtSb.Text);
            H = double.Parse(TxtH.Text);
            s1 = double.Parse(TxtS1.Text);
            this.Hide();
        }

        Regex regex = new Regex("[^0-9,]+");
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = regex.IsMatch(e.Text);
        }

        private void getDataBack()
        {
            TxtS1.Text = s1==-1?"":s1.ToString();
            TxtS2.Text = s2 == -1 ? "" : s2.ToString();
            TxtSb.Text = sb == -1 ? "" : sb.ToString();
            TxtH.Text = H == -1 ? "" : H.ToString();
            TxtLp.Text = lp == -1 ? "" : lp.ToString();
        }
    }
}
