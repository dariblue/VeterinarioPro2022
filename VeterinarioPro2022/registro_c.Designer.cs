
namespace VeterinarioPro2022
{
    partial class registro_c
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
            this.creaUsuario = new System.Windows.Forms.Button();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // creaUsuario
            // 
            this.creaUsuario.Location = new System.Drawing.Point(489, 97);
            this.creaUsuario.Name = "creaUsuario";
            this.creaUsuario.Size = new System.Drawing.Size(133, 69);
            this.creaUsuario.TabIndex = 0;
            this.creaUsuario.Text = "button1";
            this.creaUsuario.UseVisualStyleBackColor = true;
            this.creaUsuario.Click += new System.EventHandler(this.creaUsuario_Click);
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(160, 85);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(100, 20);
            this.text_dni.TabIndex = 1;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(160, 122);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(100, 20);
            this.text_nombre.TabIndex = 2;
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(160, 163);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(100, 20);
            this.text_usuario.TabIndex = 3;
            // 
            // text_contraseña
            // 
            this.text_contraseña.Location = new System.Drawing.Point(160, 207);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(100, 20);
            this.text_contraseña.TabIndex = 4;
            // 
            // registro_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_contraseña);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.creaUsuario);
            this.Name = "registro_c";
            this.Text = "registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creaUsuario;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_contraseña;
    }
}