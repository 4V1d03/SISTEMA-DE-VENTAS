namespace CapaPresentacion
{
    partial class frmAperturacaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidadinicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardarcaja = new FontAwesome.Sharp.IconButton();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigocaja = new System.Windows.Forms.TextBox();
            this.cboestadocaja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "APERTURA DE CAJA REGISTRADORA";
            // 
            // txtcantidadinicial
            // 
            this.txtcantidadinicial.BackColor = System.Drawing.Color.White;
            this.txtcantidadinicial.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadinicial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtcantidadinicial.Location = new System.Drawing.Point(107, 191);
            this.txtcantidadinicial.Name = "txtcantidadinicial";
            this.txtcantidadinicial.Size = new System.Drawing.Size(244, 26);
            this.txtcantidadinicial.TabIndex = 35;
            this.txtcantidadinicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadinicial_KeyPress);
            this.txtcantidadinicial.Validating += new System.ComponentModel.CancelEventHandler(this.txtcantidadinicial_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(105, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad Inicial:";
            // 
            // btnguardarcaja
            // 
            this.btnguardarcaja.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnguardarcaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcaja.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcaja.ForeColor = System.Drawing.Color.Azure;
            this.btnguardarcaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardarcaja.IconColor = System.Drawing.Color.Black;
            this.btnguardarcaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardarcaja.Location = new System.Drawing.Point(160, 246);
            this.btnguardarcaja.Name = "btnguardarcaja";
            this.btnguardarcaja.Size = new System.Drawing.Size(126, 38);
            this.btnguardarcaja.TabIndex = 36;
            this.btnguardarcaja.Text = "Aperturar caja";
            this.btnguardarcaja.UseVisualStyleBackColor = false;
            this.btnguardarcaja.Click += new System.EventHandler(this.btnguardarcaja_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.White;
            this.txtfecha.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtfecha.Location = new System.Drawing.Point(107, 115);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(244, 26);
            this.txtfecha.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(105, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de Apertura:";
            // 
            // txtcodigocaja
            // 
            this.txtcodigocaja.Location = new System.Drawing.Point(50, 93);
            this.txtcodigocaja.Name = "txtcodigocaja";
            this.txtcodigocaja.Size = new System.Drawing.Size(37, 20);
            this.txtcodigocaja.TabIndex = 39;
            this.txtcodigocaja.Visible = false;
            // 
            // cboestadocaja
            // 
            this.cboestadocaja.FormattingEnabled = true;
            this.cboestadocaja.Location = new System.Drawing.Point(3, 135);
            this.cboestadocaja.Name = "cboestadocaja";
            this.cboestadocaja.Size = new System.Drawing.Size(84, 21);
            this.cboestadocaja.TabIndex = 40;
            this.cboestadocaja.Visible = false;
            // 
            // frmAperturacaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(452, 324);
            this.Controls.Add(this.cboestadocaja);
            this.Controls.Add(this.txtcodigocaja);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnguardarcaja);
            this.Controls.Add(this.txtcantidadinicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAperturacaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Caja";
            this.Load += new System.EventHandler(this.frmAperturacaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidadinicial;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnguardarcaja;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigocaja;
        private System.Windows.Forms.ComboBox cboestadocaja;
    }
}