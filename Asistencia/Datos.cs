using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace Asistencia
{

    internal class Datos
    {
            //Generar cadena de conexión
            string cadenaConexión = "server=localhost;user=luis;pwd=joseluis;DataBase=asistencia;port=3307";
            MySqlConnection conexion;

            private void Conectar()
            {
                try
                {
                    conexion = new MySqlConnection(cadenaConexión);
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private void Desconectar()
            {
                try
                {
                    if (conexion != null)
                    {
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        public DataSet ejecutar(string comando)
        {
            DataSet ds = new DataSet();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexión))
                {
                    conexion.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion))
                    {
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ds;
        }

        public bool ejecutarComando(string comando)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexión))
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand(comando, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
