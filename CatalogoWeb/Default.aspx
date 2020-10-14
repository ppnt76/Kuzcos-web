<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="font-size: 3.5rem"> Catálogo  </h1>
    <div>
        <h2> Productos</h2>
    </div>
    
    <div class="container">
        
        <div class="row">
            <div class="card-columns">   
                 <%foreach (Dominio.Articulos item in listaCatalogo)
                     {%> 
                       <div class="card text-center"" style="width: 18rem;">
                           <img src="<%=item.Imagen %>" class="card-img-top" alt="..." width="100px"   />
                           <div class="card-body">
                              <h5 class="card-title"><%=item.Nombre %></h5>
                              <h5 class="card-title"><%=item.Precio %></h5>
                               <a class="btn btn-dark" href="...">Detalles</a>
                           </div>
                        </div>
                                                            
                 <% }%>

            </div>
        </div>
   </div>
       
</asp:Content>

