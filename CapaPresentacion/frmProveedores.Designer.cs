namespace CapaPresentacion
{
    partial class frmProveedores
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
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(189, 175);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(36, 20);
            this.txtindice.TabIndex = 84;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbusqueda.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(586, 149);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(184, 26);
            this.txtbusqueda.TabIndex = 81;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Beige;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(452, 149);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(128, 26);
            this.cbobusqueda.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightCyan;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(330, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 79;
            this.label11.Text = "Buscar según:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(231, 175);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 20);
            this.txtid.TabIndex = 78;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(698, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 76);
            this.label10.TabIndex = 77;
            this.label10.Text = "Proveedores Registrados";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(331, 184);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(755, 264);
            this.dgvdata.TabIndex = 76;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.MinimumWidth = 6;
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "No Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 120;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 160;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(36, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 31);
            this.label7.TabIndex = 75;
            this.label7.Text = "Descripción del Proveedor";
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Silver;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(22, 422);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(244, 26);
            this.cboestado.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Honeydew;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(20, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 71;
            this.label9.Text = "Estado:";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            this.txttelefono.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txttelefono.Location = new System.Drawing.Point(22, 369);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '*';
            this.txttelefono.Size = new System.Drawing.Size(244, 26);
            this.txttelefono.TabIndex = 70;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtcorreo.Location = new System.Drawing.Point(22, 312);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(244, 26);
            this.txtcorreo.TabIndex = 69;
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.BackColor = System.Drawing.Color.White;
            this.txtrazonsocial.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazonsocial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtrazonsocial.Location = new System.Drawing.Point(21, 257);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(244, 26);
            this.txtrazonsocial.TabIndex = 68;
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.White;
            this.txtdocumento.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtdocumento.Location = new System.Drawing.Point(23, 199);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(244, 24);
            this.txtdocumento.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(20, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(20, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(21, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "No. Documento:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 531);
            this.label1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(40, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre Completo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Honeydew;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 87;
            this.label6.Text = "Razon Social:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.lista_de_verificacion;
            this.pictureBox2.Location = new System.Drawing.Point(96, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(563, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.MistyRose;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 22;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(838, 145);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(56, 30);
            this.btnlimpiarbuscador.TabIndex = 83;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 20;
            this.btnbuscar.Location = new System.Drawing.Point(776, 145);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(56, 30);
            this.btnbuscar.TabIndex = 82;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(39, 477);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(95, 38);
            this.btnguardar.TabIndex = 73;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.Location = new System.Drawing.Point(153, 477);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(103, 38);
            this.btneliminar.TabIndex = 74;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}