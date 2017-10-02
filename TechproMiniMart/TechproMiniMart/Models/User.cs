using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 


namespace TechproMiniMart.Models
{
    public class User
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement()]
        public string fname { get; set; }
        [BsonElement()]
        public string lname { get; set; }
        [BsonElement()]
        public string phonenumber { get; set; }

    }
}