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
    public partial class login_clientes : Form
    {

        Conexion_Dario conexion = new Conexion_Dario();
        public login_clientes()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {   //codigo para que al cerrar el form se cierre la aplicacion
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //Application.Exit();
            Identificate inicio = new Identificate();
            inicio.Show();
        }

        private void NombreUsuario_Enter(object sender, EventArgs e)
        {   //al entrar al textbox quita la palabra usuario para escribir
            if (NombreUsuario.Text == "DNI")
                NombreUsuario.Text = null;
            NombreUsuario.ForeColor = Color.Black;
        }

        private void NombreUsuario_Leave(object sender, EventArgs e)
        {   // si no ha escrito nada al salir de textbox vuelve a poner Usuario y deja el color en gris
            if (NombreUsuario.Text == "")
                NombreUsuario.Text = "DNI";
            NombreUsuario.ForeColor = Color.Gray;
        }

        private void contraseñaUsuario_Enter(object sender, EventArgs e)
        {   //al entrar al textbox quita la palabra contraseña para escribir
            if (contraseñaUsuario.Text == "Contraseña")
                contraseñaUsuario.Text = null;
            contraseñaUsuario.ForeColor = Color.Black;
            contraseñaUsuario.UseSystemPasswordChar = false;
        }

        private void contraseñaUsuario_Leave(object sender, EventArgs e)  
        {    // si no ha puesto nada al salir pone contraseña y pone seguridad para que no se vea la contraseñas
            if (contraseñaUsuario.Text == "")
                contraseñaUsuario.Text = "Contraseña";
            contraseñaUsuario.ForeColor = Color.Gray;
            contraseñaUsuario.UseSystemPasswordChar = true;
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            if (conexion.login_Cliente(NombreUsuario.Text, contraseñaUsuario.Text))
            {
                this.Hide();
                inicio_cliente pantallaCliente = new inicio_cliente();
                pantallaCliente.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Stresser_contraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio_cliente pantallaCliente = new inicio_cliente();
            pantallaCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro_c registro_cliente = new registro_c();
            registro_cliente.Show();
        }
    }
}
