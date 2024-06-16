using System;
using System.Collections.Generic;

namespace MercDevs_ej2.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Servicios = new HashSet<Servicio>();
            Nombre = string.Empty;
            Apellido = string.Empty;
            Correo = string.Empty;
            Password = string.Empty;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}