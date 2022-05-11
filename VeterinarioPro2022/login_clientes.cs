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
            if (NombreUsuario.Text == "Usuario")
                NombreUsuario.Text = null;
            NombreUsuario.ForeColor = Color.Black;
        }

        private void NombreUsuario_Leave(object sender, EventArgs e)
        {   // si no ha escrito nada al salir de textbox vuelve a poner Usuario y deja el color en gris
            if (NombreUsuario.Text == "")
                NombreUsuario.Text = "Usuario";
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
    }
}
