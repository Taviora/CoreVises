<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppNode2017.Login" %>

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
                        
                          <li class="active"><a href="AboutUs.aspx">Acerca de nosotros</a></li>                     
                     </ul>
                 </div>
             </div>
         </div>     
     </div>
     
        <!--Login Form --->
      <br />
      <br />  
      <div class="container">          
          <div class="jumbotron">
              <h2>Sistema gerencial de CoreVises </h2>
          </div>          
      </div>
          <br /> 
         
        <div class="container center">
            <div class="row">
                <div class="col-md-6">
                    
                        <div class="panel-heading">
                            <h3 class="panel-title">
                                Ingresar al sistema de CoreVises
                            </h3>
                        </div>
                        <div class="panel-body">
                            <form role="form" runat="server">
                                <div class="form-group">
                                    <label>Email</label>
                                 <asp:TextBox ID="TextBox1" autocomplete="off" CssClass="form-control" runat="server"></asp:TextBox>
                                   
                                </div>
                                <div class="form-group">
                                    <label>Contraseña</label>
                                     <asp:TextBox ID="TextBox2" CssClass="form-control" type="password" runat="server"></asp:TextBox>
                                 
                                </div>
                                <div class="form-group">
                                       <asp:Button ID="btIngresar" runat="server" Text="Ingresar" CssClass="btn btn-warning" OnClick="btIngresar_Click"/>
                                 
                                </div>
                                <div class="form-group">
                                    <div class="col-md-6">
                                    <b><asp:Label ID="Label3" runat="server" CssClass="col-md-6 control-label text-danger" Text=""></asp:Label></b>
                                    </div>
                                </div>
                            </form>
                        </div>

                   

                </div>
                <div class="col-md-6">
                    <div class="">
                   <img src="img/tree.png" style="float:inherit" class="img-thumbnail" alt="Cinque Terre" width="300" height="350" />
                    </div>
               
                </div>

            </div>

        </div>



         <footer>&copy; CoreVises 2017  .</footer>




     </section>





</body>
</html>
