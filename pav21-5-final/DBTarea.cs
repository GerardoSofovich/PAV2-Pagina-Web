//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaTareas.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBTarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Completado { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public int TipoId { get; set; }
    
        public virtual DBTipo Tipo { get; set; }
    }
}