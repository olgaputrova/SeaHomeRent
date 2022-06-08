using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace SeaHome
{
    public class DBMethods
    {
        public static void AddImgToDB(ImgToDb img)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");
            collection.InsertOne(img);
        }

        public static void AddUserToDB(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static User Authorization(string login, string password)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<User>("Users");

            var item = collection.Find(x => x.Login == login && x.Password == password).FirstOrDefault();
            // Передаем в метод троки их тега input и если найдено соответсвие по 2м параметрам, метод вернет объект, в противном случае вернет null.
            return item;
        }

        public static void AddApartamentToDB(Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<Apartament>("Apartaments");
            collection.InsertOne(apartament);
        }

        public static void EditApartamentDB(Apartament currentApartament, Apartament newApartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<Apartament>("Apartaments");
            collection.ReplaceOne(x => x._id == currentApartament._id, newApartament);

        }

        public static void DeleteApartamentDB (Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<Apartament>("Apartaments");
            collection.DeleteOne (x => x._id == apartament._id);
        }

        public static void RemoveImagesFromDB (Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");
            collection.DeleteMany(x => x.Apartament._id == apartament._id);
        }

        //public static List<String> ShowApartaments(User user)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("SeaHome");
        //    var collection = database.GetCollection<Apartament>("Apartaments");
        //    var list = new List<String>();
        //    foreach (var item in collection)
        //    {
        //        if(item.User._id == user._id)
        //        {
        //            list.Add(item.Text);
        //        }
        //    }
        //    return list;
        //    //return collection.Find(x => x.User._id == user._id).ToList();
        //}
    }    
        
}
