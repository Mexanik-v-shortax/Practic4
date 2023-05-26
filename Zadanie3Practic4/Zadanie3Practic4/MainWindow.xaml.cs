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

namespace Zadanie3Practic4
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
            double r, d, l, s;
            int P = Convert.ToInt32(TbNumberA.Text);
            int Z = Convert.ToInt32(TbNumberB.Text);

            switch (P)
            {
                case 1:
                    r = Z;
                    s = 3.14 * r * r;
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;

                case 2:
                    d = Z;
                    r = d / 2;
                    s = 3.14 * r * r;

                    l = 2 * 3.14 * r;
                    TextBlockAnswer.Text = $"r={r:f2}, s={s:f2}, d={d:f2},l={l:f2}";
                    break;

                case 3:
                    l = Z;
                    r = l / (2 * 3.14);
                    s = 3.14 * r * r;
                    d = 2 * r;

                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;

                case 4:
                    s = Z;
                    r = Math.Sqrt(s / 3.14);
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;
            }
        }
    }
}
