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

namespace WPFProdect
{
    public partial class MainWindow : Window
    {
        public List<int> mass = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(Text.Text, out value))
            {
                Text.Clear();
                mass.Add(value);
                MessageBox.Show("число було успішно додано");
            } else
            {
                MessageBox.Show("неправильне число");
            }

        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (mass.Count()!=0)
            {
                MaxValue.Text = mass.Max() + "";
                Sum.Text = mass.Sum() + "";
                MinValue.Text = mass.Min() + "";
                mediumNumber.Text = mass.Sum() / mass.Count()+"";
                OddNumbers.Text = GetOddNumber();
                mass.Clear();
            } else MessageBox.Show("ви не ввели жодного числа");
        }
        private string GetOddNumber()
        {
            string result="";
            for (var i = 0; i <mass.Count(); i++)
            {
                if (mass[i] % 2 == 0) result += mass[i]+" ";
            }
            return result;
        }
    }
}
