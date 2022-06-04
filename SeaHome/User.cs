using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace SeaHome
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        public User(string login, string name, string password, string phoneNumber)
        {
            Login = login;
            Name = name;
            Password = password;
            PhoneNumber = phoneNumber;
        }
        
        public User ()
        {

        }
        
        private string _login;
        private string _name;
        private string _password;
        private string _phoneNumber;
        private bool _isOwner;

        public string Login { get => _login; set => _login = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public bool IsOwner { get => _isOwner; set => _isOwner = value; }

        
    }
}
