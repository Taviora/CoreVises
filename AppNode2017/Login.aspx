<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppNode2017.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link rel="icon" href="../../../../favicon.ico"/>

    <title>Starter Template for Bootstrap</title>

    <!-- Bootstrap core CSS -->
    
    <link href="Content/bootstrap-theme.css" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.css.map" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet"/>
    <link href="Content/bootstrap-theme.min.css.map" rel="stylesheet"/>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <link href="Content/bootstrap.css.map" rel="stylesheet"/>
    <link href="Content/Style.css" rel="stylesheet"/>
   
    <link href="Content/bootstrap.min.css.map" rel="stylesheet"/>
    <script src="scripts/jquery-1.9.1.min.js"></script>   
    <script src="scripts/bootstrap.js"></script>
    <script src="scripts/jquery-1.9.1.js"></script>
    <script src="scripts/jquery-1.9.1.intellisense.js"></script>

    <!-- Custom styles for this template -->
    <link href="starter-template.css" rel="stylesheet"/>

   
</head>
<body  >
    <form id="form1" runat="server">
     <div>
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
                              <ul class="dropdown-menu">
                                  <li class="dropdown-header">Gestiones</li>
                                  <li role="separator" class="divider"></li>
                                  <li><a href="#">Ingresar</a></li>
                                  <li><a href="#">Eliminar</a></li>
                                  <li><a href="#">Actualizar</a></li>
                                  <li><a href="#">Listar</a></li>
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
                          <li class="active"><a href="Usuarios">Salir</a></li>                     
                     </ul>
                 </div>
             </div>
         </div>     
     </div>
        
        <!--Login Form --->
        <div class="container">
             <img src="img/corevises.jpg" style="float:right" class="img-rounded" alt="Cinque Terre" width="250" height="236"/>

            <div class="form-horizontal" >
                <h2>Ingreso a procesos gerenciales</h2>
                <hr />               
               
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Correo:"></asp:Label>
                    <div class="col-md-3"> 
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                 <div class="form-group">
                    <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Contraseña:"></asp:Label>
                    <div class="col-md-3"> 
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>            
                 </div>
                
                 <div class="form-group"> 
                     <div class="col-md-2"></div>                 
                    <div class="col-md-6"> 
                        <asp:Button ID="btIngresar" runat="server" Text="Ingresar" CssClass="btn btn-warning" OnClick="btIngresar_Click"/>
                    </div>

                </div>
                 <div class="form-group">                    
                    <div class="col-md-3"> 
                        <asp:Label ID="Label3" runat="server" CssClass="col-md-2 control-label" Text=""></asp:Label>
                    </div>            
                 </div>
            </div>

          
        </div>

        <!--Login form --->
          <!----FOOOTER---->
         <footer class="footer-pos">
            <div class="container">
                <p class="pull-right">&copy;2017 CoreVises &middot; </p>

            </div>
        </footer>
        

         <!----FOOOTER---->
    </form>
      
  
   
</body>
</html>
