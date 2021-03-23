using PracticaUD6.dto;
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

namespace PracticaUD6
{
    /// <summary>
    /// Lógica de interacción para AñadirProducto.xaml
    /// </summary>
    public partial class AñadirProducto : Window
    {

        public Producto producto;
        private int posicion;
        private Boolean modificar;
        public AñadirProducto(Listas lista, Producto producto, int posicion)
        {
            InitializeComponent();
            this.producto = producto;
            MainWindow.window.listaLogica = lista;
            this.posicion = posicion;
            this.DataContext = MainWindow.window.listaLogica;
            textBoxNombre.Text = producto.nombre;
            comboBoxTipo.SelectedItem = producto.tipo;
            textBoxPrecio.Text = producto.precio.ToString();
            modificar = true;
        }

        public AñadirProducto(Listas logicaLista)
        {
            InitializeComponent();            
            MainWindow.window.listaLogica = logicaLista;
            producto = new Producto();
            this.DataContext = MainWindow.window.listaLogica;
            modificar = false;
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAniadir_Click(object sender, RoutedEventArgs e)
        {
            producto = new Producto(textBoxNombre.Text, comboBoxTipo.SelectedItem.ToString(), float.Parse(textBoxPrecio.Text));
            if (modificar)
            {
                MainWindow.window.listaLogica.modifcarProducto(producto, posicion);
            }
            else
            {
                MainWindow.window.listaLogica.aniadirProducto(producto);
            }

            this.Close();

        }
    }
}
