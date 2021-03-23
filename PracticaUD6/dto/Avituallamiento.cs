using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUD6.dto
{
    public class Avituallamiento:ICloneable
    {
        public String carrera { get; set; }
        public int puntoKM { get; set; }
        public Persona contacto { get; set; }
        public String materiales { get; set; }

        public Avituallamiento() { }

        public Avituallamiento(String carrera, int puntoKM, Persona contacto, String materiales)
        {
            this.carrera = carrera;
            this.puntoKM = puntoKM;
            this.contacto = contacto;
            this.materiales = materiales;
        }

        public override string ToString()
        {
            return carrera + " " + puntoKM + " " + contacto.nombre + " " + contacto.tfno + " " + materiales;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
