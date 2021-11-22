using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PersonasFisicasPrueba.Models
{
    [Table("Tb_PersonasFisicas")]
    public partial class TbPersonasFisicas
    {
        [Key]
        public int IdPersonaFisica { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaActualizacion { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }
        [StringLength(50)]
        public string ApellidoMaterno { get; set; }
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }
        public int? UsuarioAgrega { get; set; }
        public bool? Activo { get; set; }
    }
}
