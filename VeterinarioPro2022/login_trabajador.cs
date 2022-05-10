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
    public partial class login_trabajador : Form
    {
        public login_trabajador()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        { //codigo para que al cerrar el form se cierre la aplicacion
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }
    }
}
