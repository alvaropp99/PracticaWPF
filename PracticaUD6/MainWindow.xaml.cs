using PracticaUD6.dto;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace PracticaUD6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Listas listaLogica;
        public Producto producto;
        public static MainWindow window = new MainWindow();

        public MainWindow()
        {
            InitializeComponent();
            listaLogica = new Listas();
            this.DataContext = listaLogica;
        }

        private void BotonAñadir_Click(object sender, RoutedEventArgs e)
        {
            AñadirProducto añadirProducto = new AñadirProducto(listaLogica);
            añadirProducto.Show();
        }

        private void BotonBorrar_Click_1(object sender, RoutedEventArgs e)
        {
            
            listaLogica.borrarProducto(DataGridProductos.SelectedIndex);
        }

        private void BotonModificar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)DataGridProductos.SelectedItem;
                AñadirProducto añadirProducto = new AñadirProducto(listaLogica, (Producto)producto.Clone(), DataGridProductos.SelectedIndex);
                añadirProducto.Show();
            }
        }

        private void BotonBorrarAvit_Click(object sender, RoutedEventArgs e)
        {
            listaLogica.borrarAvit(DataGridAvit.SelectedIndex);
        }

        private void BotonAñadirAvit_Click(object sender, RoutedEventArgs e)
        {
            AgregarAvit agregarAvit = new AgregarAvit(listaLogica);
            agregarAvit.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BotonModifAvit_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridAvit.SelectedIndex != -1)
            {
                Avituallamiento avituallamiento = (Avituallamiento)DataGridAvit.SelectedItem;
                AgregarAvit agregarAvit = new AgregarAvit(listaLogica, (Avituallamiento)avituallamiento.Clone(), DataGridAvit.SelectedIndex);
                agregarAvit.Show();
            }
        }
    }
}
