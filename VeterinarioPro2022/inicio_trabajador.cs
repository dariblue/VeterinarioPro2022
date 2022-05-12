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
    public partial class inicio_trabajador : Form
    {
        Conexion miConexion = new Conexion();
        DataTable datosmascota = new DataTable();
        public inicio_trabajador()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos_animal da = new datos_animal();
            da.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pedir_cita pc = new pedir_cita();
            pc.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inicio_cliente ic = new inicio_cliente();
            ic.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            datosmascota = miConexion.getMascotas(getChip.Text);
            dataGridView1.DataSource = datosmascota;
        }

        private void getChip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
