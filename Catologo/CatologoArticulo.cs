using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Catologo
{
    public class CatologoArticulo
    {
        public List<Articulos> Listar()
        {
            
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
           
            try 
            {
                datos.Setear("select distinct P.Id, P.Codigo, P.Nombre, P.Descripcion, P.ImagenUrl, P.Precio, D.Id , D.Descripcion, P.IdCategoria from ARTICULOS P  inner join MARCAS D  on D.Id = P.IdMarca order by P.Id asc");
                datos.Consultar();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.idArticulo = datos.lector.GetInt32(0);
                    aux.Codigo = datos.lector.GetString(1);
                    aux.Nombre = datos.lector.GetString(2);
                    aux.Descripcion = datos.lector.GetString(3);
                    aux.idCat = datos.lector.GetInt32(8);

                    aux.Marca = new Marcas();
                    aux.Marca.idMarca = datos.lector.GetInt32(6);
                    aux.Marca.DescripcionMarca = datos.lector.GetString(7);

                    aux.categoria = new Categoria();
                    //aux.categoria.idCategoria = lector.GetInt32(8);//error
                    aux.categoria.DescripcionCategoria = BuscarCategoria(aux.idCat);
                    
                    aux.Precio = datos.lector.GetDecimal(5);
                    aux.Imagen = (string)datos.lector["ImagenUrl"];

                    lista.Add(aux);
                   
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            datos.cerrar();
            return lista;

        }

        public List<Marcas> ListarMarca()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marcas> lista = new List<Marcas>();

            try
            {
                datos.Setear("select Id, Descripcion from MARCAS");
                datos.Consultar();
               
                while (datos.lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarca = datos.lector.GetInt32(0);
                    aux.DescripcionMarca = datos.lector.GetString(1);
                    lista.Add(aux);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            datos.cerrar();
            return lista;
        }

        public List<Categoria> ListarCategoria()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Categoria> lista = new List<Categoria>();

            try
            {
                datos.Setear("select Id, Descripcion from CATEGORIAS");
                datos.Consultar();

                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = datos.lector.GetInt32(0);
                    aux.DescripcionCategoria = datos.lector.GetString(1);
                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            datos.cerrar();
            return lista;
        }

        public void Eliminar(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            try 
            {
                datos.Setear("Delete ARTICULOS WHERE Codigo=@codigo");
                datos.agregar("@codigo", codigo);
                datos.Query();
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

        public void Agregar(Articulos articulos)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Setear("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                //datos.Consultar();
                datos.agregar("@Codigo", articulos.Codigo);
                datos.agregar("@Nombre", articulos.Nombre);
                datos.agregar("@Descripcion", articulos.Descripcion);
                datos.agregar("@IdMarca", articulos.Marca.idMarca);
                datos.agregar("@IdCategoria", articulos.categoria.idCategoria);
                datos.agregar("@ImagenUrl", articulos.Imagen);
                datos.agregar("@Precio", articulos.Precio);

                datos.Query();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
            
        public void Editar(Articulos articulos)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.Consultar();
                datos.Setear("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Codigo=@Codigo ;");
                
                datos.agregar("@Id", articulos.idArticulo);
                datos.agregar("@Codigo",articulos.Codigo);
                datos.agregar("@Nombre", articulos.Nombre);
                datos.agregar("@Descripcion", articulos.Descripcion);
                datos.agregar("@IdMarca", articulos.Marca.idMarca);
                datos.agregar("@IdCategoria", articulos.categoria.idCategoria);
                datos.agregar("@ImagenUrl", articulos.Imagen);
                datos.agregar("@Precio", articulos.Precio);

                datos.Query();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public string BuscarCategoria(int idCat)
        {
            AccesoDatos datos = new AccesoDatos();
            string descripcion = "NULL";
            try
            {
                datos.Setear("select Id, Descripcion from CATEGORIAS");
                datos.Consultar();
               
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = datos.lector.GetInt32(0);
                    aux.DescripcionCategoria = datos.lector.GetString(1);
                    //lista.Add(aux);

                    if(idCat == aux.idCategoria)
                    {
                        descripcion = aux.DescripcionCategoria;
                        datos.cerrar();
                        return descripcion;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            datos.cerrar();
            return descripcion;
        }
        
    }
     

}
