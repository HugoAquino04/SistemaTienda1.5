﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaTienda1._5.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int PedidosId { get; set; }

        public int ClienteId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaPedido { get; set; }

        public bool Estado { get; set; }

        public decimal Total { get; set; } = 0.10m;

        public decimal SubTotal { get; set; } = 0.10m;

        public decimal Descuento { get; set; } = 0.10m;

        //agregar
    }
}