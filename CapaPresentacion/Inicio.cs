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

        //private static Size contenedorOriginalSize;

        public Inicio(Usuario objusuario=null)
        {
            //para no estar logeando en cada momento
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 }; //usuario manual

            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);//el usuario logeado comparte su id para mostrara sus permisos

            //restringe la vista de los menus al usuario en funcion a sus permisos
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);//determina si una lista contiene elementos

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }

            lblusuario.Text = usuarioActual.NombreCompleto;//asigna el nombre de usuario a label
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) //abre los formularios en el panel y pinta los menu seleccionados
        {
            //configuracion del menu superior
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.AliceBlue;
                MenuActivo.ForeColor = Color.DarkSlateGray;
                MenuActivo.IconColor = Color.DarkSlateGray;
                
            }
            
            menu.ForeColor = Color.DodgerBlue;
            menu.IconColor= Color.DodgerBlue;
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
            pictureBoxlogoinicio.Visible = true;
            //formulario.BackColor = Color.Red;
            //añade la configuracion al fomrulario
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        
        private void menuusuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
            FormularioActivo.BackColor = Color.LightCyan;

        }

        private void submenuapertura_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucajaregistradora, new frmAperturacaja(/*usuarioActual*/));
            FormularioActivo.BackColor = Color.LightCyan;

        }
        
        private void submenucierre_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucajaregistradora, new frmCierrecaja());
            FormularioActivo.BackColor = Color.LightCyan;

        }

        private void submenucategoria_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void submenuproducto_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmNegocio());
            FormularioActivo.BackColor = Color.LightCyan;

        }

        private void submenuregistrarventa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(/*usuarioActual*/));
            FormularioActivo.BackColor = Color.LightCyan;

        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
            FormularioActivo.BackColor = Color.LightCyan;

        }

        private void submenuregistrarcompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(/*usuarioActual*/));
            FormularioActivo.BackColor = Color.LightBlue;
        }

        private void submenuverdetallecompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void menuclientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void menuproveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void menureportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
            FormularioActivo.BackColor = Color.LightCyan;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir del sistema?", "Mensaje", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }
    }
}
