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
    
    public partial class mensajeXusuario
    {
        public int idMensaje { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string mensaje { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
