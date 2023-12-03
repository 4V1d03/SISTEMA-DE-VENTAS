using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Caja
    {
        private CD_Caja objcd_Caja = new CD_Caja(); //instancia a la clase Caja

        //public Caja Registrar()
        //{
        //    return objcd_Caja.Registrar();
        //}

        public int Registrar(Caja obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.CantidadInicial==0)
            {
                Mensaje += "Es necesario ingresar una cantidad inicial\n";
            }

            if (Mensaje != string.Empty)
            {
               return 0;
            }
            else
            {
               return objcd_Caja.Registrar(obj, out Mensaje);
            }
        }

        public bool Cerrar(Caja obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.CantidadFinal == 0)
            {
                Mensaje += "Es necesario calcular la cantidad final\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Caja.Cerrar(obj, out Mensaje);
            }
        }
    }
}
