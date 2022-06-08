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
                
        public SingletonService()
        {
            currentUser = new User();
            currentApartament = new Apartament();
            Console.WriteLine(currentUser.Name);
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
