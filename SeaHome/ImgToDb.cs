using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaHome
{
    public class ImgToDb
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        private Apartament _apartament;
        public Apartament Apartament { get { return _apartament; } set { _apartament = value; } }
        //public string Name { get; set; }
        public byte[] img;

        public ImgToDb(Apartament apartament, byte[] img)
        {
            Apartament = apartament;
            this.img = img;
        }


        public static void AddToDB(ImgToDb img)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("RandomName");
            collection.InsertOne(img);
        }

    }
}
