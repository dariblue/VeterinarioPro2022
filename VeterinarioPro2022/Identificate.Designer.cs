namespace VeterinarioPro2022
{
    partial class Identificate
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identificate));
            this.Acceso_Cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Acceso_Trabajador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Acceso_Cliente
            // 
            this.Acceso_Cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Acceso_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Acceso_Cliente.AutoSize = true;
            this.Acceso_Cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Acceso_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Acceso_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Acceso_Cliente.CausesValidation = false;
            this.Acceso_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acceso_Cliente.FlatAppearance.BorderSize = 2;
            this.Acceso_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Acceso_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Acceso_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceso_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceso_Cliente.ForeColor = System.Drawing.Color.White;
            this.Acceso_Cliente.Location = new System.Drawing.Point(502, 209);
            this.Acceso_Cliente.Name = "Acceso_Cliente";
            this.Acceso_Cliente.Size = new System.Drawing.Size(166, 49);
            this.Acceso_Cliente.TabIndex = 0;
            this.Acceso_Cliente.Text = "CLIENTE";
            this.Acceso_Cliente.UseVisualStyleBackColor = false;
            this.Acceso_Cliente.Click += new System.EventHandler(this.Acceso_Cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(462, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDENTIFÍCATE";
            // 
            // Acceso_Trabajador
            // 
            this.Acceso_Trabajador.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Acceso_Trabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Acceso_Trabajador.AutoSize = true;
            this.Acceso_Trabajador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Acceso_Trabajador.BackColor = System.Drawing.Color.Transparent;
            this.Acceso_Trabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Acceso_Trabajador.CausesValidation = false;
            this.Acceso_Trabajador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acceso_Trabajador.FlatAppearance.BorderSize = 3;
            this.Acceso_Trabajador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Acceso_Trabajador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Acceso_Trabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceso_Trabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceso_Trabajador.ForeColor = System.Drawing.Color.White;
            this.Acceso_Trabajador.Location = new System.Drawing.Point(457, 306);
            this.Acceso_Trabajador.Name = "Acceso_Trabajador";
            this.Acceso_Trabajador.Size = new System.Drawing.Size(250, 51);
            this.Acceso_Trabajador.TabIndex = 2;
            this.Acceso_Trabajador.Text = "TRABAJADOR";
            this.Acceso_Trabajador.UseVisualStyleBackColor = false;
            this.Acceso_Trabajador.Click += new System.EventHandler(this.Acceso_Trabajador_Click);
            // 
            // Identificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.animal_branch_cute_snow_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.Acceso_Trabajador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Acceso_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Identificate";
            this.Text = "Identificate para acceder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Acceso_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Acceso_Trabajador;
    }
}

