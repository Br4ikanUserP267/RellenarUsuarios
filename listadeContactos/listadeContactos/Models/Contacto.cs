using System;
using System.Collections.Generic;
using System.Text;

namespace listadeContactos.Models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Foto { get; set; }

        public string NombreCompleto {
            get { return $"{Nombre}{Apellido}"; }
        }
    
    }
}
