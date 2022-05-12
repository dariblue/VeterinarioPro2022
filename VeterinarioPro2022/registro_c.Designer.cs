
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
            this.label_Dni = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_contraseña = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.b_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creaUsuario
            // 
            this.creaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.creaUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.creaUsuario.FlatAppearance.BorderSize = 2;
            this.creaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.creaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.creaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creaUsuario.Location = new System.Drawing.Point(715, 198);
            this.creaUsuario.Name = "creaUsuario";
            this.creaUsuario.Size = new System.Drawing.Size(142, 69);
            this.creaUsuario.TabIndex = 0;
            this.creaUsuario.Text = "Registrar!";
            this.creaUsuario.UseVisualStyleBackColor = false;
            this.creaUsuario.Click += new System.EventHandler(this.creaUsuario_Click);
            // 
            // text_dni
            // 
            this.text_dni.BackColor = System.Drawing.SystemColors.Window;
            this.text_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_dni.Location = new System.Drawing.Point(198, 67);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(166, 35);
            this.text_dni.TabIndex = 1;
            // 
            // text_nombre
            // 
            this.text_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nombre.Location = new System.Drawing.Point(198, 122);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(166, 35);
            this.text_nombre.TabIndex = 2;
            // 
            // text_usuario
            // 
            this.text_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_usuario.Location = new System.Drawing.Point(198, 180);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(166, 35);
            this.text_usuario.TabIndex = 3;
            // 
            // text_contraseña
            // 
            this.text_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contraseña.Location = new System.Drawing.Point(198, 245);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(166, 35);
            this.text_contraseña.TabIndex = 4;
            // 
            // label_Dni
            // 
            this.label_Dni.AutoSize = true;
            this.label_Dni.BackColor = System.Drawing.Color.Transparent;
            this.label_Dni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dni.ForeColor = System.Drawing.Color.White;
            this.label_Dni.Location = new System.Drawing.Point(79, 70);
            this.label_Dni.Name = "label_Dni";
            this.label_Dni.Size = new System.Drawing.Size(57, 29);
            this.label_Dni.TabIndex = 5;
            this.label_Dni.Text = "DNI";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(51, 183);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(103, 29);
            this.label_usuario.TabIndex = 7;
            this.label_usuario.Text = "Usuario";
            // 
            // label_contraseña
            // 
            this.label_contraseña.AutoSize = true;
            this.label_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.label_contraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contraseña.ForeColor = System.Drawing.Color.White;
            this.label_contraseña.Location = new System.Drawing.Point(29, 251);
            this.label_contraseña.Name = "label_contraseña";
            this.label_contraseña.Size = new System.Drawing.Size(146, 29);
            this.label_contraseña.TabIndex = 8;
            this.label_contraseña.Text = "Contraseña";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.White;
            this.label_nombre.Location = new System.Drawing.Point(52, 125);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(107, 29);
            this.label_nombre.TabIndex = 9;
            this.label_nombre.Text = "Nombre";
            // 
            // b_atras
            // 
            this.b_atras.BackColor = System.Drawing.Color.Transparent;
            this.b_atras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.b_atras.FlatAppearance.BorderSize = 2;
            this.b_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_atras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_atras.Location = new System.Drawing.Point(715, 50);
            this.b_atras.Name = "b_atras";
            this.b_atras.Size = new System.Drawing.Size(142, 69);
            this.b_atras.TabIndex = 10;
            this.b_atras.Text = "<-- Atras";
            this.b_atras.UseVisualStyleBackColor = false;
            this.b_atras.Click += new System.EventHandler(this.b_atras_Click);
            // 
            // registro_c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.fondos_de_pantalla_de_pajaros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 338);
            this.Controls.Add(this.b_atras);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_contraseña);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_Dni);
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
        private System.Windows.Forms.Label label_Dni;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_contraseña;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Button b_atras;
    }
}