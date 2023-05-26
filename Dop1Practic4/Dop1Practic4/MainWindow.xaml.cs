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

namespace Dop1Practic4
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
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(TbNumberA.Text);
            string description = "";
            if (n >= 10 && n <= 20) 
            {
                switch (n)
                {
                    case 10:
                        description = "десять учебных заданий";
                        break;
                    case 11:
                        description = "одиннадцать учебных заданий";
                        break;
                    case 12:
                        description = "двенадцать учебных заданий";
                        break;
                    case 13:
                        description = "тринадцать учебных заданий";
                        break;
                    case 14:
                        description = "четырнадцать учебных заданий";
                        break;
                    case 15:
                        description = "пятнадцать учебных заданий";
                        break;
                    case 16:
                        description = "шестнадцать учебных заданий";
                        break;
                    case 17:
                        description = "семнадцать учебных заданий";
                        break;
                    case 18:
                        description = "восемнадцать учебных заданий";
                        break;
                    case 19:
                        description = "девятнадцать учебных заданий";
                        break;
                    case 20:
                        description = "двадцать учебных заданий";
                        break;
                }
            }
            else 
            {
                int tens = n / 10;
                int ones = n % 10;

                switch (tens)
                {
                    case 2:
                        description = "двадцать ";
                        break;
                    case 3:
                        description = "тридцать ";
                        break;
                    case 4:
                        description = "сорок ";
                        break;
                }
                switch (ones)
                        {
                            case 1:
                                description += "одно учебное задание";
                                break;
                            case 2:
                                description += "два учебных задания";
                                break;
                            case 3:
                                description += "три учебных задания";
                                break;
                            case 4:
                                description += "четыре учебных задания";
                                break;
                            case 5:
                                description += "пять учебных заданий";
                                break;
                            case 6:
                                description += "шесть учебных заданий";
                                break;
                            case 7:
                                description += "семь учебных заданий";
                                break;
                            case 8:
                                description += "восемь учебных заданий";
                                break;
                            case 9:
                                description += "девять учебных заданий";
                                break;
                        }
            }
            TextBlockAnswer.Text = $"{description}";
        }
    }
}
