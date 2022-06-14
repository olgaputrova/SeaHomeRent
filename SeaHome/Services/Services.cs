using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaHome.Services
{
    public class SingletonService
    {
        public User currentUser; // { get; set; }
        public Apartament currentApartament;
        public MapMark currentMapMark;
                        
        public SingletonService()
        {
            currentUser = new User();
            currentApartament = new Apartament();
            currentMapMark = new MapMark();
            Console.WriteLine(currentUser.Name);
        }
        public void EditPhoneNumber(string phoneNumber)
        {
            currentUser.PhoneNumber = phoneNumber;
            DBMethods.EditUserDB(currentUser);
        }
        public void SetCurrentApartament(Apartament apartament)
        {
            currentApartament = apartament;
        }
        public void SetCurrentMapMark(MapMark mapMark)
        {
            currentMapMark = mapMark;
        }
    }

    public class TransientService
    {
        public Apartament currentApartament;
        public TransientService()
        {
            currentApartament = new Apartament();
        }
    }
}
