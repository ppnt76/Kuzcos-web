using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int idArticulo { get; set; }

        public int idCat { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Marcas Marca { get; set; }

        public Categoria categoria { get; set; }

        public decimal Precio { get; set; }

        public string Imagen { get; set; }
    } 

}
