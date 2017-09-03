<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="AppNode2017.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link rel="icon" href="../../../../favicon.ico"/>

    <title> Login</title>

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
  
   
   
</head>
<body  >
     <section  runat="server">
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
                                  <li><a href="UserList.aspx">Listar</a></li>
                              </ul>
                         </li>
                          <li class="dropdown">
                             <a href="#" class="dropdown-toggle" data-toggle="dropdown">Productos<b class="caret"></b></a>
                              <ul id="1" class="dropdown-menu">
                                  <li class="dropdown-header">Gestiones</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="InsertProduct.aspx">Ingresar</a></li>
                                  <li><a href="DeleteProduct.aspx">Eliminar</a></li>
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
     
        <!--Insert Product Form --->
      <br />
      <br />  
      <div class="container">          
          <div class="jumbotron">
              <h2>Ingresar nuevo producto</h2>
          </div>          
      </div>
          <br /> 
         
        <div class="container center">
            <div class="row">
                <div class="col-md-6">
                    
                        <div class="panel-heading">
                            <h3 class="panel-title">
                                Ingresar informacion de producto
                            </h3>
                        </div>
                        <div class="panel-body">
                            <form role="form" runat="server">
                                <div class="form-group">
                                    <label>Nombre</label>
                                 <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                                   
                                </div>
                                <div class="form-group">
                                    <label>Descripción</label>
                                     <asp:TextBox ID="TextBox2" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                    <label>Codigo</label>
                                     <asp:TextBox ID="TextBox3" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                    <label>Categoria</label>                                    
                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label>Precio</label>
                                     <asp:TextBox ID="TextBox4" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                    <label>Cantidad en bodega</label>
                                     <asp:TextBox ID="TextBox5" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                    <label>Url Imagen</label>
                                     <asp:TextBox ID="TextBox6" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                    <label>Peso</label>
                                     <asp:TextBox ID="TextBox7" CssClass="form-control"  runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                       <asp:Button ID="btIngresar" runat="server" Text="Ingresar" CssClass="btn btn-warning" OnClick="btIngresar_Click"/>
                                 
                                </div>
                               
                            </form>
                        </div>

                   

                </div>
                <div class="col-md-6">
                    <div class="">
                   <img src="img/e-comer.png" style="float:inherit" class="img-thumbnail" alt="Cinque Terre" width="300" height="350" />
                    </div>
               
                </div>

            </div>

        </div>



         <footer>&copy; CoreVises 2017  .</footer>




     </section>





</body>
</html>

