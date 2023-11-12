namespace CapaPresentacion
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 351);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(411, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(341, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(341, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contraseña";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtdocumento.Location = new System.Drawing.Point(345, 150);
            this.txtdocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(251, 25);
            this.txtdocumento.TabIndex = 6;
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtclave.Location = new System.Drawing.Point(345, 222);
            this.txtclave.Margin = new System.Windows.Forms.Padding(2);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(251, 25);
            this.txtclave.TabIndex = 7;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btningresar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(355, 277);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(104, 42);
            this.btningresar.TabIndex = 8;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btncancelar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(482, 277);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 42);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 164);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.user_icon_icons_com_66546;
            this.pictureBox2.Location = new System.Drawing.Point(426, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(641, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}