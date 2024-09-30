using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SkyChat.Lib.Modules
{
    internal class DatabaseConnection
    {
        private static string ConnectionString = @"mongodb+srv://Eshansky7:blackheart@skychat.ccqkq.mongodb.net/?retryWrites=true&w=majority&appName=skychat";

        MongoClient client = new MongoClient(ConnectionString);
     
        public BsonDocument GetDataById(string databaseNane, string collectionName, string id)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var result = collection.Find(filter).FirstOrDefault();
            return result;
        }

        public void InsertData(string databaseNane, string collectionName, BsonDocument data)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(data);
        }

        public void UpdateData(string databaseNane, string collectionName, string id, BsonDocument data)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var update = Builders<BsonDocument>.Update.Set("data", data);
            collection.UpdateOne(filter, update);
        }

        public BsonDocument GetLastUpdatedData(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var sort = Builders<BsonDocument>.Sort.Descending("_id");
            var result = collection.Find(new BsonDocument()).Sort(sort).FirstOrDefault();
            return result;
        }

        public bool WaitForChangeCollection(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var options = new ChangeStreamOptions { FullDocument = ChangeStreamFullDocumentOption.UpdateLookup };
            var pipeline = new EmptyPipelineDefinition<ChangeStreamDocument<BsonDocument>>().Match("{ operationType: { $in: [ 'insert', 'update', 'replace' ] } }");
            var cursor = collection.Watch(pipeline, options);
            var enumerator = cursor.ToEnumerable().GetEnumerator();
            while (enumerator.MoveNext())
            {
                return true;
            }
            return false;
        }

        // Get the last updated document from the collection
        public BsonDocument GetLastUpdatedDocument(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var sort = Builders<BsonDocument>.Sort.Descending("_id");
            var result = collection.Find(new BsonDocument()).Sort(sort).FirstOrDefault();
            return result;
        }

        // Check if Collection Exists and return true or false
        public bool CollectionExists(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = new BsonDocument();
            var result = collection.Find(filter).ToList();
            if (result.Count > 0)
            {
                return true;
            }
            return false;
        }

        // Create a new Collection
        public void CreateCollection(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            database.CreateCollection(collectionName);
        }

        // Get all the data from a collection
        public List<BsonDocument> GetAllData(string databaseNane, string collectionName)
        {
            var database = client.GetDatabase(databaseNane);
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = new BsonDocument();
            var result = collection.Find(filter).ToList();
            return result;
        }



    }

}
