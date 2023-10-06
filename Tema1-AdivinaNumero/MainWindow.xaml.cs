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

namespace Tema1_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static Random objetoRandom = new Random();
        private static int numeroAleatorio = objetoRandom.Next(0, 101);

        private void BotonComprobar_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(CuadroTexto.Text) > numeroAleatorio)
                Respuesta.Text = "Te has pasdo";
            else if (int.Parse(CuadroTexto.Text) < numeroAleatorio)
                Respuesta.Text = "Te has quedado corto";
            else
                Respuesta.Text = "!Has acertado!";
        }

        private void BotonReiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = objetoRandom.Next(0, 101);
            Respuesta.Text = "";
        }
    }
}
