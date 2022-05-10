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
    public partial class Identificate : Form
    {
        public Identificate()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {   //codigo para que al cerrar el form se cierre la aplicacion
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void Acceso_Cliente_Click(object sender, EventArgs e)
        {   //acceder a la pantalla de inicio de sesion de los clientes
            this.Hide();
            login_clientes login_clientes = new login_clientes();
            login_clientes.Show();
        }

        private void Acceso_Trabajador_Click(object sender, EventArgs e)
        {   //acceder a la pantalla de inicio de sesion del trabajador
            this.Hide();
            login_trabajador login_trabajador = new login_trabajador();
            login_trabajador.Show();
        }
    }
}
