using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Catologo
{
    public class AccesoDatos 
    {
        private SqlConnection Conexion = new SqlConnection("data source=DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
     
    }
    

}
