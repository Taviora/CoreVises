﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//se agregan als referencias a las DLL
using Domain;
using Busines;


namespace AppNode2017
{
    public partial class InsertUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataSource = UserBusiness.getUsers().ToList();
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = UserBusiness.getUsers().ToList();
            GridView2.DataBind();
        }

        protected void btborrar_Click(object sender, EventArgs e)


        {
            //se llama al metodo y se le manda la cedula que va a ingresar 
            //el usuario para borrarla
            UserBusiness.removeUser(TextBox1.Text);

            //cuando se presione sobre el boton
            //se llenara el Gridview con los datos
            GridView2.DataSource = UserBusiness.getUsers().ToList();
            GridView2.DataBind();

            this.TextBox1.Text = "";
        }
    }
}