using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace CapaPresentacion
{
    public partial class frmCierrecaja : Form
    {
        //private static Usuario usuarioActual;
        //Usuario objusuario = null
        public frmCierrecaja()
        {
        //    if (objusuario == null)
        //        usuarioActual = new Usuario() { NombreCompleto = "Generico", IdUsuario = 1 };
        //    else
        //        usuarioActual = objusuario;
            InitializeComponent();
        }

        //obtner y calcular el total de ventas
        private string Obtenermontototal()
        {
            decimal totalventascaja = 0; // Valor predeterminado en caso de error
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    // Consulta 
                    string query = "SELECT SUM(MontoTotal) FROM VENTA WHERE CodigoCaja = IDENT_CURRENT('CAJA')";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        //object result = command.ExecuteScalar();
                        decimal suma = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal valor = reader.GetDecimal(0);
                                suma += valor;
                            }
                        }
                        totalventascaja += suma;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: No se han realizado ventas" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iconButton2.Visible= false;
            }
            return totalventascaja.ToString();
        }


        //boton calcular total
        private void iconButton1_Click(object sender, EventArgs e)
        {
            string cantInicial = ObtenercantidadInicial();
            string totalventascaja = Obtenerestadocaja();

            //declaracion de variables
            decimal cantini = 0;
            decimal totalvtsxc = 0;
            decimal cantidadfinal = 0;

            //conversion de valores 
            cantini = Convert.ToDecimal(cantInicial);
            totalvtsxc = Convert.ToDecimal(totalventascaja);

            //asignacion de valores
            cantidadfinal=cantini+totalvtsxc;
            txttotalventas.Text = totalventascaja.ToString();
            txtcantidadinicial.Text = cantInicial;
            txtcantidadfinal.Text = cantidadfinal.ToString();
        }

        //boton cerrar caja
        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    string query = "UPDATE CAJA SET [FechaCierre]=@FechaCierre,[CantidadFinal]=@CantidadFinal,[EstadoCaja]=@EstadoCaja,[TotalVentas]=@TotalVentas,[Empleado]=(select [NombreCompleto] from USUARIO u join VENTA v on V.IdUsuario = u.IdUsuario where IdVenta = IDENT_CURRENT('VENTA')) where Codigo = IDENT_CURRENT('CAJA')";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@FechaCierre", txtfechacierre.Text);
                        cmd.Parameters.AddWithValue("@CantidadFinal", Convert.ToDecimal(txtcantidadfinal.Text));
                        cmd.Parameters.AddWithValue("@TotalVentas", txttotalventas.Text);
                        cmd.Parameters.AddWithValue("@EstadoCaja", Convert.ToInt32(((OpcionCombo)cboestadocaja.SelectedItem).Valor) == 0);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Caja cerrada con éxito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Primero se deben calcular los valores ","Advertencia: datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            txtcodigocaja.Text = "";

        }
        
        //Saber si la caja esta aperturada
        public string Obtenerestadocaja()
        {
            decimal ventastotal = 0;

            //string estadocaja = "0"; // Valor predeterminado en caso de error
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    // Consulta para obtener el valor codigocaja
                    string query = "select EstadoCaja from CAJA where Codigo = IDENT_CURRENT('CAJA') AND EstadoCaja =1";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            ventastotal += Convert.ToDecimal(Obtenermontototal());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estado de caja registradora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ventastotal.ToString();
        }
        //Obtener codigo de caja
        private string ObtenerCodigocaja()
        {
            string nuevoId = "0"; // Valor predeterminado en caso de error
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    // Consulta para obtener el valor codigocaja
                    string query = "SELECT IDENT_CURRENT('CAJA')";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            nuevoId = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el código de caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nuevoId;
        }

        private string Obtenerfechainicio()
        {
            string fechainicio = "";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    // Consulta para obtener fechainicio
                    string query = "SELECT FechaInicio from CAJA WHERE Codigo =IDENT_CURRENT('CAJA')";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            fechainicio = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha de inicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fechainicio;
        }

        private string ObtenercantidadInicial()
        {
            string cantInicial = "";
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();
                    
                    // Consulta para obtener cantidad inicial
                    string query = "SELECT CantidadInicial from CAJA WHERE Codigo =IDENT_CURRENT('CAJA')";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            cantInicial = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la fecha de inicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cantInicial;
        }

        private void frmCierrecaja_Load_1(object sender, EventArgs e)
        {
            string nuevoId = ObtenerCodigocaja();
            string fechainicio = Obtenerfechainicio();
            txtcodigocaja.Select();

            txtcodigocaja.Text = "";
            txtcantidadfinal.Text = "";
            txtcantidadfinal.Text = "";
            txttotalventas.Text = "";
            txtfechacierre.Text = DateTime.Now.ToString();
            
            txtcodigocaja.Text = nuevoId;
            txtfechainicio.Text= fechainicio;
            cboestadocaja.Items.Add(new OpcionCombo() { Valor = 1, Texto = "No Activo" });
            cboestadocaja.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Activo" });
            cboestadocaja.DisplayMember = "Texto";
            cboestadocaja.ValueMember = "Valor";
            cboestadocaja.SelectedIndex = 0;
        }
        private void txttotalventas_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim() == "0")
            {
                textBox.Text = "1";
            }
        }
    }
}
