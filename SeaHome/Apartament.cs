using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;



namespace SeaHome
{
    public class Apartament
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        public Apartament(User user, string text, int floor, int houseFloor, double price)
        {
            User = user;
            Text = text;
            Floor = floor;
            HouseFloor = houseFloor;
            Price = price;
        }

        public Apartament()
        {
        }

        private User _user;
        private string _text;
        private int _floor;
        private int _houseFloor;
        private double _price;
       
        public User User { get => _user; set => _user = value; }
        public string Text { get => _text; set => _text = value; }
        public int Floor { get => _floor; set => _floor = value; }
        public int HouseFloor { get => _houseFloor; set => _houseFloor = value; }
        public double Price { get => _price; set => _price = value; }
        
    }
}
