namespace CapaPresentacion
{
    partial class frmClientes
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiartxtcli = new System.Windows.Forms.Button();
            this.btneliminarcli = new System.Windows.Forms.Button();
            this.btnguardcli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtindice.Location = new System.Drawing.Point(14, 103);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(36, 21);
            this.txtindice.TabIndex = 58;
            this.txtindice.Text = "-1";
            this.txtindice.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbusqueda.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtbusqueda.ForeColor = System.Drawing.Color.Teal;
            this.txtbusqueda.Location = new System.Drawing.Point(466, 211);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(207, 26);
            this.txtbusqueda.TabIndex = 55;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Honeydew;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.cbobusqueda.ForeColor = System.Drawing.Color.Teal;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(295, 211);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(158, 26);
            this.cbobusqueda.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Azure;
            this.label11.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(190, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Filtrar Por:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(56, 103);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 21);
            this.txtid.TabIndex = 52;
            this.txtid.Text = "0";
            this.txtid.Visible = false;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Honeydew;
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
            this.NombreCompleto,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(121, 246);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(755, 258);
            this.dgvdata.TabIndex = 50;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
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
            this.Documento.HeaderText = "No. Identidad";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 130;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
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
            this.Telefono.HeaderText = "No. Telefono";
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
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Font = new System.Drawing.Font("Nora Notes", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(502, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 30);
            this.label7.TabIndex = 49;
            this.label7.Text = "Gestión  de  Clientes";
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Honeydew;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.cboestado.ForeColor = System.Drawing.Color.Teal;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(860, 66);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(167, 26);
            this.cboestado.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(858, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Estado:";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            this.txttelefono.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txttelefono.ForeColor = System.Drawing.Color.Teal;
            this.txttelefono.Location = new System.Drawing.Point(691, 66);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(163, 26);
            this.txttelefono.TabIndex = 40;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtcorreo.ForeColor = System.Drawing.Color.Teal;
            this.txtcorreo.Location = new System.Drawing.Point(467, 66);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(205, 26);
            this.txtcorreo.TabIndex = 39;
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.White;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtnombrecompleto.ForeColor = System.Drawing.Color.Teal;
            this.txtnombrecompleto.Location = new System.Drawing.Point(202, 68);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(244, 26);
            this.txtnombrecompleto.TabIndex = 38;
            this.txtnombrecompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrecompleto_KeyPress);
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.White;
            this.txtdocumento.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtdocumento.ForeColor = System.Drawing.Color.Teal;
            this.txtdocumento.Location = new System.Drawing.Point(17, 68);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(165, 26);
            this.txtdocumento.TabIndex = 37;
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(689, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "No. Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(465, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Correo Electrónico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(200, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "No. Identidad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources._2820137;
            this.pictureBox1.Location = new System.Drawing.Point(450, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.MistyRose;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 1;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(770, 209);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(75, 30);
            this.btnlimpiarbuscador.TabIndex = 57;
            this.btnlimpiarbuscador.Text = "Limpiar";
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 1;
            this.btnbuscar.Location = new System.Drawing.Point(686, 209);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 30);
            this.btnbuscar.TabIndex = 56;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiartxtcli
            // 
            this.btnlimpiartxtcli.BackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxtcli.BackgroundImage = global::CapaPresentacion.Properties.Resources.tool_paintbrush_115145;
            this.btnlimpiartxtcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiartxtcli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiartxtcli.FlatAppearance.BorderSize = 0;
            this.btnlimpiartxtcli.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxtcli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxtcli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxtcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiartxtcli.ForeColor = System.Drawing.Color.Teal;
            this.btnlimpiartxtcli.Location = new System.Drawing.Point(910, 334);
            this.btnlimpiartxtcli.Name = "btnlimpiartxtcli";
            this.btnlimpiartxtcli.Size = new System.Drawing.Size(50, 50);
            this.btnlimpiartxtcli.TabIndex = 65;
            this.btnlimpiartxtcli.UseVisualStyleBackColor = false;
            this.btnlimpiartxtcli.Click += new System.EventHandler(this.btnlimpiartxtcli_Click);
            // 
            // btneliminarcli
            // 
            this.btneliminarcli.BackColor = System.Drawing.Color.Azure;
            this.btneliminarcli.BackgroundImage = global::CapaPresentacion.Properties.Resources.usertrashfull_92826;
            this.btneliminarcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminarcli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarcli.FlatAppearance.BorderSize = 0;
            this.btneliminarcli.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btneliminarcli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btneliminarcli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btneliminarcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarcli.ForeColor = System.Drawing.Color.Teal;
            this.btneliminarcli.Location = new System.Drawing.Point(910, 430);
            this.btneliminarcli.Name = "btneliminarcli";
            this.btneliminarcli.Size = new System.Drawing.Size(50, 50);
            this.btneliminarcli.TabIndex = 64;
            this.btneliminarcli.UseVisualStyleBackColor = false;
            this.btneliminarcli.Click += new System.EventHandler(this.btneliminarcli_Click);
            // 
            // btnguardcli
            // 
            this.btnguardcli.BackColor = System.Drawing.Color.Azure;
            this.btnguardcli.BackgroundImage = global::CapaPresentacion.Properties.Resources.Save_as_37111;
            this.btnguardcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardcli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardcli.FlatAppearance.BorderSize = 0;
            this.btnguardcli.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnguardcli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnguardcli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnguardcli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardcli.ForeColor = System.Drawing.Color.Teal;
            this.btnguardcli.Location = new System.Drawing.Point(910, 246);
            this.btnguardcli.Name = "btnguardcli";
            this.btnguardcli.Size = new System.Drawing.Size(50, 50);
            this.btnguardcli.TabIndex = 63;
            this.btnguardcli.UseVisualStyleBackColor = false;
            this.btnguardcli.Click += new System.EventHandler(this.btnguardcli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.txtindice);
            this.groupBox1.Controls.Add(this.txtnombrecompleto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(36, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 130);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(902, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(902, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Limpiar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(902, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 69;
            this.label8.Text = "Eliminar";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1113, 531);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpiartxtcli);
            this.Controls.Add(this.btneliminarcli);
            this.Controls.Add(this.btnguardcli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label7);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiartxtcli;
        private System.Windows.Forms.Button btneliminarcli;
        private System.Windows.Forms.Button btnguardcli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}