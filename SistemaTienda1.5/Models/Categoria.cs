using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaTienda1._5.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [MaxLength(50)]
        public string Codigo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}