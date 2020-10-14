using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Catologo;
using Dominio;

namespace CatalogoWeb
{
    public partial class _Default : Page
    {
        public List<Articulos> listaCatalogo { get; set; } 
        protected void Page_Load(object sender, EventArgs e)
        {
            CatologoArticulo productos = new CatologoArticulo();
            listaCatalogo = productos.Listar(); 
            

           
            
        }
    }
}