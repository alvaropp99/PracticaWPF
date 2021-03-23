using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PracticaUD6.dto
{
    public class Material
    {
        public Producto producto { get; set; }
        public TextBox textBox { get; set; }
        public int cantidad { get; set; }

        public Material() { }
        public Material(Producto producto, int cantidad)
        {
            this.producto = new Producto(producto.nombre,producto.tipo, producto.precio);
            this.cantidad = cantidad;
            //this.textBox.Text = cantidad.ToString();
        }

        public override string ToString()
        {
            return producto.nombre;
        }
    }
}
