using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//se agregan las referencias a las DLL
using Domain;
using Data;

namespace AppNode2017
{
    /// <summary>
    /// Summary description for WebServiceProduct
    /// </summary>
    [WebService(Namespace = "http://192.168.43.98:80/WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceProduct : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Product> getProducts()
        {
            return ProductData.getProducts();
        }

        [WebMethod]
        public List<Product> getProductsByCategory(string category)
        {
            return ProductData.getProductsByCategory(category);
        }
    }
}
