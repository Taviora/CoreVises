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
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = ProductBusiness.getProducts().ToList();
            GridView2.DataBind();
        }
    }
}