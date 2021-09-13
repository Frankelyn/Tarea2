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
using System.Windows.Shapes;

namespace Tarea2.UI.Registros
{
    /// <summary>
    /// Interaction logic for rEjercicio4Cap5.xaml
    /// </summary>
    public partial class rEjercicio4Cap5 : Window
    {
        public rEjercicio4Cap5()
        {
            InitializeComponent();
        }

        public int Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);


        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int valor = Convert.ToInt32(NumeroTexbox.Text);
            FactorialTexbox.Text = Convert.ToString(Factorial(valor));

        }
    }
}
