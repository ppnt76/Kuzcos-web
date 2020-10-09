using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Catologo
{
    public class CatologoArticulo
    {
        private AccesoDatos conexion = new AccesoDatos();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Listar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select distinct P.Id, P.Codigo, P.Nombre, D.Descripcion as Marca, P.Descripcion, P.Precio from ARTICULOS P inner join MARCAS D  on D.Id = P.IdMarca order by P.Id asc";
              leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.AbrirConexion();
            return tabla;
        }
        public DataTable ListarMarca()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText= "select Id, Descripcion from MARCAS";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.AbrirConexion();
            return tabla;
        }
        public DataTable ListarCategoria()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Id, Descripcion from CATEGORIAS";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.AbrirConexion();
            return tabla;
        }

        public void Agregar(Articulos articulos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
            comando.ExecuteNonQuery();
        }


    }
     

}
