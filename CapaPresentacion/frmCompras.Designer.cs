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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(-44, -161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(920, 672);
            this.label10.TabIndex = 24;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(33, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 109);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Documento:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnbuscar);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 109);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número de Documento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 26);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(349, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 26);
            this.textBox4.TabIndex = 30;
            this.textBox4.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.iconButton3);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecioventa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtpreciocompra);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtnombreproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(39, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(778, 92);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo Producto:";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(7, 44);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(136, 26);
            this.txtcodproducto.TabIndex = 0;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(203, 44);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(258, 26);
            this.txtnombreproducto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Producto:";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(129, 16);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(26, 26);
            this.txtidproducto.TabIndex = 31;
            this.txtidproducto.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Precio Compra:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(467, 44);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(107, 26);
            this.txtpreciocompra.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Precio Venta:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(583, 44);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(107, 26);
            this.txtprecioventa.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(697, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(699, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Id,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(39, 279);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(659, 209);
            this.dgvdata.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(712, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 42;
            this.label12.Text = "Total a Pagar:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(711, 410);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 24);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "0";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Honeydew;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(882, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 531);
            this.label13.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(938, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "FACTURA DE COMPRA";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightCyan;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Green;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconButton2.IconColor = System.Drawing.Color.Green;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(713, 441);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(105, 47);
            this.iconButton2.TabIndex = 53;
            this.iconButton2.Text = "Registrar Venta";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightCyan;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Green;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(716, 286);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(92, 79);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.LightGreen;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(152, 45);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(43, 27);
            this.iconButton3.TabIndex = 31;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 20;
            this.btnbuscar.Location = new System.Drawing.Point(152, 55);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(43, 27);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 63;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdProducto";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
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
            this.btneliminar.Visible = false;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 531);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}