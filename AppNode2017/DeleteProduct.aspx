<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="AppNode2017.DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link rel="icon" href="../../../../favicon.ico"/>

    <title>Eliminar Producto</title>

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
                         <li ><a href="Usuarios">Home</a></li>
                         <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Usuarios<b class="caret"></b></a>
                              <ul class="dropdown-menu">
                                  <li class="dropdown-header">Gestiones</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="DeleteUser.aspx">Eliminar</a></li>
                                  <li><a href="ViewUsers.aspx">Listar</a></li>
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
                                  <li><a href="ProductList.aspx">Listar</a></li>
                              </ul>
                         </li>
                          <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Reportes<b class="caret"></b></a>
                              <ul class="dropdown-menu">
                                  <li class="dropdown-header">Generar por:</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="#">Producto</a></li>
                                  <li><a href="#">Clientes</a></li>
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
              <h2>Eliminar producto de la base de datos </h2>
          </div>          
      </div>
     
        <!--Parte eliminar usuario--->
      <br />
      
         <div class="container center">
          <div class="row">


              <div class="container center">
                  <form role="form" runat="server">
                      <div class="col-lg-4">
                          <div class="panel-heading">
                              <h3 class="panel-title">Ingresar ID de producto
                              </h3>
                            
                          </div>
                            <br />
                          <div class="form-group">
                              <label>ID</label>
                              <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <asp:Button ID="btborrar" runat="server" Text="Borrar" CssClass="btn btn-warning" OnClick="btborrar_Click" />
                              <br />
                              <br />
                              <br />
                              <asp:Button ID="Button2" runat="server" Text="Ver listado productos" CssClass="btn btn-warning" OnClick="Button1_Click" />

                          </div>
                      </div>

                      <div class="col-lg-8" style="clear:right; height:300px;" >
                          <div style="width:700px;height:290px;overflow:auto">
                          <asp:GridView ID="GridView2" runat="server" Width="700px"
                              AutoGenerateColumns="false" PageSize="5" AllowPaging="false" CssClass="table table-bordered bs-table">
                              <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                              <EditRowStyle BackColor="#ffffcc" />
                              <EmptyDataRowStyle ForeColor="Red" CssClass="table table-bordered" />

                              <Columns>
                                  <asp:BoundField DataField="_id" HeaderText="ID" HtmlEncode="true" />                                 
                                  <asp:BoundField DataField="name" HeaderText="Nombre" HtmlEncode="true" />
                                  <asp:BoundField DataField="description" HeaderText="Descripcion" HtmlEncode="true" />

                              </Columns>
                          </asp:GridView>
                           </div>
                      </div>
                  </form>
              </div>
              <div>
              </div>


          </div>

         </div>

    <!--Parte eliminar usuario--->

    <br />
    <br />
    

    <footer>&copy; CoreVises 2017  .</footer>
    </section>

</body>
</html>