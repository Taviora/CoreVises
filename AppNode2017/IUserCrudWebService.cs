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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserCrudWebService" in both code and config file together.
    [ServiceContract]
    public interface IUserCrudWebService
    {
        [OperationContract]
        User insertUser(string fullName, string identificationCard, string phone,
                               string address, string email, string password);

        [OperationContract]
        void editUser(User user, string idTx);

        [OperationContract]
        BsonDocument searchById(String id);

        [OperationContract]
        Boolean validateLogin(string email, string password);

        [OperationContract]
        BsonDocument SearchByIdCard(String idCard);

        [OperationContract]
        List<User> getUserByIdCard(string idCard);
    }
}
