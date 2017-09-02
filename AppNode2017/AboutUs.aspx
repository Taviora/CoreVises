<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="AppNode2017.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link rel="icon" href="../../../../favicon.ico"/>

    <title>Sobre CoreVises</title>

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
<body>
   <section id="form1" runat="server">
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
         <div class="container">          
          <div class="jumbotron">
              <h2>Sobre CoreVises </h2>
          </div>          
      </div>

       <!---CONTENIDO MEDIO--->
      <div class="container center">
          <div class="row">
              <div class="col-lg-6">
                  
                  <b><p>CoreVises nace como la propuesta de proyecto #1 del curso Informatica Aplicada a los negocios de la carrera Informatica Empresarial.</p></b>
                  <b><p>Universidad de Costa Rica</p></b>
                  <b><p>Recinto de Paraiso</p></b>
                  <b><p>Elaborado por:</p></b>
                  <b><p>  Aaron Araya</p></b>
                 <b><p>Jose Coto</p></b>
                  <b><p>Andres Coto</p></b>
                  <b><p>Koralia Rodriguez</p></b>
                  <b><p>Gustavo Solano</p></b>
                  <b><p>Allan Vazquez</p></b>
              </div>
              <div  class="col-lg-6" >
                  <img class="img-thumbnail" src="img/ucr.png" alt="thumb01" width="300" height="300"/>
                  
              </div>
             

          </div>
      </div>
        <!---CONTENIDO MEDIO--->


         <footer>&copy; CoreVises 2017  .</footer>




     </section>
</body>
</html>
