namespace VeterinarioPro2022
{
    partial class login_trabajador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_trabajador));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_supletorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contraseñaUsuario
            // 
            this.contraseñaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaUsuario.ForeColor = System.Drawing.Color.Gray;
            this.contraseñaUsuario.Location = new System.Drawing.Point(147, 371);
            this.contraseñaUsuario.Name = "contraseñaUsuario";
            this.contraseñaUsuario.Size = new System.Drawing.Size(236, 35);
            this.contraseñaUsuario.TabIndex = 30;
            this.contraseñaUsuario.Text = "Contraseña";
            this.contraseñaUsuario.Enter += new System.EventHandler(this.contraseñaUsuario_Enter);
            this.contraseñaUsuario.Leave += new System.EventHandler(this.contraseñaUsuario_Leave);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.ForeColor = System.Drawing.Color.Gray;
            this.NombreUsuario.Location = new System.Drawing.Point(147, 239);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(236, 35);
            this.NombreUsuario.TabIndex = 29;
            this.NombreUsuario.Text = "DNI";
            this.NombreUsuario.Enter += new System.EventHandler(this.NombreUsuario_Enter);
            this.NombreUsuario.Leave += new System.EventHandler(this.NombreUsuario_Leave);
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonAcceder.FlatAppearance.BorderSize = 3;
            this.botonAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAcceder.Location = new System.Drawing.Point(581, 496);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(146, 50);
            this.botonAcceder.TabIndex = 27;
            this.botonAcceder.Text = "ACCEDER";
            this.botonAcceder.UseVisualStyleBackColor = false;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_usuario.Location = new System.Drawing.Point(141, 164);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(65, 31);
            this.label_usuario.TabIndex = 25;
            this.label_usuario.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "LOGIN";
            // 
            // boton_supletorio
            // 
            this.boton_supletorio.BackColor = System.Drawing.Color.Transparent;
            this.boton_supletorio.FlatAppearance.BorderSize = 0;
            this.boton_supletorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_supletorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_supletorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_supletorio.Location = new System.Drawing.Point(-10, -6);
            this.boton_supletorio.Name = "boton_supletorio";
            this.boton_supletorio.Size = new System.Drawing.Size(895, 576);
            this.boton_supletorio.TabIndex = 23;
            this.boton_supletorio.UseVisualStyleBackColor = false;
            // 
            // login_trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.Fondo_de_pantalla_veterinario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 565);
            this.Controls.Add(this.contraseñaUsuario);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.botonAcceder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_supletorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_trabajador";
            this.Text = "Area_Trabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox contraseñaUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_supletorio;
    }
}