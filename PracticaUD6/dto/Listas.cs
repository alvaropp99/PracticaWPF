using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUD6.dto
{
    public class Listas
    {

        public ObservableCollection<Producto> listaProduct { get; set; }= new ObservableCollection<Producto>();
        public ObservableCollection<string> listaTipos { get; set; }
        public ObservableCollection<Avituallamiento> listaAvituallamientos { get; set; }

        public Listas()
        {

            //PRODUCTOS

            listaProduct.Add(new Producto("Pincho", "Comida", 4.5f));
            listaProduct.Add(new Producto("Botella de Agua", "Bebida", 1.2f));
            listaProduct.Add(new Producto("Ibuprofeno", "Material Sanitario", 2.3f));

            //TIPOS
            listaTipos = new ObservableCollection<string>
            {
                "Comida",
                "Bebida",
                "Material Sanitario"
            };
            
            //MATERIALES

            String materiales = "";
            foreach (Producto p in listaProduct)
            {
                if (materiales == "")
                    materiales = p.nombre;
                else
                    materiales += "\n" + p.nombre;
            }

            //AVITUALLAMIENTOS
            listaAvituallamientos = new ObservableCollection<Avituallamiento>();
            listaAvituallamientos.Add(new Avituallamiento("Austria", 7, new Persona("Lando", 698456123), materiales));
            listaAvituallamientos.Add(new Avituallamiento("Monza", 6, new Persona("LeClerc", 647321987), materiales));
        }

        public void aniadirProducto(Producto producto)
        {
            listaProduct.Add(producto);
        }

        public void borrarProducto(int indice)
        {
            listaProduct.RemoveAt(indice);
        }

        public void modifcarProducto(Producto producto, int posicion)
        {
            listaProduct[posicion] = producto;
        }

        public void borrarAvit(int indice)
        {
            listaAvituallamientos.RemoveAt(indice);
        }

        public ObservableCollection<Producto> recibirProductos()
        {
            return listaProduct;
        }

        public void aniadirAvit(Avituallamiento avituallamiento)
        {
            listaAvituallamientos.Add(avituallamiento);
        }

        public void modificarAvit(Avituallamiento avituallamiento, int posicion)
        {
            listaAvituallamientos[posicion] = avituallamiento;
        }
    }
}
