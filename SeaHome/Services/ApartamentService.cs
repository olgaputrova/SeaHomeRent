using Microsoft.AspNetCore.Components;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaHome.Services
{
    public class ApartamentService
    {
        //public User currentUser;
        public ApartamentService()
        {
            //currentUser = new User();
        }

        public List<Apartament> apartaments { get; set; }
        public List<Apartament> GetApartaments(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<Apartament>("Apartaments");
            
            List<Apartament> listOfApartaments = collection.Find(x => x.User == user).ToList();          
            return listOfApartaments;
        }

        public List<ImgToDb> GetImages(Apartament apartament)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SeaHome");
            var collection = database.GetCollection<ImgToDb>("Images");

            List<ImgToDb> listOfImages = collection.Find(x => x.Apartament == apartament).ToList();
            return listOfImages;
        }

    }
}
