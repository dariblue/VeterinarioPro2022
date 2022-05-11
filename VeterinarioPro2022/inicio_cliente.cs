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
            oculta_primerapag();
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
       
        private void button9_Click(object sender, EventArgs e)
        {
            button3.Show();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            button9.Hide();
            label11.Show();
            oculta_primerapag();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public void oculta_primerapag()
        {
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
        }
        public void oculta_segundapag()
        {
            button3.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label12.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label12.Show();
            button9.Show();
            oculta_segundapag();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
