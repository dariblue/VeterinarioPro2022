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
        Conexion_Corzo miConexion = new Conexion_Corzo();

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
            if (chipMascota.Text.Length > 0 && motivoCita.Text.Length > 0)
            {

                Boolean resultado = miConexion.insertaCitas(chipMascota.Text, motivoCita.Text);

                if (resultado)
                {
                    MessageBox.Show("Cita creada");
                }
                else
                {
                    MessageBox.Show("ERROR AL CREAR LA CITA");
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
