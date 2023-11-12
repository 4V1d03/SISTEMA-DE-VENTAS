using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObenterDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                    conexion.Open();

                    string query = "Select IdNegocio, Nombre, Ruc, Direccion from NEGOCIO where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query,conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RUC = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }
                
              
                }

            }
            catch {
            
            
            
            }




            return obj;
        }
    }
}
