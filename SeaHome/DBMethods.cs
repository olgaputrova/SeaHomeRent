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
            var collection = database.GetCollection<ImgToDb>(img.Apartament._id.ToString());
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
    }
}
