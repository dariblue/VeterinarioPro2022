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

        private void nombreUsuario_Enter(object sender, EventArgs e)
        {   //al entrar al textbox quita la palabra usuario para escribir
            if (nombreUsuario.Text == "Usuario")
                nombreUsuario.Text = null;
            nombreUsuario.ForeColor = Color.Black;
        }

        private void nombreUsuario_Leave(object sender, EventArgs e)
        {   // si no ha escrito nada al salir de textbox vuelve a poner Usuario y deja el color en gris
            if (nombreUsuario.Text == "")
                nombreUsuario.Text = "Usuario";
            nombreUsuario.ForeColor = Color.Gray;
        }

        private void contraseñaUsuario_Enter(object sender, EventArgs e)
        {   //al entrar al textbox quita la palabra contraseña para escribir
            if (contraseñaUsuario.Text == "Contraseña")
                contraseñaUsuario.Text = null;
            contraseñaUsuario.ForeColor = Color.Black;
            contraseñaUsuario.UseSystemPasswordChar = false;
        }

        private void contraseñaUsuario_Leave(object sender, EventArgs e)
        {   // si no ha puesto nada al salir pone contraseña y pone seguridad para que no se vea la contraseñas
            if (contraseñaUsuario.Text == "")
                contraseñaUsuario.Text = "Contraseña";
            contraseñaUsuario.ForeColor = Color.Gray;
            contraseñaUsuario.UseSystemPasswordChar = true;
        }
    }
}
