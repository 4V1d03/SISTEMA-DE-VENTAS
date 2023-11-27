namespace CapaPresentacion
{
    partial class frmRegistrosCaja
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Idregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechaapertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechacierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btndescargarpdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
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
            this.Idregistro,
            this.Usuario,
            this.Fechaapertura,
            this.Cantidadinicial,
            this.Fechacierre,
            this.Cantidadfinal,
            this.Valortotal});
            this.dgvdata.Location = new System.Drawing.Point(41, 145);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(893, 309);
            this.dgvdata.TabIndex = 51;
            // 
            // Idregistro
            // 
            this.Idregistro.HeaderText = "Idregistro";
            this.Idregistro.MinimumWidth = 6;
            this.Idregistro.Name = "Idregistro";
            this.Idregistro.ReadOnly = true;
            this.Idregistro.Visible = false;
            this.Idregistro.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 180;
            // 
            // Fechaapertura
            // 
            this.Fechaapertura.HeaderText = "Fecha de Apertura";
            this.Fechaapertura.MinimumWidth = 6;
            this.Fechaapertura.Name = "Fechaapertura";
            this.Fechaapertura.ReadOnly = true;
            this.Fechaapertura.Width = 140;
            // 
            // Cantidadinicial
            // 
            this.Cantidadinicial.HeaderText = "Cantidad Inicial";
            this.Cantidadinicial.MinimumWidth = 6;
            this.Cantidadinicial.Name = "Cantidadinicial";
            this.Cantidadinicial.ReadOnly = true;
            this.Cantidadinicial.Width = 130;
            // 
            // Fechacierre
            // 
            this.Fechacierre.HeaderText = "Fecha de Cierre";
            this.Fechacierre.MinimumWidth = 6;
            this.Fechacierre.Name = "Fechacierre";
            this.Fechacierre.ReadOnly = true;
            this.Fechacierre.Width = 140;
            // 
            // Cantidadfinal
            // 
            this.Cantidadfinal.HeaderText = "Cantidad Final";
            this.Cantidadfinal.Name = "Cantidadfinal";
            this.Cantidadfinal.ReadOnly = true;
            this.Cantidadfinal.Width = 130;
            // 
            // Valortotal
            // 
            this.Valortotal.HeaderText = "Valor Total";
            this.Valortotal.Name = "Valortotal";
            this.Valortotal.ReadOnly = true;
            this.Valortotal.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(270, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "HISTORIAL DE CAJA REGISTRADORA";
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.Wheat;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 1;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(559, 99);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(83, 30);
            this.btnlimpiarbuscador.TabIndex = 62;
            this.btnlimpiarbuscador.Text = "Limpiar";
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Roboto Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 1;
            this.btnbuscar.Location = new System.Drawing.Point(456, 99);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(89, 30);
            this.btnbuscar.TabIndex = 61;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.GhostWhite;
            this.txtbusqueda.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.txtbusqueda.ForeColor = System.Drawing.Color.Teal;
            this.txtbusqueda.Location = new System.Drawing.Point(261, 101);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(184, 26);
            this.txtbusqueda.TabIndex = 60;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.BackColor = System.Drawing.Color.Honeydew;
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.Font = new System.Drawing.Font("Roboto Cn", 11.25F);
            this.cbobusqueda.ForeColor = System.Drawing.Color.Teal;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(127, 101);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(128, 26);
            this.cbobusqueda.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Roboto Bk", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(44, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 58;
            this.label11.Text = "Filtrar Por:";
            // 
            // btndescargarpdf
            // 
            this.btndescargarpdf.BackColor = System.Drawing.Color.White;
            this.btndescargarpdf.BackgroundImage = global::CapaPresentacion.Properties.Resources.icono_PDF;
            this.btndescargarpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndescargarpdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargarpdf.Location = new System.Drawing.Point(672, 90);
            this.btndescargarpdf.Name = "btndescargarpdf";
            this.btndescargarpdf.Size = new System.Drawing.Size(49, 47);
            this.btndescargarpdf.TabIndex = 68;
            this.btndescargarpdf.UseVisualStyleBackColor = false;
            // 
            // frmRegistrosCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(982, 490);
            this.Controls.Add(this.btndescargarpdf);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistrosCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechaapertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechacierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valortotal;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btndescargarpdf;
    }
}