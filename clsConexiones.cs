using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// -----------------------------
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
// -----------------------------

namespace wsrvcOlimpiada
{
    public class clsConexiones
    {
        private string cadConn = ConfigurationManager.
                                 ConnectionStrings["bdOlimpiada"].
                                 ConnectionString.ToString();

        public DataSet vw_Complejo() {
            // Clases de conexión y ejecución de comandos
            string cadSql = "select * from vw_Complejo;";
            MySqlConnection cnn = new MySqlConnection(cadConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cadSql, cnn);
            // Ejecución del adaptador y recibir datos
            DataSet ds = new DataSet();
            da.Fill(ds, "vw_Complejo");
            // Retorno de resultados
            return ds;
        }
        public DataSet vw_ComplejoFiltro(string filtro)
        {
            // Clases de conexión y ejecución de comandos
            string cadSql =  "select * from vw_Complejo ";
            cadSql += "where  nombre like '%" + filtro + "%' ";
            cadSql += "or     localizacion like '%" + filtro + "%' ";
            cadSql += "or     `jefe organizacional` like '%" + filtro + "%' ";
            MySqlConnection cnn = new MySqlConnection(cadConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cadSql, cnn);
            // Ejecución del adaptador y recibir datos
            DataSet ds = new DataSet();
            da.Fill(ds, "vw_ComplejoFiltro");
            // Retorno de resultados
            return ds;
        }
        public DataSet vw_Sede()
        {
            // Clases de conexión y ejecución de comandos
            string cadSql = "select * from vw_Sede;";
            MySqlConnection cnn = new MySqlConnection(cadConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cadSql, cnn);
            // Ejecución del adaptador y recibir datos
            DataSet ds = new DataSet();
            da.Fill(ds, "vw_Sede");
            // Retorno de resultados
            return ds;
        }
        public DataSet sp_ControlAcceso(string usuario, 
                                        string contrasena)
        {
            // Clases de conexión y ejecución de comandos
            string cadSql = "call sp_ControlAcceso('" + usuario + "', '" 
                                                      + contrasena + "')";
            MySqlConnection cnn = new MySqlConnection(cadConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cadSql, cnn);
            // Ejecución del adaptador y recibir datos
            DataSet ds = new DataSet();
            da.Fill(ds, "sp_ControlAcceso");
            // Retorno de resultados
            return ds;
        }
        // ------------------------------------------------------------
        public DataSet sp_InsComplejo(  string nombre,
                                        string localizacion,
                                        string jefe,
                                        string area,
                                        string sede )
        {
            // Clases de conexión y ejecución de comandos
            string cadSql = "call sp_InsComplejo('" + nombre + "','"
                                                    + localizacion + "','"
                                                    + jefe + "',"
                                                    + area + ","
                                                    + sede + ")";

            MySqlConnection cnn = new MySqlConnection(cadConn);
            MySqlDataAdapter da = new MySqlDataAdapter(cadSql, cnn);
            // Ejecución del adaptador y recibir datos
            DataSet ds = new DataSet();
            da.Fill(ds, "sp_InsComplejo");
            // Retorno de resultados
            return ds;
        }





    }
}