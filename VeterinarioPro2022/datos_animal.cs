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
    public partial class datos_animal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable veterinario = new DataTable();
        public datos_animal()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*public static void AddEmployee(
            string lastName,
            string firstName,
            string title,
            DateTime hireDate,
            int reportsTo,
            string photoFilePath,
            string connectionString)
        {
            byte[] photo = GetPhoto(photoFilePath);

            using (SqlConnection connection = new SqlConnection(connectionString))

                SqlCommand command = new SqlCommand("INSERT INTO Employees (LastName, FirstName, " +
                  "Title, HireDate, ReportsTo, Photo) " + "Values(@LastName, @FirstName, @Title, " +
                  "@HireDate, @ReportsTo, @Photo)", connection);

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = lastName;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10).Value = firstName;
            command.Parameters.Add("@Title", SqlDbType.NVarChar, 30).Value = title;
            command.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = hireDate;
            command.Parameters.Add("@ReportsTo", SqlDbType.Int).Value = reportsTo;

            command.Parameters.Add("@Photo", SqlDbType.Image, photo.Length).Value = photo;

            connection.Open();
            command.ExecuteNonQuery();
        }
        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }*/
    }
}