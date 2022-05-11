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
        public Boolean insertaUsuarios(string _chip, string _nombreMascota, string _especieMascota, string _razaMascota, string _DNI)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO animales(id_animales,nombre,raza,especie,dni)  VALUES (@_chip,@_nombreMascota,@_especieMascota,@_razaMascota,@_DNI)", conexion);
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
    }
}