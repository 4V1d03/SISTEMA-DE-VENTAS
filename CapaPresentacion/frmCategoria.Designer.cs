namespace CapaPresentacion
{
    partial class frmCategoria
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
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiartxt = new System.Windows.Forms.Button();
            this.btneliminarusuario = new System.Windows.Forms.Button();
            this.btnguardarusuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtindice.Location = new System.Drawing.Point(209, 33);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(36, 21);
            this.txtindice.TabIndex = 58;
            this.txtindice.Text = "-1";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Azure;
            this.txtbusqueda.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.txtbusqueda.Location = new System.Drawing.Point(473, 220);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(145, 26);
            this.txtbusqueda.TabIndex = 55;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Honeydew;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(308, 220);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(152, 26);
            this.cbobusqueda.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(216, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Filtrar por:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(251, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 21);
            this.txtid.TabIndex = 52;
            this.txtid.Text = "0";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Font = new System.Drawing.Font("Nora Notes", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(449, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 41);
            this.label10.TabIndex = 51;
            this.label10.Text = "Categorias Registradas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Descripcion,
            this.EstadoValor,
            this.Estado});
            this.dgvdata.Location = new System.Drawing.Point(218, 254);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(600, 215);
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
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Nombre de Categoria";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 317;
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
            this.Estado.Width = 250;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.Honeydew;
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.cboestado.ForeColor = System.Drawing.Color.Teal;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(311, 65);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(244, 26);
            this.cboestado.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(309, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Estado:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.txtdescripcion.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.txtdescripcion.ForeColor = System.Drawing.Color.Teal;
            this.txtdescripcion.Location = new System.Drawing.Point(32, 65);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(244, 26);
            this.txtdescripcion.TabIndex = 36;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre de Categoria:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.categ;
            this.pictureBox1.Location = new System.Drawing.Point(400, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.MistyRose;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 1;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(725, 218);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(76, 30);
            this.btnlimpiarbuscador.TabIndex = 57;
            this.btnlimpiarbuscador.Text = "Limpiar";
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnbuscar.IconColor = System.Drawing.Color.LightGreen;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 1;
            this.btnbuscar.Location = new System.Drawing.Point(636, 218);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 30);
            this.btnbuscar.TabIndex = 56;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiartxt
            // 
            this.btnlimpiartxt.BackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxt.BackgroundImage = global::CapaPresentacion.Properties.Resources.tool_paintbrush_115145;
            this.btnlimpiartxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiartxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiartxt.FlatAppearance.BorderSize = 0;
            this.btnlimpiartxt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnlimpiartxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiartxt.ForeColor = System.Drawing.Color.Teal;
            this.btnlimpiartxt.Location = new System.Drawing.Point(848, 316);
            this.btnlimpiartxt.Name = "btnlimpiartxt";
            this.btnlimpiartxt.Size = new System.Drawing.Size(53, 46);
            this.btnlimpiartxt.TabIndex = 64;
            this.btnlimpiartxt.UseVisualStyleBackColor = false;
            this.btnlimpiartxt.Click += new System.EventHandler(this.btnlimpiartxt_Click);
            // 
            // btneliminarusuario
            // 
            this.btneliminarusuario.BackColor = System.Drawing.Color.Azure;
            this.btneliminarusuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.usertrashfull_92826;
            this.btneliminarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminarusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarusuario.FlatAppearance.BorderSize = 0;
            this.btneliminarusuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btneliminarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btneliminarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btneliminarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarusuario.ForeColor = System.Drawing.Color.Teal;
            this.btneliminarusuario.Location = new System.Drawing.Point(848, 400);
            this.btneliminarusuario.Name = "btneliminarusuario";
            this.btneliminarusuario.Size = new System.Drawing.Size(53, 46);
            this.btneliminarusuario.TabIndex = 63;
            this.btneliminarusuario.UseVisualStyleBackColor = false;
            this.btneliminarusuario.Click += new System.EventHandler(this.btneliminarusuario_Click);
            // 
            // btnguardarusuario
            // 
            this.btnguardarusuario.BackColor = System.Drawing.Color.Azure;
            this.btnguardarusuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.Save_as_37111;
            this.btnguardarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnguardarusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarusuario.FlatAppearance.BorderSize = 0;
            this.btnguardarusuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Azure;
            this.btnguardarusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnguardarusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnguardarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarusuario.ForeColor = System.Drawing.Color.Teal;
            this.btnguardarusuario.Location = new System.Drawing.Point(848, 231);
            this.btnguardarusuario.Name = "btnguardarusuario";
            this.btnguardarusuario.Size = new System.Drawing.Size(53, 46);
            this.btnguardarusuario.TabIndex = 62;
            this.btnguardarusuario.UseVisualStyleBackColor = false;
            this.btnguardarusuario.Click += new System.EventHandler(this.btnguardarusuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtindice);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(218, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 118);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción de Categoria de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(841, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(841, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Limpiar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(841, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Guardar";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1113, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlimpiartxt);
            this.Controls.Add(this.btneliminarusuario);
            this.Controls.Add(this.btnguardarusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlimpiartxt;
        private System.Windows.Forms.Button btneliminarusuario;
        private System.Windows.Forms.Button btnguardarusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}