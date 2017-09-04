using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//se agregan los DLL creados
using Domain;
using Data;

//se agregan las referencias a Mongo
using MongoDB.Bson;

namespace AppNode2017
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://192.168.43.98:80/WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<User> getUsers()
        {
            return UserData.getUsers();
        }

        [WebMethod]
        public void editUser(string identificationCard, string email, string address,
                             string fullName, string phone, string password, string idtx)
        {
            User user = new User();

            user.identificationCard = identificationCard;
            user.email = email;
            user.address = address;
            user.fullName = fullName;
            user.phone = phone;
            user.password = password;

            UserData.Edit(user, idtx);
        }

        [WebMethod]
        public User insertUser(string identificationCard, string email, string address, 
                               string fullName, string phone, string password)
        {
            User newUser = new User();

            var encryptPass = UserData.EncryptPass(password);

            newUser.identificationCard = identificationCard;
            newUser.email = email;
            newUser.address = address;
            newUser.fullName = fullName;
            newUser.phone = phone;
            newUser.password = encryptPass;

            return UserData.insertUser(newUser);
        }

        [WebMethod]
        public void removeUser(string identificationCard)
        {
            UserData.removeUser(identificationCard);
        }

        [WebMethod]
        public Boolean validateLogin(string email, string password)
        {
            var encryptPass = UserData.EncryptPass(password);

            return UserData.validateLogin(email, encryptPass);
        }
    }
}
