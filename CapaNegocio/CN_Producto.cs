﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN__Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto(); //instancia a la clase Producto

        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)//reglas dentro de la capa de negocio
        {
            Mensaje = string.Empty;//inicializa con el mensaje vacillo

            //validaciones 
            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre  del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)//hace que el metodo siempre pase por las validaciones
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }


        public bool Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre  del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }

        }



        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
