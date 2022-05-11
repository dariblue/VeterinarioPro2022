using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VeterinarioPro2022
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = VeterinarioPro; Pwd =liSenDrinCle; Port = 3306");
        }

        public String login_Cliente(String dni, String contraseña)
        {
            try
            {
                conecion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("Select * FROM usuario where dni = '" + dni + "' ADN contraseña = '" + contraseña + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetString(0);
                }

                conexion.Close();
                return "Error usuario/contraseña";
            }
            catch (MySqlException e)
            {
                return "Erroro";
            }
        }
    }
}