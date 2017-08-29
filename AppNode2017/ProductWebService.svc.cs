using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


//se agregan las referencias a las DLL creadas
using Domain;
using Data;

//se agregan las referencias a MongoDB
using MongoDB.Bson;
using MongoDB.Driver;

namespace AppNode2017
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductWebService.svc or ProductWebService.svc.cs at the Solution Explorer and start debugging.
    public class ProductWebService : IProductWebService
    {
        public List<Product> getProducts()
        {
            return ProductData.getProducts();
        }

        public List<Product> getProductsByCategory(string category)
        {
            return ProductData.getProductsByCategory(category);
        }

        public BsonDocument SearchByCode(int code)
        {
            return ProductData.SearchByCode(code);
        }
    }
}
