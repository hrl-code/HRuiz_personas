using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRuiz_Personas.HRuiz_Modelo;
using System.Windows.Forms;
using MySqlConnector;

namespace HRuiz_Personas.HRuiz_Conexion
{
    internal class HRuiz_Conexion
    {
        private static readonly string url = "Server=145.14.151.1;" +
            "Database=u812167471_datospersona;" +
            "User ID=u812167471_datospersona;" +
            "Port=3306;" +
            "Password=Datospersona-2024;" +
            "Convert Zero Datetime=True;";

        public static bool HRuiz_RegistrarPersonas(HRuiz_Persona p)
        {
            string consulta = "INSERT INTO datos (dni, nombre, apellidos, direccion, ciudad) VALUES (?dni, ?nombre, ?apellidos, ?direccion, ?ciudad)";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", p.HRuiz_DNI);
                comando.Parameters.AddWithValue("?nombre", p.HRuiz_nombre);
                comando.Parameters.AddWithValue("?apellidos", p.HRuiz_apellidos);
                comando.Parameters.AddWithValue("?direccion", p.HRuiz_direccion);
                comando.Parameters.AddWithValue("?ciudad", p.HRuiz_ciudad);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static HRuiz_Persona HRuiz_RescatarDatos(string HRuiz_dni)
        {
            string consulta = "SELECT * FROM datos WHERE dni=?dni";
            MySqlConnection conn = new MySqlConnection(url);
            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", HRuiz_dni);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string HRuiz_nombre = HRuiz_Encriptar.HRuiz_Desencriptar(reader["nombre"].ToString());
                    string HRuiz_apellidos = HRuiz_Encriptar.HRuiz_Desencriptar(reader["apellidos"].ToString());
                    string HRuiz_direccion = HRuiz_Encriptar.HRuiz_Desencriptar(reader["direccion"].ToString());
                    string HRuiz_ciudad = HRuiz_Encriptar.HRuiz_Desencriptar(reader["ciudad"].ToString());
                    return new HRuiz_Persona(HRuiz_nombre, HRuiz_apellidos, HRuiz_direccion, HRuiz_ciudad);
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public static bool HRuiz_existeDNI(string dni)
        {
            string consulta = "SELECT * FROM datos WHERE dni=?dni";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conn);
                comando.Parameters.AddWithValue("?dni", dni);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }





    }
}
