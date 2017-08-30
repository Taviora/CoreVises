using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//se agregan las referencias a las DLL creadas
using Domain;
using Busines;


namespace AppNode2017
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btIngresar_Click(object sender, EventArgs e)
        {
            //se toman los valores ingresados en el formulario de Login
            string email = TextBox1.Text;
            string pass = TextBox2.Text;

            //se instancia el Business para poder utilizar sus metodos
            if (UserBusiness.validateLogin(email, pass) == true)
            {
                Response.Redirect("Principal.aspx");
                Label3.Text = "";
            }
            else {
                Label3.Text="Login Fallido";
            }
        }
    }
}