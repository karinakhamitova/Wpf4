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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar=rateDollar*sumDollar;
            resSum.Text = resDollar.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate2.Text);
            double sumGriv = Convert.ToDouble(sum2.Text);
            double resGriv = rateGriv * sumGriv;
            resSum2.Text = resGriv.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * sumDram;
            resSum3.Text = resDram.ToString();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDum = Convert.ToDouble(leng.Text);
            double resDum = rateDum* 2.54*0.01;
            resLen.Text = resDum.ToString();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double rateFut = Convert.ToDouble(leng1.Text);
            double resFut = rateFut * 30.48 * 0.01;
            resLen1.Text = resFut.ToString();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double rateMil = Convert.ToDouble(leng2.Text);
            double resMil = rateMil * 1.61 * 1000;
            resLen2.Text = resMil.ToString();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double rateVer = Convert.ToDouble(leng3.Text);
            double resVer = rateVer * 1066.8;
            resLen3.Text = resVer.ToString();
        }

    }
}
