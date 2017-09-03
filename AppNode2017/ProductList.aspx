<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="AppNode2017.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link rel="icon" href="../../../../favicon.ico"/>

    <title>Listado de Productos</title>

    <!-- Bootstrap core CSS -->
    
    <link href="Content/bootstrap-theme.css" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.css.map" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.min.css.map" rel="stylesheet"/>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <link href="Content/bootstrap.css.map" rel="stylesheet"/>
    <link href="Content/CSS.css" rel="stylesheet"/>
   
    <link href="Content/bootstrap.min.css.map" rel="stylesheet"/>
    <script src="scripts/jquery-1.9.1.min.js"></script>   
    <script src="scripts/bootstrap.js"></script>
    <script src="scripts/jquery-1.9.1.js"></script>
    <script src="scripts/jquery-1.9.1.intellisense.js"></script>

    <!-- Custom styles for this template -->
    <link href="starter-template.css" rel="stylesheet"/>

   
</head>
<body> 
<section id="Section1" runat="server">
     <div class="container">
         <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
             <div class="container">
                 <div class="navbar-header">
                     <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                          <span class="sr-only">Toggle navigation</span>
                          <span class="icon-bar"></span>
                         <span class="icon-bar"></span>
                         <span class="icon-bar"></span>
                     </button>
                     <a class="navbar-brand" ><span><img alt="Logo" src="img/corevises.png" height="30"/>  </span>CoreVises</a>
                 </div>
                  <div class="navbar-collapse collapse">
                     <ul class="nav navbar-nav navbar-right">
                         <li ><a href="StartPage.aspx">Home</a></li>
                         <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Usuarios<b class="caret"></b></a>
                              <ul class="dropdown-menu">
                                  <li class="dropdown-header">Gestiones</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="DeleteUser.aspx">Eliminar</a></li>                                 
                              </ul>
                         </li>
                          <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Productos<b class="caret"></b></a>
                              <ul id="1" class="dropdown-menu">
                                  <li class="dropdown-header">Gestiones</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="InsertProduct.aspx">Ingresar</a></li>
                                  <li><a href="DeletePproduct.aspx">Eliminar</a></li>
                                  <li><a href="UpdateProduct.aspx">Actualizar</a></li>                                 
                              </ul>
                         </li>
                          <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Reportes<b class="caret"></b></a>
                              <ul class="dropdown-menu">
                                  <li class="dropdown-header">Generar por:</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="ProductList.aspx">Producto</a></li>
                                  <li><a href="UserList.aspx">Clientes</a></li>
                              </ul>
                         </li> 
                          <li class="active"><a href="Login.aspx">Salir</a></li>                     
                     </ul>
                 </div>
             </div>
         </div>     
     </div>
      <br />
      <br />
        <div class="container center">          
          <div class="jumbotron center">
              <h2>Listado de productos en el sistema </h2>
          </div>          
      </div>
     
        <!--Parte listado productos--->
      <br />
      
         <div class="container center">
          <form role="form " runat="server" class="center" >
                          <asp:GridView ID="GridView2" runat="server" Width="900px" HorizontalAlign="center"
                              AutoGenerateColumns="false" PageSize="5" AllowPaging="false" CssClass="table table-bordered bs-table">
                              <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="OrangeRed" />
                              <EditRowStyle BackColor="#ffffcc" />
                              <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />

                              <Columns>
                                  <asp:BoundField DataField="_id" HeaderText="ID" HtmlEncode="true" />                                 
                                  <asp:BoundField DataField="name" HeaderText="Nombre" HtmlEncode="true" />
                                  <asp:BoundField DataField="description" HeaderText="Descripcion" HtmlEncode="true" />
                                  <asp:BoundField DataField="code" HeaderText="Codigo" HtmlEncode="true" />
                                  <asp:BoundField DataField="inStock" HeaderText="Cantidad en Bodega" HtmlEncode="true" />
                                  <asp:BoundField DataField="weight" HeaderText="Peso" HtmlEncode="true" />

                              </Columns>
                          </asp:GridView>
                           
                    <asp:Button ID="btdoPDF" runat="server" Text="Generar reporte PDF" CssClass="btn btn-warning" OnClick="doPdf_Click" />

              </form>
                           </div>
               



    <br />
    <br />
    

    <footer>&copy; CoreVises 2017  .</footer>
    </section>

</body>
</html>