using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

using System;

namespace MongoDB_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");
            db.InsertRecord("Users", new PersonModel { FirstName="Ahmed", LastName="Hassan"});
            Console.WriteLine("Hello World!");
        }
    }

    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }

    }

    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
    }

    public class MongoCRUD
    {
        readonly IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);

        }
    }
}
