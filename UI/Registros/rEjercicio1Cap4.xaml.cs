using System;
using System.Linq;
using System.Collections.Generic;
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
    /// Interaction logic for Ejercicio1Cap4.xaml
    /// </summary>
    public partial class Ejercicio1Cap4 : Window
    {
        public Ejercicio1Cap4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            string textoResultado;
            string textoMultiplicador;
            string textoNumero;

            int num = 1;
            int auxiliar;
            num = Convert.ToInt32(NumeroTexbox.Text);
            textoNumero = Convert.ToString(num);


            for (int i = 1; i <= 10; i++)
            {
                auxiliar = num * i;
                textoMultiplicador = Convert.ToString(i);
                textoResultado = Convert.ToString(auxiliar);
                ResultadoTextbox.Text += NumeroTexbox.Text + "x" + textoMultiplicador+"= " + textoResultado + "\n";
            }

        }
    }
}
