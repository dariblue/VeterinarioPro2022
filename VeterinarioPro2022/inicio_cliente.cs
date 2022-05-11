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
    public partial class inicio_cliente : Form
    {
        public inicio_cliente()
        {
            InitializeComponent();
        }

        private void inicio_cliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            datos_animal da = new datos_animal();
            da.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedir_cita pc = new pedir_cita();
            pc.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
