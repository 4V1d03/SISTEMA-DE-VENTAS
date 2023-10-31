using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol(); //instancia ala clase rol en capa datos


        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
