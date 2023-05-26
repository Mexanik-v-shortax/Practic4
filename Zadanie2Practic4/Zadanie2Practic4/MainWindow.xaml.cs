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

namespace Zadanie2Practic4
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
            double result = 0;
            double N = Convert.ToInt32(textBoxNNCards.Text);
            double M = Convert.ToInt32(textBoxNumber.Text);


            switch (M)
            {
                case 6:
                    Result.Content = $"шестерка";
                    break;
                case 7:
                    Result.Content = $"семерка";
                    break;
                case 8:
                    Result.Content = $"восьмерка";
                    break;
                case 9:
                    Result.Content = $"девятка";
                    break;
                case 10:
                    Result.Content = $"десятка";
                    break;
                case 11:
                    Result.Content = $"валет";
                    break;
                case 12:
                    Result.Content = $"дама";
                    break;
                case 13:
                    Result.Content = $"король";
                    break;
                case 14:
                    Result.Content = $"король";
                    break;
                case 15:
                    Result.Content = $"король";
                    break;

            }
            switch (N)
            {
                case 1:
                    Result2.Content = $"Пика";
                    break;
                case 2:
                    Result2.Content = $"Крести";
                    break;
                case 3:
                    Result2.Content = $"Бубен";
                    break;
                case 4:
                    Result2.Content = $"черви";
                    break;

            }

        }
    }
}
