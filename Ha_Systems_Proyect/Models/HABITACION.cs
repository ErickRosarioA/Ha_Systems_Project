//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ha_Systems_Proyect.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HABITACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HABITACION()
        {
            this.HOSPEDAJE = new HashSet<HOSPEDAJE>();
        }
    
        public int Id_habitacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Estado_habitacion { get; set; }
        public Nullable<bool> Disponibilidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOSPEDAJE> HOSPEDAJE { get; set; }
    }
}
