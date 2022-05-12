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
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3307");
        }
        public DataTable getMascotas(String _Chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM animales WHERE chip='" + _Chip + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable veterinario = new DataTable(); //formato que espera el datagridview
                veterinario.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return veterinario;
            }
            catch (MySqlException e)
            {
                conexion.Close();
                throw e;
            }
        }
    }
}