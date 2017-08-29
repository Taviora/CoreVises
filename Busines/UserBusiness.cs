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
    public class UserBusiness
    {
        //constructor vacio
        public UserBusiness() { }

        public static Boolean validateLogin(string email, string password)
        {
            return UserData.validateLogin( email, password);
        }

        public static User insertUser(User user)
        {
            return UserData.insertUser(user);
        }//insertUser

        public static void removeUser(String id)
        {
            UserData.removeUser(id);
        }

        public static void Edit(User user, string idTx)
        {
            UserData.Edit(user, idTx);
        }

        public static List<User> getUsers()
        {
            return UserData.getUsers();
        }


        public static BsonDocument SearchByIdCard(String idCard)
        {
            return UserData.SearchByIdCard(idCard);
        }
}
