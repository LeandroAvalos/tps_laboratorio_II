using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GestionDeArchivosSQL
    {
        /// <summary>
        /// Metodo para traer la informacion contenida en una base de datos
        /// </summary>
        /// <returns>Retorna una lista de sucursales tomada de la base de datos</returns>
        public static List<Sucursales> Leer_SQL()
        {
            List<Sucursales> sucursales = new List<Sucursales>();
            try
            {
                string query = "select * from Sucursales";
                using (SqlConnection connection = new SqlConnection("Server=.;Database=Sucursales;Trusted_Connection=True;"))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string barrio = reader.GetString(0);
                        double numeroTelefonico = (double)reader.GetDecimal(1);
                        string direccionParticular = reader.GetString(2);
                        string codigoDeSecursal = reader.GetString(3);
                        string abiertoDe = reader.GetString(4);
                        string abiertoHasta = reader.GetString(5);
                        string apertura = reader.GetString(6);
                        string cierre = reader.GetString(7);
                        Sucursales sucursal = new Sucursales(barrio, numeroTelefonico, direccionParticular, codigoDeSecursal, abiertoDe, abiertoHasta, apertura, cierre);
                        sucursales.Add(sucursal);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return sucursales;
        }

        /// <summary>
        /// Metodo para agregar una sucursar a la base de datos.
        /// </summary>
        /// <param name="sucursal">Sucursal que sera agregada a la base de datos</param>
        public static void Guardar_SQL(this Sucursales sucursal)
        {
            string query = "insert into Sucursales (barrio, numeroTelefonico, direccionParticular, codigoDeSecursal, abiertoDe, abiertoHasta, apertura, cierre) " +
                "values (@barrio, @numeroTelefonico, @direccionParticular, @codigoDeSecursal, @abiertoDe, @abiertoHasta, @apertura, @cierre)";
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection("Server=.;Database=Sucursales;Trusted_Connection=True;");
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("barrio", sucursal.Barrio);
                cmd.Parameters.AddWithValue("numeroTelefonico", sucursal.NumeroTelefonico);
                cmd.Parameters.AddWithValue("direccionParticular", sucursal.DireccionParticular);
                cmd.Parameters.AddWithValue("codigoDeSecursal", sucursal.CodigoDeSucursal);
                cmd.Parameters.AddWithValue("abiertoDe", sucursal.AbiertoDe);
                cmd.Parameters.AddWithValue("abiertoHasta", sucursal.AbiertoHasta);
                cmd.Parameters.AddWithValue("apertura", sucursal.Apertura);
                cmd.Parameters.AddWithValue("cierre", sucursal.Cierre);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
