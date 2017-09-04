using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//se agregan las referencias a los drivers de MongoDB
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver.GridFS;

//se agregan las referencias a la DLL del Domain
using Domain;


namespace Data
{
   public class ProductData
    {
        //constructor vacio
        public ProductData()
        {
        }

        public static Product insertProduct(Product product)
        {
            //se crea la conexion con el servidor donde se hospeda la BD Mongo
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establace la base de datos
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //obtenemos la coleccion user
            var collection = database.GetCollection<BsonDocument>("products");

            //se crea el documento ha insertar
            BsonDocument doc = product.ToBsonDocument();

            //se valida que un producto no sea ingresado si ya ese codigo existe
            if (validateCode(product.code)==true) {
                //se inserta el documento en la coleccion
                collection.InsertOne(doc);
            }
            //se retorna el product
            return product;
        }//insertProduct

        public static void removeProduct(ObjectId id)
        {
            //se crea la conexion con el servidor donde se hospeda la BD Mongo
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establace la base de datos
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            var collection = database.GetCollection<BsonDocument>("products");

            //condicion where del delete
            //se usa el id como condicionante
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

            //se borra el documento
            collection.DeleteOne(filter);
        }//removeUser


        public static void Edit(Product product, string idTx)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //recupera los usuarios de la coleccion 
            var collection = database.GetCollection<BsonDocument>("products");

            //crea un filtro para borrar solo el usuario con el id especificado
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(idTx));

            //ingreso el id original para que no lo edite 
            product._id = ObjectId.Parse(idTx);

            //se crea el documento a insertar a partir de la clase
            BsonDocument doc = product.ToBsonDocument();

            //eliminamos el producto
            collection.ReplaceOne(filter, doc);

        }

        public static List<Product> getProducts()
        {
            //ruta del servidor y puerto
            MongoClient mongoClient = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //Se obtiene el servidor
            MongoServer mongoServer = mongoClient.GetServer();

            //Se busca y obtenemos la BD que se pasa por parametro
            MongoDatabase dataBase = mongoServer.GetDatabase("aplicada2017");

            //Se obtiene la coleccion en la que vamos a almacenar el objeto
            MongoCollection productsCollection = dataBase.GetCollection<Product>("products");

            //se crea una lista que almacera todos los productos
            //para, posteriormente, mostrarlos en interfaz
            List<Product> list = new List<Product>();

            //foreach que llenara la lista de productos
            foreach (Product getProduct in productsCollection.FindAllAs<Product>())
            {
                list.Add(getProduct);
            }

            return list;
        }//getUsers

        public static BsonDocument SearchById(ObjectId id)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //se declara la coleccion de la BD
            var collection = database.GetCollection<BsonDocument>("products");

            //hace una comparacion con filtro por id
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);


            var result = collection.Find(filter).FirstOrDefault();

            return result;
        }//retorna un objeto BSONdocument con el producto


        public static List<Product> getProductsByCategory(string category)
        {
            //ruta del servidor y puerto
            MongoClient mongoClient = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //Se obtiene el servidor
            MongoServer mongoServer = mongoClient.GetServer();

            //Se busca y obtenemos la BD que se pasa por parametro
            MongoDatabase dataBase = mongoServer.GetDatabase("aplicada2017");

            //Se obtiene la coleccion en la que vamos a almacenar el objeto
            MongoCollection productsCollection = dataBase.GetCollection<Product>("products");

            //se crea una lista que almacera todos los productos
            //para, posteriormente, mostrarlos en interfaz
            List<Product> list = new List<Product>();

            //foreach que llenara la lista con lso productos que unicamente 
            //estan dentro de la categoria ingresada
            foreach (Product getProduct in productsCollection.FindAllAs<Product>())
            {
                if (getProduct.category.Equals(category))
                {
                    list.Add(getProduct);
                    return list;
                }
            }

            return list;
        }//getProdcutsByCategory


        public static BsonDocument SearchByCode(int code)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //se declara la coleccion de la BD
            var collection = database.GetCollection<BsonDocument>("products");

            //hace una comparacion con filtro por id
            var filter = Builders<BsonDocument>.Filter.Eq("code", code);

            var result = collection.Find(filter).FirstOrDefault();

            return result;
        }//retorna un objeto BSONdocument con el producto


        public static BsonDocument SearchByID(ObjectId id)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //se declara la coleccion de la BD
            var collection = database.GetCollection<BsonDocument>("products");

            //hace una comparacion con filtro por id
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

            var result = collection.Find(filter).FirstOrDefault();

            return result;
        }//retorna un objeto BSONdocument con el producto

        //metodo encargado de validar que no se puedan registrar dos productos con el mismo 
        //codigo
        public static Boolean validateCode(int code) {
            MongoClient mongoClient = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //Se obtiene el servidor
            MongoServer mongoServer = mongoClient.GetServer();

            //Se busca y obtenemos la BD que se pasa por parametro
            MongoDatabase dataBase = mongoServer.GetDatabase("aplicada2017");

            //Se obtiene la coleccion en la que vamos a almacenar el objeto
            MongoCollection productsCollection = dataBase.GetCollection<Product>("products");

            //se crea una lista que almacera todos los productos
            //para, posteriormente, mostrarlos en interfaz
            List<Product> list = new List<Product>();

            //foreach que recorre todos los productos, obtiene los codigos de todos
            //y compara con el nuevo codigo. Si hay otro igual, retorna false, o sea,
            //no se puede ingresar.
            //Si retorna true, si puede ser ingresado
            foreach (Product getProduct in productsCollection.FindAllAs<Product>())
            {
                if (getProduct.code==code) {
                    return false;
                }
            }
            return true;
        }//validateCode
    }
}
