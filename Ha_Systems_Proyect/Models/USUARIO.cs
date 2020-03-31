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
    using System.ComponentModel.DataAnnotations;

    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.MONITOR_SESSION = new HashSet<MONITOR_SESSION>();
        }

        public int Id_usuario { get; set; }
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Usuario1 { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Nombre { get; set; }
        [Display(Name = "Contraseņa")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100, ErrorMessage = "Minimo 6 caracteres",
        MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Passwords { get; set; }
        public string Tipo { get; set; }
        [Display(Name = " Verificacion Contraseņa")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100, ErrorMessage = "Minimo 6 caracteres",
            MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password_V { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MONITOR_SESSION> MONITOR_SESSION { get; set; }
    }
}
