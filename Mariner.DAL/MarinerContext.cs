
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using Mariner.DOMAIN.GaiaDAL;

namespace Mariner.DAL
{
    public class MarinerContext
    {        
        public const string CONNECTION_STRING = "mongodb://gaiadev:mariner2017@107.170.80.68:27017/gaia";
        public const string DATABASE_NAME = "gaia";
        public const string IMAGES_COLLECTION_NAME = "Images";
        public const string USERS_COLLECTION_NAME = "users";
        

        // This is ok... Normally, they would be put into
        // an IoC container.
        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MarinerContext()
        {           
            _client = new MongoClient(CONNECTION_STRING);
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoClient Client {
            get { return _client; }
        }

        public IMongoDatabase Database {
            get { return _database; }
        }

        public IMongoCollection<Image> Images {
            get { return _database.GetCollection<Image>(IMAGES_COLLECTION_NAME); }
        }

        //public IMongoCollection<User> Users {
        //    get { return _database.GetCollection<User>(USERS_COLLECTION_NAME); }
        //}
    }
}

