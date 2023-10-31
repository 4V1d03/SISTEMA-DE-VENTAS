using CapaEntidad;
using CapaNegocio;
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

        private static Size contenedorOriginalSize;

        public Inicio(Usuario objusuario = null)
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
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            //configuracion del formulario a abrir
            FormularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;//
            Size originalSize = formulario.Size;//nuevo
            formulario.Size = contenedor.Size;//nuevo
            formulario.BackColor = Color.Orange;

            //añade la configuracion al fomrulario
            contenedor.Controls.Add(formulario);
            formulario.Show();

            formulario.FormClosed += (sender, e) =>
            {
                formulario.Size = originalSize;
            };

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas(/*usuarioActual*/));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(/*usuarioActual*/));
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());

        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }







    }
}
