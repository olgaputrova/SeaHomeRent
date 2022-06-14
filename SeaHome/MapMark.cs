using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace SeaHome
{
    public class MapMark 
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        public MapMark(Apartament apartament, string shortText, string latitude, string longitude)
        {
            Apartament = apartament;
            ShortText = shortText;
            Latitude = latitude;
            Longitude = longitude;
            MarkNumber = "z";
        }

        public MapMark()
        {
        }

        private Apartament _apartament;
        private string _shortText;
        private string _markNumber;
        private string _latitude;
        private string _longitude;

        public Apartament Apartament { get => _apartament; set => _apartament = value; }
        public string ShortText { get => _shortText; set => _shortText = value; }
        public string MarkNumber { get => _markNumber; set => _markNumber = value; }
        public string Latitude { get => _latitude; set => _latitude = value; }
        public string Longitude { get => _longitude; set => _longitude = value; }

        
    }
}
