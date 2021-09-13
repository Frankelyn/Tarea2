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
    /// Interaction logic for rEjercicio5Cap4.xaml
    /// </summary>
    public partial class rEjercicio5Cap4 : Window
    {
        public rEjercicio5Cap4()
        {
            InitializeComponent();
        }

        int Edad = 0;
        int auxiliar = 0;
        int cantidad;
        bool ok = true;
        private void SiguienteEdadButton_Click(object sender, RoutedEventArgs e)
        {
            if (ok)
            {
                cantidad = Convert.ToInt32(CantidadTexbox.Text);
                ok = false;
            }
            
            CantidadTexbox.IsEnabled = false;
            
            Edad = Convert.ToInt32(EdadTexbox.Text);
            auxiliar += Edad;
            EdadTexbox.Clear();
            EdadTexbox.Focus();
            cantidad--;
            if (cantidad < 2)
               {
                  SiguienteEdadButton.IsEnabled = false;
               }

           
            
           
            
        
            
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            Edad = Convert.ToInt32(EdadTexbox.Text);
            auxiliar += Edad;
            int cantidadPersonas;
            int promedio;

            cantidadPersonas = Convert.ToInt32(CantidadTexbox.Text);

            promedio = auxiliar / cantidadPersonas;
            PromedioTextbox.Text = Convert.ToString(promedio);
        }

        
    }
}
