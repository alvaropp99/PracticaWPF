using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUD6.dto
{
    public class Persona
    {

        public String nombre { get; set; }
        public int tfno { get; set; }

        public Persona() { }

        public Persona(String nombre, int tfno) {
            this.nombre = nombre;
            this.tfno = tfno;
        }

        public override string ToString()
        {
            return nombre + " " + tfno;
        }
    }
}
