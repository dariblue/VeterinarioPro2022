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
    class Conexion_Corzo
    {
        public MySqlConnection conexion;

        public Conexion_Corzo()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
        }
        public String insertaTrabajador(string dni, string nombre, string usuario, string contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO trabajadores(dni_trabajador,nombre,usuario,contraseña)  VALUES (@dni,@nombre,@usuario,@contraseña)", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);

                consulta.ExecuteNonQuery(); //guardo el insert
                conexion.Close();
                return "Usuario agregado correctamente";
            }
            catch
            {
                return "Error";
            }

        }
        public Boolean insertaMascotas(string _chip, string _nombreMascota, string _especieMascota, string _razaMascota, string _DNI)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO animales(chip,nombre,raza,especie,dni)  VALUES (@_chip,@_nombreMascota,@_especieMascota,@_razaMascota,@_DNI)", conexion);
                consulta.Parameters.AddWithValue("@_chip", _chip);
                consulta.Parameters.AddWithValue("@_nombreMascota", _nombreMascota);
                consulta.Parameters.AddWithValue("@_especieMascota", _especieMascota);
                consulta.Parameters.AddWithValue("@_razaMascota", _razaMascota);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);

                int resultado = consulta.ExecuteNonQuery(); //guardo el insert

                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aqui es porque si que esta bien el usuario y la contraseña
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        public Boolean insertaCitas(string _Chip, string _motivoCita)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO citas (Chip,motivo)  VALUES (@_Chip,@_motivoCita)", conexion);
                consulta.Parameters.AddWithValue("@_Chip", _Chip);
                consulta.Parameters.AddWithValue("@_motivoCita", _motivoCita);


                int resultado = consulta.ExecuteNonQuery(); //guardo el insert

                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aqui es porque si que esta bien el usuario y la contraseña
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
    }
}