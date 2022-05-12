using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;

namespace VeterinarioPro2022
{
    public partial class registro_c : Form
    {
        Conexion_Dario conexion = new Conexion_Dario();
        public registro_c()
        {
            InitializeComponent();
        }

        private void creaUsuario_Click(object sender, EventArgs e)
        {
            String textoDeLaContraseña = text_contraseña.Text;
            string Hass = BCrypt.Net.BCrypt.HashPassword(textoDeLaContraseña, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.crea_Cliente(text_dni.Text, text_nombre.Text, text_usuario.Text, Hass));
        }

        private void b_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
