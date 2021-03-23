using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUD6.dto
{
    public class Producto:ICloneable
    {
        public String nombre { get; set; }
        public String tipo { get; set; }
        public float precio { get; set; }

        public Producto(String nombre, String tipo, float precio) {

            this.nombre = nombre;            
            this.tipo = tipo;
            this.precio = precio;
        }

        public Producto()
        {

        }

        public override string ToString()
        {
            return nombre + " " + tipo + " " + precio;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
