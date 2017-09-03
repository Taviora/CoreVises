using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;


//usamos los DLL
using Domain;
using Busines;

namespace AppNode2017
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = ProductBusiness.getProducts().ToList();
            GridView2.DataBind();

        }

        protected void udpate_Click(object sender, EventArgs e)
        {
            //se instancia el objeto user para poder utilizar sus atributos
            Product product = new Product();

            product.name = TextBox2.Text;
            product.description = TextBox3.Text;
            product.code = Int32.Parse(TextBox4.Text);
            product.inStock = Int32.Parse(TextBox5.Text);
            product.weight = TextBox6.Text;
            product.urlImage = TextBox7.Text;

            ProductBusiness.Edit(product, TextBox1.Text);

            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.TextBox7.Text = "";

            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = ProductBusiness.getProducts().ToList();
            GridView2.DataBind();

        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            if(ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))!= null)
            {
                TextBox2.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["name"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["name"].ToString() : string.Empty;
                TextBox3.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["description"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["description"].ToString() : string.Empty;
                TextBox4.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["code"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["code"].ToString() : string.Empty;
                TextBox5.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["inStock"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["inStock"].ToString() : string.Empty;
                TextBox6.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["weight"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["weight"].ToString() : string.Empty;
                TextBox7.Text = ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["urlImage"] != null ?
                    ProductBusiness.SearchByID(ObjectId.Parse(TextBox1.Text))["urlImage"].ToString() : string.Empty;

            }
        }
    }
}