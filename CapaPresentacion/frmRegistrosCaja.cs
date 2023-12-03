using CapaDatos;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace CapaPresentacion
{
    public partial class frmRegistrosCaja : Form
    {
        public frmRegistrosCaja()
        {
            InitializeComponent();
        }

        private void frmRegistrosCaja_Load(object sender, EventArgs e)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                

                // Consulta 
                string query = "SELECT * FROM CAJA ORDER BY Codigo ASC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, oconexion);
                DataTable dataTable = new DataTable();

                oconexion.Open();
                adapter.Fill(dataTable);
                oconexion.Close();

                dgvdata.DataSource = dataTable;

            }
        }
    }
}
