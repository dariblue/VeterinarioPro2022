
namespace VeterinarioPro2022
{
    partial class datos_animal
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
            this.label2 = new System.Windows.Forms.Label();
            this.especieMascota = new System.Windows.Forms.TextBox();
            this.nombreMascota = new System.Windows.Forms.TextBox();
            this.razaMascota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.dni = new System.Windows.Forms.Label();
            this.dniDueno = new System.Windows.Forms.TextBox();
            this.chipMascota = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "*RAZA";
            // 
            // especieMascota
            // 
            this.especieMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especieMascota.Location = new System.Drawing.Point(513, 270);
            this.especieMascota.Name = "especieMascota";
            this.especieMascota.Size = new System.Drawing.Size(236, 35);
            this.especieMascota.TabIndex = 6;
            this.especieMascota.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nombreMascota
            // 
            this.nombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMascota.Location = new System.Drawing.Point(133, 294);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(236, 35);
            this.nombreMascota.TabIndex = 4;
            // 
            // razaMascota
            // 
            this.razaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razaMascota.Location = new System.Drawing.Point(133, 399);
            this.razaMascota.Name = "razaMascota";
            this.razaMascota.Size = new System.Drawing.Size(236, 35);
            this.razaMascota.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESPECIE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonAnadir
            // 
            this.botonAnadir.BackColor = System.Drawing.Color.LightGreen;
            this.botonAnadir.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.botonAnadir.FlatAppearance.BorderSize = 2;
            this.botonAnadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAnadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnadir.Location = new System.Drawing.Point(461, 490);
            this.botonAnadir.Name = "botonAnadir";
            this.botonAnadir.Size = new System.Drawing.Size(150, 62);
            this.botonAnadir.TabIndex = 14;
            this.botonAnadir.Text = "AÑADIR";
            this.botonAnadir.UseVisualStyleBackColor = false;
            this.botonAnadir.Click += new System.EventHandler(this.botonAnadir_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.IndianRed;
            this.botonAtras.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.botonAtras.FlatAppearance.BorderSize = 2;
            this.botonAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Location = new System.Drawing.Point(264, 490);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(150, 62);
            this.botonAtras.TabIndex = 15;
            this.botonAtras.Text = "ATRÁS";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.BackColor = System.Drawing.Color.Transparent;
            this.dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(507, 321);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(65, 31);
            this.dni.TabIndex = 16;
            this.dni.Text = "DNI";
            // 
            // dniDueno
            // 
            this.dniDueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniDueno.Location = new System.Drawing.Point(513, 367);
            this.dniDueno.Name = "dniDueno";
            this.dniDueno.Size = new System.Drawing.Size(236, 35);
            this.dniDueno.TabIndex = 17;
            // 
            // chipMascota
            // 
            this.chipMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipMascota.Location = new System.Drawing.Point(133, 196);
            this.chipMascota.Name = "chipMascota";
            this.chipMascota.Size = new System.Drawing.Size(236, 35);
            this.chipMascota.TabIndex = 18;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(127, 250);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(139, 31);
            this.label_usuario.TabIndex = 5;
            this.label_usuario.Text = "NOMBRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(127, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "CHIP";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(869, 93);
            this.label3.TabIndex = 20;
            this.label3.Text = "AÑADE TU MASCOTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datos_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.MASCOTAS;
            this.ClientSize = new System.Drawing.Size(869, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chipMascota);
            this.Controls.Add(this.dniDueno);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAnadir);
            this.Controls.Add(this.razaMascota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.especieMascota);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.nombreMascota);
            this.DoubleBuffered = true;
            this.Name = "datos_animal";
            this.Text = "datosAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox especieMascota;
        private System.Windows.Forms.TextBox nombreMascota;
        private System.Windows.Forms.TextBox razaMascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAnadir;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.TextBox dniDueno;
        private System.Windows.Forms.TextBox chipMascota;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}