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
            if (collection.Find(x => x.Login == user.Login) != null)
            {
                collection.FindOneAndReplace(x => x.Login == user.Login, user);
            }
            else { collection.InsertOne(user); }
        }
        public static void EditUserDB(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x._id == user._id, user);
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

        public static void DeleteUserDB(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<User>("Users");
            collection.DeleteOne(x => x.Login == user.Login);
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
        public static void DeleteManyApartamentsDB(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<Apartament>("Apartaments");
            collection.DeleteMany(x => x.User._id == user._id);
        }
        public static void RemoveImagesFromDB (Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");
            collection.DeleteMany(x => x.Apartament._id == apartament._id);
        }
        public static void DeleteOneImageDB(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");
            collection.DeleteOne(x => x.Name == name);
        }
        public static void AddMapMarkToDB(MapMark mapMark)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<MapMark>("MapMarks");
            if (collection.Find(x => x.Apartament._id == mapMark.Apartament._id) != null)
            {
                collection.FindOneAndReplace(x => x.Apartament._id == mapMark.Apartament._id, mapMark);
            }
            else { collection.InsertOne(mapMark); }
        }

        public static void RemoveMapMarkFromDB(Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");
            collection.DeleteOne(x => x.Apartament._id == apartament._id);
        }

        public static List<MapMark> GetMapMarksFromDB()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<MapMark>("MapMarks");

            List<MapMark> listOfMapMarks = collection.Find(x => true).ToList();
            return listOfMapMarks;
        }
        public static MapMark GetSingleMapMarkDB(Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<MapMark>("MapMarks");
            var item = collection.Find(x => x.Apartament._id == apartament._id).FirstOrDefault();
            return item;
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
