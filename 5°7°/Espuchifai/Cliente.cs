using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espuchifai
{
    public class Cliente
    {
        public string Nombre;
        public string Apellido;
        public string Email;
        public string Contra;
        
        public Cliente (string unNombre, string unApellido, string unEmail, string unContra )
        {
            Nombre = unNombre;
            Apellido = unApellido;
            Email = unEmail;
            Contra = unContra;
        }
    }
}