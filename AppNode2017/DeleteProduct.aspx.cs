using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//usamos los DLL
using Domain;
using Busines;

namespace AppNode2017
{
    public partial class DeleteProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btborrar_Click(object sender, EventArgs e)
        {
            //se elimina el producto que posee el ID ingresado
            //como en MONGODB los ID son de tipo OBjectId
            //se parsea el dato ingresado
            ProductBusiness.removeProduct(new MongoDB.Bson.ObjectId(TextBox1.Text));

            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = ProductBusiness.getProducts().ToList();
            GridView2.DataBind();

            this.TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = ProductBusiness.getProducts().ToList();
            GridView2.DataBind();
        }
    }
}