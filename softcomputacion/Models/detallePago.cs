//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace softcomputacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class detallePago
    {
        public int idDetallePago { get; set; }
        public int idVenta { get; set; }
        public System.DateTime fechaPago { get; set; }
        public decimal entrega { get; set; }
        public int idMetodoPago { get; set; }
        public string tipoPago { get; set; }
    
        public virtual metodoPago metodoPago { get; set; }
        public virtual venta venta { get; set; }
    }
}
