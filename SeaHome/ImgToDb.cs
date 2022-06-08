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
        public string Name { get; set; }
        //public byte[] img;

        public ImgToDb(Apartament apartament, string name)
        {
            Apartament = apartament;
            //this.img = img;
            Name = name;
        }


        //public static void AddToDB(ImgToDb img)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("SeaHome");
        //    var collection = database.GetCollection<ImgToDb>("Images");
        //    collection.InsertOne(img);
        //}

    }
}
