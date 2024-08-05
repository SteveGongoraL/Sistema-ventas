using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Sistema_ventas
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertProducto(string nombre, int precio)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = "INSERT INTO inventarioProducto(nombre_producto, precio_producto) VALUES (@nombre_producto, @precio_producto);";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@nombre_producto", nombre);
                    comando.Parameters.AddWithValue("@precio_producto", precio);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT id_producto, nombre_producto, precio_producto FROM inventarioProducto;";
                try
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                    MySqlDataReader reader = comando.ExecuteReader();
                    dataTable.Load(reader);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar datos: " + ex.Message);
                }
            }
            return dataTable;
        }

    }
}
