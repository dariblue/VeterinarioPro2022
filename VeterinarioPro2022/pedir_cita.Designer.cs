
namespace VeterinarioPro2022
{
    partial class pedir_cita
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
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chipMascota = new System.Windows.Forms.TextBox();
            this.motivoCita = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.horarioCita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAnadir
            // 
            this.botonAnadir.BackColor = System.Drawing.Color.LightGreen;
            this.botonAnadir.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.botonAnadir.FlatAppearance.BorderSize = 2;
            this.botonAnadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAnadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnadir.Location = new System.Drawing.Point(446, 394);
            this.botonAnadir.Name = "botonAnadir";
            this.botonAnadir.Size = new System.Drawing.Size(150, 62);
            this.botonAnadir.TabIndex = 30;
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
            this.botonAtras.Location = new System.Drawing.Point(216, 394);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(150, 62);
            this.botonAtras.TabIndex = 31;
            this.botonAtras.Text = "ATRÁS";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "CHIP";
            // 
            // chipMascota
            // 
            this.chipMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipMascota.Location = new System.Drawing.Point(58, 135);
            this.chipMascota.Name = "chipMascota";
            this.chipMascota.Size = new System.Drawing.Size(236, 35);
            this.chipMascota.TabIndex = 33;
            // 
            // motivoCita
            // 
            this.motivoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivoCita.Location = new System.Drawing.Point(467, 135);
            this.motivoCita.Multiline = true;
            this.motivoCita.Name = "motivoCita";
            this.motivoCita.Size = new System.Drawing.Size(280, 174);
            this.motivoCita.TabIndex = 34;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.White;
            this.label_usuario.Location = new System.Drawing.Point(461, 84);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(127, 31);
            this.label_usuario.TabIndex = 35;
            this.label_usuario.Text = "MOTIVO";
            // 
            // horarioCita
            // 
            this.horarioCita.FormattingEnabled = true;
            this.horarioCita.Location = new System.Drawing.Point(58, 272);
            this.horarioCita.Name = "horarioCita";
            this.horarioCita.Size = new System.Drawing.Size(236, 21);
            this.horarioCita.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "FECHA Y HORA";
            // 
            // pedir_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.istockphoto_1297688669_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horarioCita);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.motivoCita);
            this.Controls.Add(this.chipMascota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonAnadir);
            this.Name = "pedir_cita";
            this.Text = "pedir_Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonAnadir;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chipMascota;
        private System.Windows.Forms.TextBox motivoCita;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.ComboBox horarioCita;
        private System.Windows.Forms.Label label1;
    }
}