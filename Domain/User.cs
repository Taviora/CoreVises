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
     public class User
    {
        //se crean los atributos del objeto
        //en el formato ideal para enviarlos mediante JSON
        //BSON para MongoDB
        public ObjectId _id { get; set; }
        public string identificationCard { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public string password { get; set; }

        //constructor vacio
        public User() { }

        //constructor sobrecargado
        public User(ObjectId id, string identificationCard, string email,
                    string address, string fullName, string phone, string password)
        {
            this._id = id;
            this.identificationCard = identificationCard;
            this.email = email;
            this.address = address;
            this.fullName = fullName;
            this.phone = phone;
            this.password = password;
        }
    }
}
