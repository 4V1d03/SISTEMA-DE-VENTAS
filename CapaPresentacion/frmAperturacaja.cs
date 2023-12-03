using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmAperturacaja : Form

    {
        //
        private Usuario _Usuario;
        //private static Usuario usuarioActual;
        public frmAperturacaja(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            //oUsuario = new Usuario();
            InitializeComponent();
        }


        private void frmAperturacaja_Load(object sender, EventArgs e)
        {
            txtcantidadinicial.Select();
            txtfecha.Text = DateTime.Now.ToString();
            txtcodigocaja.Text = "0";

            cboestadocaja.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestadocaja.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestadocaja.DisplayMember = "Texto";
            cboestadocaja.ValueMember = "Valor";
            cboestadocaja.SelectedIndex = 0;
            
        }
 
        //Apertura de caja
        private void btnguardarcaja_Click(object sender, EventArgs e)
        {
            Inicio inicioo = new Inicio();
            inicioo.submenucierre.Enabled = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string nuevoId = ObtenerCodigoAutoincremental();
                    txtcodigocaja.Text = nuevoId;
                    oconexion.Open();

                    string query = "INSERT INTO CAJA ([FechaInicio],[CantidadInicial],[EstadoCaja]) VALUES (@FechaInicio, @CantidadInicial, @EstadoCaja)";

                    using (SqlCommand cmd = new SqlCommand(query, oconexion))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", txtfecha.Text);
                        cmd.Parameters.AddWithValue("@CantidadInicial", Convert.ToDecimal(txtcantidadinicial.Text));
                        //cmd.Parameters.AddWithValue("@Empleado", txtempleado.Text);
                        cmd.Parameters.AddWithValue("@EstadoCaja", Convert.ToInt32(((OpcionCombo)cboestadocaja.SelectedItem).Valor) == 1);
                        
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Caja Aperturada con éxito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la caja: " + ex.Message);
                }
            }
            decimal cantinicialcaja = 0;
            if (!decimal.TryParse(txtcantidadinicial.Text, out cantinicialcaja))
            {
                MessageBox.Show("Precio Compra - Formato Moneda Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidadinicial.Select();
                return;
            }
            //habilitar submenu de cierre y desabilitar el de apertura
            
            this.Close();
        }

       


        private string ObtenerCodigoAutoincremental()
        {

            //string connectionString = "Data Source=DESKTOP-SHJV5CQ;Initial Catalog=BaseSistemaVentas;"; //cadena de conexión
            string nuevoId = "0"; // Valor predeterminado en caso de error

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    // Consulta para obtener el valor autoincremental
                    string query = "SELECT IDENT_CURRENT('CAJA') + 1";

                    using (SqlCommand command = new SqlCommand(query,oconexion))
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
                MessageBox.Show("Error al obtener el código autoincremental: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nuevoId;
            
        }

        private void txtcantidadinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtcantidadinicial.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtcantidadinicial_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Trim() == "0")
            {
                textBox.Text = "1";
            }
        }
    }

}

