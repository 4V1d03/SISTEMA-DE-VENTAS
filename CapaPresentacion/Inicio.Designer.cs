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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pictureBoxlogoinicio = new System.Windows.Forms.PictureBox();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menucajaregistradora = new FontAwesome.Sharp.IconMenuItem();
            this.submenuapertura = new FontAwesome.Sharp.IconMenuItem();
            this.submenucierre = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            this.submenunegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogoinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.AliceBlue;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menucajaregistradora,
            this.menumantenedor,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.iconMenuItem1});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 115, 0, 2);
            this.menu.Size = new System.Drawing.Size(164, 553);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1273, 48);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(44, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE VENTAS  PLASTICOS TONITA";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.pictureBox1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.Location = new System.Drawing.Point(164, 48);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1109, 553);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(1007, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblusuario.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Honeydew;
            this.lblusuario.Location = new System.Drawing.Point(1080, 15);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(67, 24);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // pictureBoxlogoinicio
            // 
            this.pictureBoxlogoinicio.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxlogoinicio.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBoxlogoinicio.Location = new System.Drawing.Point(0, 48);
            this.pictureBoxlogoinicio.Name = "pictureBoxlogoinicio";
            this.pictureBoxlogoinicio.Size = new System.Drawing.Size(164, 107);
            this.pictureBoxlogoinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogoinicio.TabIndex = 0;
            this.pictureBoxlogoinicio.TabStop = false;
            this.pictureBoxlogoinicio.Visible = false;
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.BackColor = System.Drawing.Color.AliceBlue;
            this.iconButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.Salmon;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonExit.IconColor = System.Drawing.Color.Tomato;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 40;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonExit.Location = new System.Drawing.Point(34, 541);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(85, 35);
            this.iconButtonExit.TabIndex = 0;
            this.iconButtonExit.Text = "Exit";
            this.iconButtonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.zyro_image;
            this.pictureBox1.Location = new System.Drawing.Point(287, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuusuarios
            // 
            this.menuusuarios.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuusuarios.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuarios.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuusuarios.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.IconSize = 30;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(105, 34);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click_1);
            // 
            // menucajaregistradora
            // 
            this.menucajaregistradora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuapertura,
            this.submenucierre});
            this.menucajaregistradora.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucajaregistradora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menucajaregistradora.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.menucajaregistradora.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menucajaregistradora.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucajaregistradora.IconSize = 30;
            this.menucajaregistradora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucajaregistradora.Name = "menucajaregistradora";
            this.menucajaregistradora.Size = new System.Drawing.Size(158, 34);
            this.menucajaregistradora.Text = "Caja registradora";
            // 
            // submenuapertura
            // 
            this.submenuapertura.ForeColor = System.Drawing.Color.Teal;
            this.submenuapertura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuapertura.IconColor = System.Drawing.Color.Black;
            this.submenuapertura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuapertura.Name = "submenuapertura";
            this.submenuapertura.Size = new System.Drawing.Size(133, 22);
            this.submenuapertura.Text = "Apertura";
            this.submenuapertura.Click += new System.EventHandler(this.submenuapertura_Click);
            // 
            // submenucierre
            // 
            this.submenucierre.ForeColor = System.Drawing.Color.Teal;
            this.submenucierre.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucierre.IconColor = System.Drawing.Color.Black;
            this.submenucierre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucierre.Name = "submenucierre";
            this.submenucierre.Size = new System.Drawing.Size(133, 22);
            this.submenucierre.Text = "Cierre";
            this.submenucierre.Click += new System.EventHandler(this.submenucierre_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenucategoria,
            this.submenuproducto,
            this.submenunegocio});
            this.menumantenedor.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumantenedor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.menumantenedor.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 30;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(129, 34);
            this.menumantenedor.Text = "Mantenedor";
            // 
            // submenucategoria
            // 
            this.submenucategoria.ForeColor = System.Drawing.Color.Teal;
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(143, 22);
            this.submenucategoria.Text = "Categorias";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click_1);
            // 
            // submenuproducto
            // 
            this.submenuproducto.ForeColor = System.Drawing.Color.Teal;
            this.submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuproducto.IconColor = System.Drawing.Color.Black;
            this.submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuproducto.Name = "submenuproducto";
            this.submenuproducto.Size = new System.Drawing.Size(143, 22);
            this.submenuproducto.Text = "Productos";
            this.submenuproducto.Click += new System.EventHandler(this.submenuproducto_Click_1);
            // 
            // submenunegocio
            // 
            this.submenunegocio.ForeColor = System.Drawing.Color.Teal;
            this.submenunegocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenunegocio.IconColor = System.Drawing.Color.Black;
            this.submenunegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(143, 22);
            this.submenunegocio.Text = "Negocio";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click);
            // 
            // menuventas
            // 
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa});
            this.menuventas.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.menuventas.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 30;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(93, 34);
            this.menuventas.Text = "Ventas";
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.ForeColor = System.Drawing.Color.Teal;
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(146, 22);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click_1);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.ForeColor = System.Drawing.Color.Teal;
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(146, 22);
            this.submenuverdetalleventa.Text = "Ver detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // menucompras
            // 
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarcompra,
            this.submenuverdetallecompra});
            this.menucompras.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompras.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menucompras.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 30;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(105, 34);
            this.menucompras.Text = "Compras";
            // 
            // submenuregistrarcompra
            // 
            this.submenuregistrarcompra.ForeColor = System.Drawing.Color.Teal;
            this.submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarcompra.Name = "submenuregistrarcompra";
            this.submenuregistrarcompra.Size = new System.Drawing.Size(146, 22);
            this.submenuregistrarcompra.Text = "Registrar";
            this.submenuregistrarcompra.Click += new System.EventHandler(this.submenuregistrarcompra_Click_1);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.ForeColor = System.Drawing.Color.Teal;
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(146, 22);
            this.submenuverdetallecompra.Text = "Ver detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click_1);
            // 
            // menuclientes
            // 
            this.menuclientes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuclientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuclientes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 30;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(101, 34);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click_1);
            // 
            // menuproveedores
            // 
            this.menuproveedores.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.menuproveedores.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 30;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(131, 34);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click_1);
            // 
            // menureportes
            // 
            this.menureportes.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.menureportes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 30;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(108, 34);
            this.menureportes.Text = "Reportes";
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click_1);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconMenuItem1.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 30;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(113, 34);
            this.iconMenuItem1.Text = "Acerca de";
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 601);
            this.Controls.Add(this.pictureBoxlogoinicio);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogoinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menucajaregistradora;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private FontAwesome.Sharp.IconMenuItem submenunegocio;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem submenuapertura;
        private FontAwesome.Sharp.IconMenuItem submenucierre;
        private System.Windows.Forms.PictureBox pictureBoxlogoinicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

