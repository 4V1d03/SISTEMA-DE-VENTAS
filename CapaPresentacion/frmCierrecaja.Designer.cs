namespace CapaPresentacion
{
    partial class frmCierrecaja
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
            this.txtcantidadinicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidadfinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalventas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechacierre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.cboestadocaja = new System.Windows.Forms.ComboBox();
            this.txtcodigocaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcantidadinicial
            // 
            this.txtcantidadinicial.BackColor = System.Drawing.Color.White;
            this.txtcantidadinicial.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadinicial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtcantidadinicial.Location = new System.Drawing.Point(36, 200);
            this.txtcantidadinicial.Name = "txtcantidadinicial";
            this.txtcantidadinicial.ReadOnly = true;
            this.txtcantidadinicial.Size = new System.Drawing.Size(244, 26);
            this.txtcantidadinicial.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(34, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cantidad Inicial:";
            // 
            // txtcantidadfinal
            // 
            this.txtcantidadfinal.BackColor = System.Drawing.Color.White;
            this.txtcantidadfinal.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadfinal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtcantidadfinal.Location = new System.Drawing.Point(35, 267);
            this.txtcantidadfinal.Name = "txtcantidadfinal";
            this.txtcantidadfinal.ReadOnly = true;
            this.txtcantidadfinal.Size = new System.Drawing.Size(244, 26);
            this.txtcantidadfinal.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(33, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cantidad Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "CIERRE CAJA REGISTRADORA";
            // 
            // txttotalventas
            // 
            this.txttotalventas.BackColor = System.Drawing.Color.White;
            this.txttotalventas.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalventas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txttotalventas.Location = new System.Drawing.Point(301, 200);
            this.txttotalventas.Name = "txttotalventas";
            this.txttotalventas.ReadOnly = true;
            this.txttotalventas.Size = new System.Drawing.Size(244, 26);
            this.txttotalventas.TabIndex = 43;
            this.txttotalventas.Validating += new System.ComponentModel.CancelEventHandler(this.txttotalventas_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(299, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Total Ventas:";
            // 
            // txtfechacierre
            // 
            this.txtfechacierre.BackColor = System.Drawing.Color.White;
            this.txtfechacierre.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechacierre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtfechacierre.Location = new System.Drawing.Point(302, 135);
            this.txtfechacierre.Name = "txtfechacierre";
            this.txtfechacierre.ReadOnly = true;
            this.txtfechacierre.Size = new System.Drawing.Size(244, 26);
            this.txtfechacierre.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(300, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha de Cierre:";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.BackColor = System.Drawing.Color.White;
            this.txtfechainicio.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechainicio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtfechainicio.Location = new System.Drawing.Point(35, 135);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.ReadOnly = true;
            this.txtfechainicio.Size = new System.Drawing.Size(244, 26);
            this.txtfechainicio.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CadetBlue;
            this.label6.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(33, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha de Apertura:";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Azure;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(301, 251);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(86, 42);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Text = "Calcular";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Azure;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(408, 251);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(117, 42);
            this.iconButton2.TabIndex = 49;
            this.iconButton2.Text = "Guardar Cierre";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // cboestadocaja
            // 
            this.cboestadocaja.FormattingEnabled = true;
            this.cboestadocaja.Location = new System.Drawing.Point(35, 78);
            this.cboestadocaja.Name = "cboestadocaja";
            this.cboestadocaja.Size = new System.Drawing.Size(84, 21);
            this.cboestadocaja.TabIndex = 50;
            this.cboestadocaja.Visible = false;
            // 
            // txtcodigocaja
            // 
            this.txtcodigocaja.Location = new System.Drawing.Point(35, 45);
            this.txtcodigocaja.Name = "txtcodigocaja";
            this.txtcodigocaja.Size = new System.Drawing.Size(37, 20);
            this.txtcodigocaja.TabIndex = 51;
            this.txtcodigocaja.Visible = false;
            // 
            // frmCierrecaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(575, 364);
            this.Controls.Add(this.txtcodigocaja);
            this.Controls.Add(this.cboestadocaja);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfechacierre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotalventas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidadinicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcantidadfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCierrecaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Caja";
            this.Load += new System.EventHandler(this.frmCierrecaja_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcantidadinicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidadfinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfechacierre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfechainicio;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox cboestadocaja;
        private System.Windows.Forms.TextBox txtcodigocaja;
    }
}