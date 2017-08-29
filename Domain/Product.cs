using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//se agregan las referencias a MongoDb
using MongoDB.Bson;
using MongoDB.Driver;

namespace Domain
{
    public class Product
    {


        //se crean los atributos del objeto
        //en el formato ideal para enviarlos mediante JSON
        //BSON para MongoDB
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int code { get; set; }
        public string category { get; set; }
        public float price { get; set; }
        public int inStock { get; set; }
        public string weight { get; set; }
        public string urlImage { get; set; }

        //constructor vacio
        public Product()
        {
        }

        //constructor sobrecargado
        public Product(ObjectId id, string name, string description,
                        int code, string category, float price, int inStock, string weight,
                        string url)
        {
            this._id = id;
            this.name = name;
            this.description = description;
            this.code = code;
            this.category = category;
            this.price = price;
            this.inStock = inStock;
            this.urlImage = url;
            this.weight = weight;
        }
    }
}
