//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDIWebSite.DataContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Inscripciones = new HashSet<Inscripcione>();
        }
    
        public int IdEvento { get; set; }
        public string NombreEvnto { get; set; }
        public Nullable<int> IdTipo { get; set; }
        public Nullable<int> IdCupo { get; set; }
        public Nullable<int> Fijo { get; set; }
        public Nullable<System.DateTime> FechaEvento { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
        public byte[] FotoEvento { get; set; }
        public Nullable<int> Activo { get; set; }
    
        public virtual Cupo Cupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        public virtual Tipo Tipo { get; set; }
    }
}
