using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;

//se agregan las referencias a las DLL
using Domain;
using Data;

namespace Busines
{
    public class ProductBusiness
    {
        //constructor vacio
        public ProductBusiness() { }

        public static Product insertProduct(Product product)
        {
            return ProductData.insertProduct(product);
        }

        public static void removeProduct(ObjectId id)
        {
            ProductData.removeProduct(id);
        }

        public static void Edit(Product product, string idTx)
        {
            ProductData.Edit(product, idTx);
        }

        public static List<Product> getProducts()
        {
            return ProductData.getProducts();
        }

        public static List<Product> getProductsByCategory(string category)
        {
            return ProductData.getProductsByCategory(category);
        }
        public static BsonDocument SearchByID(ObjectId id)
        {
            return ProductData.SearchById(id);
        }
    }
}