//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackenBilletera.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimiento
    {
        public int idMovimiento { get; set; }
        public System.DateTime fecha { get; set; }
        public int idTipoMov { get; set; }
        public int idUsuario { get; set; }
        public int monto { get; set; }
        public int numComprobante { get; set; }
    
        public virtual TipoMovimiento TipoMovimiento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
