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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductWebService" in both code and config file together.
    [ServiceContract]
    public interface IProductWebService
    {
        [OperationContract]
        List<Product> getProductsByCategory(string category);

        [OperationContract]
        List<Product> getProducts();

        [OperationContract]
        BsonDocument SearchByCode(int code);
    }
}
