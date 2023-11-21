namespace CapaPresentacion
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnregistrar = new FontAwesome.Sharp.IconButton();
            this.btnagregarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(-59, -198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1227, 827);
            this.label10.TabIndex = 24;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(44, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra:";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(227, 68);
            this.cbotipodocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(232, 31);
            this.cbotipodocumento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(19, 68);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(180, 30);
            this.txtfecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtidproveedor);
            this.groupBox2.Controls.Add(this.btnbuscarproveedor);
            this.groupBox2.Controls.Add(this.txtnombreproveedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdocproveedor);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(533, 134);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor:";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(465, 28);
            this.txtidproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(33, 30);
            this.txtidproveedor.TabIndex = 30;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(269, 68);
            this.txtnombreproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(244, 30);
            this.txtnombreproveedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número de Documento:";
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(8, 68);
            this.txtdocproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.Size = new System.Drawing.Size(180, 30);
            this.txtdocproveedor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnbuscarproducto);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecioventa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtpreciocompra);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(52, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1037, 113);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(932, 58);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(84, 26);
            this.txtcantidad.TabIndex = 40;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(929, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(776, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(777, 54);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(141, 30);
            this.txtprecioventa.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Precio Compra:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(623, 54);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(141, 30);
            this.txtpreciocompra.TabIndex = 34;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(172, 20);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(33, 30);
            this.txtidproducto.TabIndex = 31;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(271, 54);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(343, 30);
            this.txtproducto.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Producto:";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 54);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(180, 30);
            this.txtcodproducto.TabIndex = 0;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(52, 343);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(879, 257);
            this.dgvdata.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(949, 476);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 42;
            this.label12.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(948, 505);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(141, 29);
            this.txttotalpagar.TabIndex = 41;
            this.txttotalpagar.Text = "0";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Honeydew;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(1177, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(307, 654);
            this.label13.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1251, 304);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 17);
            this.label14.TabIndex = 55;
            this.label14.Text = "FACTURA DE COMPRA";
            // 
            // Id
            // 
            this.Id.HeaderText = "IdProducto";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 35;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 160;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            this.PrecioVenta.Width = 105;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.LightCyan;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.Green;
            this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnregistrar.IconColor = System.Drawing.Color.Green;
            this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrar.IconSize = 40;
            this.btnregistrar.Location = new System.Drawing.Point(951, 543);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(140, 58);
            this.btnregistrar.TabIndex = 53;
            this.btnregistrar.Text = "Registrar Venta";
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.BackColor = System.Drawing.Color.LightCyan;
            this.btnagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarproducto.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarproducto.ForeColor = System.Drawing.Color.Green;
            this.btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnagregarproducto.IconColor = System.Drawing.Color.Green;
            this.btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarproducto.IconSize = 40;
            this.btnagregarproducto.Location = new System.Drawing.Point(955, 352);
            this.btnagregarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(123, 97);
            this.btnagregarproducto.TabIndex = 52;
            this.btnagregarproducto.Text = "Agregar";
            this.btnagregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarproducto.UseVisualStyleBackColor = false;
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.Location = new System.Drawing.Point(203, 55);
            this.btnbuscarproducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(57, 33);
            this.btnbuscarproducto.TabIndex = 31;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscarproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproveedor.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproveedor.IconSize = 20;
            this.btnbuscarproveedor.Location = new System.Drawing.Point(203, 68);
            this.btnbuscarproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(57, 33);
            this.btnbuscarproveedor.TabIndex = 29;
            this.btnbuscarproveedor.UseVisualStyleBackColor = false;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 654);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotalpagar;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}