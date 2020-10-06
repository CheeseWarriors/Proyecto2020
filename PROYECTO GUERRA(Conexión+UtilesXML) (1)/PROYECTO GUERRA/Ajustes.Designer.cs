namespace PROYECTO_GUERRA
{
    partial class Ajustes
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
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_usuMySQL = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_BdD = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.textBox_usuMySQL = new System.Windows.Forms.TextBox();
            this.textBox_BdD = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IP.Location = new System.Drawing.Point(27, 55);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(31, 20);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "IP:";
            // 
            // lbl_usuMySQL
            // 
            this.lbl_usuMySQL.AutoSize = true;
            this.lbl_usuMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuMySQL.Location = new System.Drawing.Point(27, 91);
            this.lbl_usuMySQL.Name = "lbl_usuMySQL";
            this.lbl_usuMySQL.Size = new System.Drawing.Size(138, 20);
            this.lbl_usuMySQL.TabIndex = 1;
            this.lbl_usuMySQL.Text = "Usuario MySQL:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(27, 132);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(107, 20);
            this.lbl_contraseña.TabIndex = 2;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // lbl_BdD
            // 
            this.lbl_BdD.AutoSize = true;
            this.lbl_BdD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BdD.Location = new System.Drawing.Point(27, 170);
            this.lbl_BdD.Name = "lbl_BdD";
            this.lbl_BdD.Size = new System.Drawing.Size(133, 20);
            this.lbl_BdD.TabIndex = 3;
            this.lbl_BdD.Text = "Base de Datos:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(64, 55);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(167, 20);
            this.textBox_IP.TabIndex = 4;
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.Location = new System.Drawing.Point(140, 132);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.Size = new System.Drawing.Size(148, 20);
            this.textBox_contraseña.TabIndex = 5;
            // 
            // textBox_usuMySQL
            // 
            this.textBox_usuMySQL.Location = new System.Drawing.Point(171, 91);
            this.textBox_usuMySQL.Name = "textBox_usuMySQL";
            this.textBox_usuMySQL.Size = new System.Drawing.Size(144, 20);
            this.textBox_usuMySQL.TabIndex = 6;
            // 
            // textBox_BdD
            // 
            this.textBox_BdD.Location = new System.Drawing.Point(166, 170);
            this.textBox_BdD.Name = "textBox_BdD";
            this.textBox_BdD.Size = new System.Drawing.Size(146, 20);
            this.textBox_BdD.TabIndex = 7;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(90, 225);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 33);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(214, 225);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 33);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.textBox_BdD);
            this.Controls.Add(this.textBox_usuMySQL);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.lbl_BdD);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuMySQL);
            this.Controls.Add(this.lbl_IP);
            this.Name = "Ajustes";
            this.Text = "Ajustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_usuMySQL;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_BdD;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.TextBox textBox_usuMySQL;
        private System.Windows.Forms.TextBox textBox_BdD;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}