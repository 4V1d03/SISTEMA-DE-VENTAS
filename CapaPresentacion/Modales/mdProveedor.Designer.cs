namespace CapaPresentacion.Modales
{
    partial class mdProveedor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(164, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
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
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(545, 125);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(56, 30);
            this.btnlimpiarbuscador.TabIndex = 92;
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
            this.btnbuscar.Location = new System.Drawing.Point(483, 125);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(56, 30);
            this.btnbuscar.TabIndex = 91;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbusqueda.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(293, 129);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(184, 26);
            this.txtbusqueda.TabIndex = 90;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Beige;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(159, 129);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(128, 26);
            this.cbobusqueda.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Honeydew;
            this.label11.Location = new System.Drawing.Point(37, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 88;
            this.label11.Text = "Buscar según:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Honeydew;
            this.label10.Location = new System.Drawing.Point(299, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 76);
            this.label10.TabIndex = 87;
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
            this.RazonSocial});
            this.dgvdata.Location = new System.Drawing.Point(38, 164);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(581, 264);
            this.dgvdata.TabIndex = 86;
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
            // mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(648, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvdata);
            this.MinimizeBox = false;
            this.Name = "mdProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
    }
}