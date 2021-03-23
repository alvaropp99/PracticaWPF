using PracticaUD6.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para AgregarAvit.xaml
    /// </summary>
    public partial class AgregarAvit : Window
    {

        public Avituallamiento avituallamiento;
        private int posicion;
        private Boolean modificar;
        private Persona persona;

        public AgregarAvit(Listas logicaLista,Avituallamiento avituallamiento, int posicion)
        {
            ObservableCollection<Producto> listaP = MainWindow.window.listaLogica.recibirProductos();

            InitializeComponent();
            listBoxMat.Items.Clear();
            foreach (Producto p in MainWindow.window.listaLogica.listaProduct)
            {
                listBoxMat.Items.Add(p.nombre);
            }
            MainWindow.window.listaLogica = logicaLista;
            this.avituallamiento=avituallamiento;
            this.posicion = posicion;
            this.DataContext = MainWindow.window.listaLogica;
            textBoxCarrera.Text = avituallamiento.carrera;
            textBoxPtoKM.Text = avituallamiento.puntoKM.ToString();
            textBoxNombreContact.Text = avituallamiento.contacto.nombre;
            textBoxTfnoContact.Text = avituallamiento.contacto.tfno.ToString();
            textBoxMateriales.Text = avituallamiento.materiales;
            modificar = true;
        }

        public AgregarAvit(Listas logicaLista)
        {
            ObservableCollection<Producto> listaP = MainWindow.window.listaLogica.recibirProductos();

            InitializeComponent();
            listBoxMat.Items.Clear();
             foreach (Producto p in MainWindow.window.listaLogica.listaProduct)
             {
                 listBoxMat.Items.Add(p.nombre);
             }
            MainWindow.window.listaLogica = logicaLista;
            avituallamiento = new Avituallamiento();
            this.DataContext = MainWindow.window.listaLogica;
            modificar = false;
             
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAniadir_Click(object sender, RoutedEventArgs e)
        {
            avituallamiento = new Avituallamiento(textBoxCarrera.Text, int.Parse(textBoxPtoKM.Text), new Persona(textBoxNombreContact.Text,int.Parse(textBoxTfnoContact.Text)), textBoxMateriales.Text);
            if (modificar)
            {
                MainWindow.window.listaLogica.modificarAvit(avituallamiento, posicion);
            }else
                MainWindow.window.listaLogica.aniadirAvit(avituallamiento);


            this.Close();
        }

        private void BotonInsertarMat_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxMat.SelectedIndex > -1)
            {
                if (textBoxMateriales.Text == "")
                    textBoxMateriales.Text = listBoxMat.SelectedItem.ToString();
                else
                {
                    if(textBoxMateriales.Text.Contains(listBoxMat.SelectedItem.ToString())==false)
                        textBoxMateriales.Text += "\n"+listBoxMat.SelectedItem.ToString();
                }
                
            }
        }
    }
}
