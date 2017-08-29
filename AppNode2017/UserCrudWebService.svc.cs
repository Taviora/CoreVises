using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//se agregan las referencias a las DLL creadas
using Domain;
using Data;

//se agregan las referencias a Mongo
using MongoDB.Bson;
using MongoDB.Driver;

namespace AppNode2017
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserCrudWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserCrudWebService.svc or UserCrudWebService.svc.cs at the Solution Explorer and start debugging.
    public class UserCrudWebService : IUserCrudWebService
    {
        public void editUser(User user, string idTx)
        {
            UserData.Edit(user, idTx);
        }

        public List<User> getUserByIdCard(string idCard)
        {
            return UserData.getUserByIdCard(idCard);
        }

        public User insertUser(string fullName, string identificationCard, string phone,
                               string address, string email, string password)
        {
            User user = new User();

            user.fullName = fullName;
            user.identificationCard = identificationCard;
            user.phone = phone;
            user.address = address;
            user.email = email;
            user.password = password;

            return UserData.insertUser(user);
        }

        public BsonDocument searchById(string id)
        {
            return UserData.SearchByIdCard(id);
        }

        public BsonDocument SearchByIdCard(string idCard)
        {
            return UserData.SearchByIdCard(idCard);
        }

        public bool validateLogin(string email, string password)
        {
            return UserData.validateLogin(email, password);
        }
    }
}
