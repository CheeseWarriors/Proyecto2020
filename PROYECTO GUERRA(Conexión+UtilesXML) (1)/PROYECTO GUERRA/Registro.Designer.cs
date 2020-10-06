namespace PROYECTO_GUERRA
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lbl_NomUsu = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.textBoxCI = new System.Windows.Forms.TextBox();
            this.textBoxNomUsu = new System.Windows.Forms.TextBox();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.lbl_VContrasena = new System.Windows.Forms.Label();
            this.textBoxVContrasena = new System.Windows.Forms.TextBox();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.btn_ISesion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NomUsu
            // 
            this.lbl_NomUsu.AutoSize = true;
            this.lbl_NomUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomUsu.Location = new System.Drawing.Point(265, 219);
            this.lbl_NomUsu.Name = "lbl_NomUsu";
            this.lbl_NomUsu.Size = new System.Drawing.Size(160, 18);
            this.lbl_NomUsu.TabIndex = 1;
            this.lbl_NomUsu.Text = "Nombre de Usuario:";
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCI.Location = new System.Drawing.Point(265, 164);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(132, 18);
            this.lblCI.TabIndex = 2;
            this.lblCI.Text = "Cédula Identidad";
            // 
            // textBoxCI
            // 
            this.textBoxCI.Location = new System.Drawing.Point(268, 185);
            this.textBoxCI.Name = "textBoxCI";
            this.textBoxCI.Size = new System.Drawing.Size(263, 20);
            this.textBoxCI.TabIndex = 3;
            this.textBoxCI.TextChanged += new System.EventHandler(this.textBoxCI_TextChanged);
            // 
            // textBoxNomUsu
            // 
            this.textBoxNomUsu.Location = new System.Drawing.Point(268, 240);
            this.textBoxNomUsu.Name = "textBoxNomUsu";
            this.textBoxNomUsu.Size = new System.Drawing.Size(263, 20);
            this.textBoxNomUsu.TabIndex = 4;
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrasena.Location = new System.Drawing.Point(265, 276);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(100, 18);
            this.lbl_Contrasena.TabIndex = 5;
            this.lbl_Contrasena.Text = "Contraseña:";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(268, 297);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(263, 20);
            this.textBoxContrasena.TabIndex = 6;
            // 
            // lbl_VContrasena
            // 
            this.lbl_VContrasena.AutoSize = true;
            this.lbl_VContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VContrasena.Location = new System.Drawing.Point(265, 333);
            this.lbl_VContrasena.Name = "lbl_VContrasena";
            this.lbl_VContrasena.Size = new System.Drawing.Size(193, 18);
            this.lbl_VContrasena.TabIndex = 7;
            this.lbl_VContrasena.Text = "Verificacion Contraseña:";
            // 
            // textBoxVContrasena
            // 
            this.textBoxVContrasena.Location = new System.Drawing.Point(268, 354);
            this.textBoxVContrasena.Name = "textBoxVContrasena";
            this.textBoxVContrasena.Size = new System.Drawing.Size(263, 20);
            this.textBoxVContrasena.TabIndex = 8;
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrarse.Location = new System.Drawing.Point(340, 396);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(118, 38);
            this.btn_Registrarse.TabIndex = 9;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ISesion
            // 
            this.btn_ISesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ISesion.ForeColor = System.Drawing.Color.Navy;
            this.btn_ISesion.Location = new System.Drawing.Point(681, 412);
            this.btn_ISesion.Name = "btn_ISesion";
            this.btn_ISesion.Size = new System.Drawing.Size(107, 28);
            this.btn_ISesion.TabIndex = 10;
            this.btn_ISesion.Text = "Inicia Sesión";
            this.btn_ISesion.UseVisualStyleBackColor = true;
            this.btn_ISesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ya tienes una cuenta?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_GUERRA.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(258, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ISesion);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.textBoxVContrasena);
            this.Controls.Add(this.lbl_VContrasena);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.textBoxNomUsu);
            this.Controls.Add(this.textBoxCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lbl_NomUsu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_NomUsu;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.TextBox textBoxCI;
        private System.Windows.Forms.TextBox textBoxNomUsu;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label lbl_VContrasena;
        private System.Windows.Forms.TextBox textBoxVContrasena;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.Button btn_ISesion;
        private System.Windows.Forms.Label label5;
    }
}