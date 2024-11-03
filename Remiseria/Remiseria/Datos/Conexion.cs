using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Remiseria.Datos
{
    class Conexion
    {

        private readonly string bd = "dbremiseria";
        private readonly string servidor = "127.0.0.1";
        private readonly string puerto = "3306";
        private readonly string usuario = "root";
        private readonly string password = "";
        private string cadenaConexion;
        private MySqlConnection conn = null;

    

    public Conexion()
        {
            cadenaConexion= "server="+servidor+";Database="+bd+";Uid="+usuario+";Pwd="+password+";";

        }
        public MySqlConnection crearConexion()
        {
            try
            {
                
                if (conn == null)
                {
                    conn = new MySqlConnection(cadenaConexion);

                }

            }
            catch (Exception error)
            {

                throw;
            }
            return conn;

        }

    }

}
