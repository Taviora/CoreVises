using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//se agregan las referencias a los drivers de MongoDB
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Bson.IO;


//se agregan las referencias a la DLL del Domain
using Domain;


namespace Data
{
     public class UserData
    {
        public static Boolean validateLogin(string email, string password)
        {
            //ruta del servidor y puerto
            MongoClient mongoClient = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //Se obtiene el servidor
            MongoServer mongoServer = mongoClient.GetServer();

            //Se busca y obtenemos la BD que se pasa por parametro
            MongoDatabase dataBase = mongoServer.GetDatabase("aplicada2017");

            //Se obtiene la coleccion en la que vamos a almacenar el objeto
            MongoCollection usersCollection = dataBase.GetCollection<User>("users");

            //foreach que traera todos los usuarios e ira comparando para ver si existen
            //los datos ingresados en el Login
            //return true si el usuario ingerso los datos bien
            //return false si los ingreso mal
            foreach (User getUser in usersCollection.FindAllAs<User>())
            {
                if (getUser.email.Equals(email) && getUser.password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }//validateLogin

        //constructor vacio
        public UserData()
        {
        }

        public static User insertUser(User user)
        {
            //se crea la conexion con el servidor donde se hospeda la BD Mongo
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establace la base de datos
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //obtenemos la coleccion user
            var collection = database.GetCollection<BsonDocument>("users");

            //se crea el documento ha insertar
            BsonDocument doc = user.ToBsonDocument();

            //se inserta el documento en la coleccion
            collection.InsertOne(doc);

            //se retorna el usuario
            return user;
        }//insertUser

        public static void removeUser(String idCard)
        {
            //se crea la conexion con el servidor donde se hospeda la BD Mongo
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establace la base de datos
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            var collection = database.GetCollection<BsonDocument>("users");

            //condicion where del delete
            //se usa el id como condicionante
            var filter = Builders<BsonDocument>.Filter.Eq("identificationCard", idCard);

            //se borra el documento
            collection.DeleteOne(filter);
        }//removeUser


        public static void Edit(User user, string idTx)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //recupera los usuarios de la coleccion 
            var collection = database.GetCollection<BsonDocument>("users");

            //crea un filtro para borrar solo el usuario con el id especificado
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(idTx));

            //ingreso el id original para que no lo edite 
            user._id = ObjectId.Parse(idTx);

            //se crea el documento a insertar a partir de la clase
            BsonDocument doc = user.ToBsonDocument();

            //eliminamos el usuario
            collection.ReplaceOne(filter, doc);

        }




        public static List<User> getUsers()
        {
            //ruta del servidor y puerto
            MongoClient mongoClient = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //Se obtiene el servidor
            MongoServer mongoServer = mongoClient.GetServer();

            //Se busca y obtenemos la BD que se pasa por parametro
            MongoDatabase dataBase = mongoServer.GetDatabase("aplicada2017");

            //Se obtiene la coleccion en la que vamos a almacenar el objeto
            MongoCollection usersCollection = dataBase.GetCollection<User>("users");

            //se crea una lista que almacera todos los usuarios 
            //para, posteriormente, mostrarlos en interfaz
            List<User> list = new List<User>();

            //foreach que llenara la lista de users
            foreach (User getUser in usersCollection.FindAllAs<User>())
            {
                list.Add(getUser);
            }

            return list;
        }//getUsers



        public static BsonDocument SearchByIdCard(String idCard)
        {
            //se establece la cadena de conexion del servidor que vamos a utilizar
            MongoClient client = new MongoClient("mongodb://gustavosj:gustavosj@ds149373.mlab.com:49373/aplicada2017");

            //se establece la base de datos donde se realizaran las conexiones
            IMongoDatabase database = client.GetDatabase("aplicada2017");

            //se declara la coleccion de la BD
            var collection = database.GetCollection<BsonDocument>("users");

            //hace una comparacion con filtro por id
            var filter = Builders<BsonDocument>.Filter.Eq("identificationCard", idCard);


            var result = collection.Find(filter).FirstOrDefault();

            return result;
        }

    }
}
