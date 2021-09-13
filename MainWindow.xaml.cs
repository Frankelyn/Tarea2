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
using Tarea2.UI.Registros;

namespace Tarea2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio1Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1Cap4 Ejercicio1Cap4 = new Ejercicio1Cap4();
            Ejercicio1Cap4.Show();

        }

        private void Ejercicio2Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio2Cap4 rEjercicio2Cap4 = new rEjercicio2Cap4();
            rEjercicio2Cap4.Show();
        }

        private void Ejercicio5Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio5Cap4 rEjercicio5Cap4 = new rEjercicio5Cap4();
            rEjercicio5Cap4.Show();
        }

        private void Ejercicio4Cap5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio4Cap5 rEjercicio4Cap5 = new rEjercicio4Cap5();
            rEjercicio4Cap5.Show();
        }

        private void Ejercicio5Cap5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio5Cap5 rEjercicio5Cap5 = new rEjercicio5Cap5();
            rEjercicio5Cap5.Show();
        }
    }
}
