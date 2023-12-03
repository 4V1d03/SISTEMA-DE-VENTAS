using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
       
        private static Usuario usuarioActual; //usuario que se a logeado
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "Generico", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }



        private void Inicio_Load_1(object sender, EventArgs e, string lblusuario)
        {
            
            
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) //abre los formularios en el panel y pinta los menu seleccionados
        {
            //configuracion del menu superior
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.CadetBlue;
                MenuActivo.ForeColor = Color.LightCyan;
                MenuActivo.IconColor = Color.LightCyan;  
            }
            //menu seleccionado
            menu.ForeColor = Color.Black;
            menu.IconColor= Color.Black;
            MenuActivo = menu;
            pictureBox1.Visible = false;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            //configuracion del formulario a abrir
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Red;
            //añade la configuracion al fomrulario
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        
        private void menuusuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
            FormularioActivo.BackColor = Color.Azure;

        }

        private void submenuapertura_Click(object sender, EventArgs e)
        {
            using (var modal = new frmAperturacaja())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                 
                }
                else
                {
                    
                }
            }
        }
        
        private void submenucierre_Click(object sender, EventArgs e)
        {
            using (var modal = new frmCierrecaja())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {

                }
                else
                {

                }
            }
            //AbrirFormulario(menucajaregistradora, new frmCierrecaja());
            //FormularioActivo.BackColor = Color.Azure;

        }

        private void submenucategoria_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void submenuproducto_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmNegocio());
            FormularioActivo.BackColor = Color.Azure;

        }
        //registroventas
        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(usuarioActual));
            FormularioActivo.BackColor = Color.Azure;
        }


        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
            FormularioActivo.BackColor = Color.Azure;

        }

        private void submenuregistrarcompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
            FormularioActivo.BackColor = Color.Azure;
        }

        private void submenuverdetallecompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void menuclientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void menuproveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
            FormularioActivo.BackColor = Color.Azure;
        }



        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            using (var modal = new frmRegistrosCaja())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }

        private void submenureporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteCompras());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void submenureporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmReporteVentas());
            FormularioActivo.BackColor = Color.Azure;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menu.Items)
            {

                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }
            //frmAperturacaja formapertura = new frmAperturacaja();
            //formapertura.txtempleado.Text = usuarioActual.NombreCompleto;
            frmCierrecaja cierre= new frmCierrecaja();
            lblusuario.Text = usuarioActual.NombreCompleto;
            //submenucierre.Enabled = false;
            //submenucierre.Visible = false;
            //submenuregistrarventa.Visible = false;

        }
    }
}
