using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarioPro2022
{
    public partial class pedir_cita : Form
    {
        public pedir_cita()
        {
            InitializeComponent();
        }
        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio_cliente ventana = new inicio_cliente();
            ventana.Show();
        }
        private void botonAnadir_Click(object sender, EventArgs e)
        {
            if (chipMascota.Text.Length > 0 && nombreMascota.Text.Length > 0 && especieMascota.Text.Length > 0 && razaMascota.Text.Length > 0)
            {

                Boolean resultado = miConexion.insertaUsuarios(chipMascota.Text, nombreMascota.Text, especieMascota.Text, razaMascota.Text, dniDueno.Text);

                if (resultado)
                {
                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    MessageBox.Show("ERROR AL CREAR EL USUARIO");
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
