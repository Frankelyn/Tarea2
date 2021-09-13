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
    /// Interaction logic for rEjercicio2Cap4.xaml
    /// </summary>
    public partial class rEjercicio2Cap4 : Window
    {
        public rEjercicio2Cap4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            string valor;
            int Potencia;
            Potencia = Convert.ToInt32(PotenciaTexbox.Text);
           
            int num;
            num = Convert.ToInt32(NumeroTexbox.Text);
            int Resultado = num;

            while (Potencia > 1)
            {
                Resultado *= num;
                Potencia--;
            }

            valor = Convert.ToString(Resultado);
            ResultadoTextbox.Text = valor;

        }
    }
}
