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
    public partial class registro_t : Form
    {

        Conexion_Corzo miConexion = new Conexion_Corzo();

        public registro_t()
        {
            InitializeComponent();
        }
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_trabajador ventana = new login_trabajador();
            ventana.Show();
        }
        private void botonAnadir_Click(object sender, EventArgs e)
        {
            String textoDeLaContraseña = contraseñaTrabajador.Text;
            string Hass = BCrypt.Net.BCrypt.HashPassword(textoDeLaContraseña, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(miConexion.insertaTrabajador(dniTrabajador.Text, nombreTrabajador.Text, usuarioTrabajador.Text, Hass));
        }
    }
}
