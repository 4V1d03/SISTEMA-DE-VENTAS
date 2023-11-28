namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menucajaregistradora = new FontAwesome.Sharp.IconMenuItem();
            this.submenuapertura = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenucierre = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuverregistros = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.submenunegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.submenureporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.submenureporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menutitulo.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1});
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1697, 59);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.iconMenuItem2});
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 50, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(78, 55);
            this.iconMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(195, 6);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconMenuItem2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold);
            this.iconMenuItem2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconMenuItem2.Size = new System.Drawing.Size(198, 34);
            this.iconMenuItem2.Text = "Cerrar Sesión";
            this.iconMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plásticos Tonita";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.pictureBox1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.Location = new System.Drawing.Point(158, 59);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1539, 681);
            this.contenedor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.zyro_image;
            this.pictureBox1.Location = new System.Drawing.Point(383, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(1263, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario :";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.CadetBlue;
            this.lblusuario.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.LightCyan;
            this.lblusuario.Location = new System.Drawing.Point(1345, 18);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(70, 20);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "Usuario";
            // 
            // menu
            // 
            this.menu.AllowMerge = false;
            this.menu.BackColor = System.Drawing.Color.CadetBlue;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucajaregistradora,
            this.menuventas,
            this.menumantenedor,
            this.menuclientes,
            this.menucompras,
            this.menuproveedores,
            this.menuusuarios,
            this.menureportes});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 59);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 62, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(158, 681);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menucajaregistradora
            // 
            this.menucajaregistradora.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.menucajaregistradora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menucajaregistradora.Checked = true;
            this.menucajaregistradora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menucajaregistradora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuapertura,
            this.toolStripSeparator1,
            this.submenucierre,
            this.toolStripSeparator7,
            this.submenuverregistros});
            this.menucajaregistradora.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucajaregistradora.ForeColor = System.Drawing.Color.LightCyan;
            this.menucajaregistradora.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.menucajaregistradora.IconColor = System.Drawing.Color.LightCyan;
            this.menucajaregistradora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucajaregistradora.IconSize = 20;
            this.menucajaregistradora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucajaregistradora.Name = "menucajaregistradora";
            this.menucajaregistradora.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menucajaregistradora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menucajaregistradora.Size = new System.Drawing.Size(141, 38);
            this.menucajaregistradora.Text = "Caja               ";
            this.menucajaregistradora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // submenuapertura
            // 
            this.submenuapertura.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenuapertura.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuapertura.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuapertura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuapertura.IconColor = System.Drawing.Color.Black;
            this.submenuapertura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuapertura.Name = "submenuapertura";
            this.submenuapertura.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.submenuapertura.Size = new System.Drawing.Size(199, 32);
            this.submenuapertura.Text = "Apertura";
            this.submenuapertura.Click += new System.EventHandler(this.submenuapertura_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // submenucierre
            // 
            this.submenucierre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenucierre.BackColor = System.Drawing.Color.SteelBlue;
            this.submenucierre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenucierre.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucierre.IconColor = System.Drawing.Color.Black;
            this.submenucierre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucierre.Name = "submenucierre";
            this.submenucierre.Size = new System.Drawing.Size(199, 28);
            this.submenucierre.Text = "Cierre";
            this.submenucierre.Click += new System.EventHandler(this.submenucierre_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(196, 6);
            // 
            // submenuverregistros
            // 
            this.submenuverregistros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuverregistros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverregistros.IconColor = System.Drawing.Color.Black;
            this.submenuverregistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverregistros.Name = "submenuverregistros";
            this.submenuverregistros.Size = new System.Drawing.Size(199, 28);
            this.submenuverregistros.Text = "Ver Registros";
            this.submenuverregistros.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // menuventas
            // 
            this.menuventas.BackColor = System.Drawing.Color.CadetBlue;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.toolStripSeparator2,
            this.submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.ForeColor = System.Drawing.Color.LightCyan;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.menuventas.IconColor = System.Drawing.Color.LightCyan;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 20;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menuventas.Size = new System.Drawing.Size(141, 38);
            this.menuventas.Text = "Ventas           ";
            this.menuventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuregistrarventa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(250, 28);
            this.submenuregistrarventa.Text = "Registrar Venta";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenuverdetalleventa.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuverdetalleventa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(250, 28);
            this.submenuverdetalleventa.Text = "Ver Detalle de Venta";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.toolStripSeparator4,
            this.submenuproducto,
            this.toolStripSeparator5,
            this.submenunegocio});
            this.menumantenedor.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumantenedor.ForeColor = System.Drawing.Color.LightCyan;
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.menumantenedor.IconColor = System.Drawing.Color.LightCyan;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 20;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menumantenedor.Size = new System.Drawing.Size(141, 38);
            this.menumantenedor.Text = "Gestionar       ";
            this.menumantenedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // submenucategoria
            // 
            this.submenucategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenucategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.submenucategoria.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(210, 28);
            this.submenucategoria.Text = "Cat. Productos";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
            // 
            // submenuproducto
            // 
            this.submenuproducto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenuproducto.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuproducto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(210, 28);
            this.submenuproducto.Text = "Inventario";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(207, 6);
            // 
            // submenunegocio
            // 
            this.submenunegocio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenunegocio.BackColor = System.Drawing.Color.SteelBlue;
            this.submenunegocio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenunegocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenunegocio.IconColor = System.Drawing.Color.Black;
            this.submenunegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(210, 28);
            this.submenunegocio.Text = "Info. del Local";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuclientes.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuclientes.ForeColor = System.Drawing.Color.LightCyan;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuclientes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 1;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menuclientes.Size = new System.Drawing.Size(141, 38);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click_1);
            // 
            // menucompras
            // 
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.toolStripSeparator3,
            this.submenuverdetallecompra});
            this.menucompras.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompras.ForeColor = System.Drawing.Color.LightCyan;
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.menucompras.IconColor = System.Drawing.Color.LightCyan;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 20;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menucompras.Size = new System.Drawing.Size(141, 38);
            this.menucompras.Text = "Compras        ";
            this.menucompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenuregistrarcompra.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuregistrarcompra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(266, 28);
            this.submenuregistrarcompra.Text = "Registrar Compra";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.submenuverdetallecompra.BackColor = System.Drawing.Color.SteelBlue;
            this.submenuverdetallecompra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(266, 28);
            this.submenuverdetallecompra.Text = "Ver Detalle de Compra";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click_1);
            // 
            // menuproveedores
            // 
            this.menuproveedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuproveedores.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.ForeColor = System.Drawing.Color.LightCyan;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.menuproveedores.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 1;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menuproveedores.Size = new System.Drawing.Size(141, 38);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click_1);
            // 
            // menuusuarios
            // 
            this.menuusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuusuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuusuarios.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.ForeColor = System.Drawing.Color.LightCyan;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.Zhihu;
            this.menuusuarios.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 1;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menuusuarios.Size = new System.Drawing.Size(141, 38);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click_1);
            // 
            // menureportes
            // 
            this.menureportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menureportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenureporteVentas,
            this.submenureporteCompras});
            this.menureportes.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.ForeColor = System.Drawing.Color.LightCyan;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.menureportes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 1;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.menureportes.Size = new System.Drawing.Size(141, 38);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(13, 12, 27, 12);
            this.label3.Size = new System.Drawing.Size(168, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu Principal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(16, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // submenureporteVentas
            // 
            this.submenureporteVentas.Name = "submenureporteVentas";
            this.submenureporteVentas.Size = new System.Drawing.Size(224, 28);
            this.submenureporteVentas.Text = "Reporte Venta";
            this.submenureporteVentas.Click += new System.EventHandler(this.submenureporteVentas_Click);
            // 
            // submenureporteCompras
            // 
            this.submenureporteCompras.Name = "submenureporteCompras";
            this.submenureporteCompras.Size = new System.Drawing.Size(224, 28);
            this.submenureporteCompras.Text = "Reporte Compra";
            this.submenureporteCompras.Click += new System.EventHandler(this.submenureporteCompras_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1697, 740);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SISTEMA DE VENTAS";
            this.Load += new System.EventHandler(this.Inicio_Load_1);
            this.menutitulo.ResumeLayout(false);
            this.menutitulo.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem submenuapertura;
        private FontAwesome.Sharp.IconMenuItem submenucierre;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenunegocio;
        private FontAwesome.Sharp.IconMenuItem menucajaregistradora;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private FontAwesome.Sharp.IconMenuItem submenuverregistros;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem submenureporteVentas;
        private System.Windows.Forms.ToolStripMenuItem submenureporteCompras;
    }
}

