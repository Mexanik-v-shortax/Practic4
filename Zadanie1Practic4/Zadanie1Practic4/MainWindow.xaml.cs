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

namespace Zadanie1Practic4
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
        public void BtnOK_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(TbNumberA.Text);

            switch (m)
            {
                case 1:
                    {
                        TextBlockAnswer.Text= "понедельник";
                    }
                    break;
                case 2:
                    {
                        TextBlockAnswer.Text="вторник";
                    }
                    break;
                case 3:
                    {
                        TextBlockAnswer.Text="среда";
                    }
                    break;
                case 4:
                    {
                        TextBlockAnswer.Text="четверг";
                    }
                    break;
                case 5:
                    {
                        TextBlockAnswer.Text="пятница";
                    }
                    break;
                case 6:
                    {
                        TextBlockAnswer.Text="суббота";
                    }
                    break;
                case 7:
                    {
                        TextBlockAnswer.Text= "воскресенье";
                    }
                    break;
                default:
                    { TextBlockAnswer.Text="Неверный номер дня недели."; }
                    break;
            }
        }
    }
}
