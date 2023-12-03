using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Caja
    {
        public List<Caja> Listar()
        {
            List<Caja> lista = new List<Caja>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("Select Codigo,FechaInicio,CantidadInicial,Empleado,CantidadFinal,FechaCierre,EstadoCaja from CAJA");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Caja()
                            {
                                Codigo = Convert.ToInt32(dr["Codigo"]),
                                FechaInicio = dr["FechaInicio"].ToString(),
                                CantidadInicial = Convert.ToDecimal(dr["CantidadInicial"]),
                                Empleado = dr["Empleado"].ToString(),
                                CantidadFinal = Convert.ToDecimal(dr["CantidadFinal"]),
                                FechaCierre = dr["FechaCierre"].ToString(),
                                EstadoCaja = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Caja>();
                }
            }

            return lista;

        }

        //guardar Categoria
        public int Registrar(Caja obj, out string Mensaje)//obj = parametro de entrada Mensaje = parametro de salida
        {
            int codigogenerado = 0;//guarda el id generado
            Mensaje = string.Empty; //valor de la variable mensaje

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_AperturaCaja", oconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", obj.FechaInicio);
                    cmd.Parameters.AddWithValue("CantidadInicial", obj.CantidadInicial);
                    cmd.Parameters.AddWithValue("CantidadFinal", obj.CantidadFinal);
                    cmd.Parameters.AddWithValue("Empleado", obj.Empleado);
                    cmd.Parameters.AddWithValue("FechaCierre", obj.FechaCierre);
                    cmd.Parameters.AddWithValue("EstadoCaja", obj.EstadoCaja);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    //parametros de salida, toman valor
                    codigogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                codigogenerado = 0;
                Mensaje = ex.Message;
            }

            return codigogenerado;
        }


        public bool Cerrar(Caja obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_CierreCaja", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("CantidadFinal", obj.CantidadFinal);
                    cmd.Parameters.AddWithValue("FechaCierre", obj.FechaCierre);
                    cmd.Parameters.AddWithValue("EstadoCaja", obj.EstadoCaja);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
