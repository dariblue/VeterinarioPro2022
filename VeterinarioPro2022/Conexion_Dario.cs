using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BCrypt;

namespace VeterinarioPro2022
{
    class Conexion_Dario
    {
        public MySqlConnection conexion;

        public Conexion_Dario()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = VeterinarioPro; Pwd =liSenDrinCle; Port = 3306");
        }

        public Boolean login_Cliente(String dni, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM clientes where dni = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);


                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string LaContraseña = resultado.GetString("contraseña");
                    if( BCrypt.Net.BCrypt.Verify(contraseña, LaContraseña))
                    {
                        return true;
                    }
                }
                
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }



        public Boolean login_trabajadores(String dni, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM trabajadores where dni_trabajador = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);


                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string LaContraseña = resultado.GetString("contraseña");
                    if (BCrypt.Net.BCrypt.Verify(contraseña, LaContraseña))
                    {
                        return true;
                    }
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }


        public String crea_Cliente(String dni, String nombre, String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO clientes (dni, nombre, usuario, contraseña) VALUES (@dni, @nombre, @usuario, @contraseña)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok bb";
            }
            catch
            {
                return ("webo");
            }
        }

    }
}