using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SistemaTienda1._5.Models
{

    [Table("PedidoDetalle")]
    public class PedidoDetalle
    {
        public int PedidoDetalleId { get; set; }

        public int PedidoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int ProductoId { get; set; }

        [MaxLength(10)]
        [MinLength(2)]
        public decimal precio { get; set; } = 0.10m;

        [MaxLength(10)]
        [MinLength(2)]
        public decimal SubTotal { get; set; } = 0.10m;

        [MaxLength(10)]
        [MinLength(2)]
        public decimal Descuento { get; set; } = 0.10m; 

    }
}