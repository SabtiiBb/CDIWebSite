using CDIWebSite.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDIWebSite.Models
{
    public class InscriptionsVM
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string NContacto { get; set; }
        public DateTime FechaNac { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int IdPersona { get; set; }
        public int IdEvento { get; set; }
        public int Activo { get; set; }

        //public virtual Evento Evento { get; set; }
        //public virtual Persona Persona { get; set; }
    }
}