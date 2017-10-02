using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;


namespace TechproMiniMart.Models
{
    public class UserModel
    {
        private MongoClient mongoClient;
        private IMongoCollection<User> userCollection;

        public UserModel()
        {
            mongoClient = new MongoClient(ConfigurationManager.AppSettings["mongoDBHost"]);
            var db = mongoClient.GetDatabase(ConfigurationManager.AppSettings["mongoDBName"]);

            userCollection = db.GetCollection<User>("usercollection");

        }

        public List<User> findAll()
        {
            return userCollection.AsQueryable<User>().ToList();
        }
    }
}