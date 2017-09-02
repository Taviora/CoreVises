using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//uso de las dll
using Domain;
using Busines;


namespace AppNode2017
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Tecnologia");
            DropDownList1.Items.Add("Linea Blanca");
            DropDownList1.Items.Add("Ropa");
            DropDownList1.Items.Add("Libros");
            DropDownList1.Items.Add("Accesorios");
            DropDownList1.Items.Add("Muebles");
        }

        protected void btIngresar_Click(object sender, EventArgs e)
        {
            //se instancia el objeto para obtener sus atributos
            Product product = new Product();

            product.name = TextBox1.Text;
            product.description = TextBox2.Text;
            product.code = Int32.Parse(TextBox3.Text);
            product.category = DropDownList1.Text;
            product.price = Int32.Parse(TextBox4.Text);
            product.inStock = Int32.Parse(TextBox5.Text);
            product.urlImage = TextBox6.Text;
            product.weight = TextBox7.Text;

            ProductBusiness.insertProduct(product);

            this.TextBox1.Text = "";
            this.TextBox2.Text = "";
            this.TextBox3.Text = "";
            this.TextBox4.Text = "";
            this.TextBox5.Text = "";
            this.TextBox6.Text = "";
            this.TextBox7.Text = "";
        }
    }
}