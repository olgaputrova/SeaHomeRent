using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaHome.Services
{
    public class SingletonService
    {
        public User currentUser; // { get; set; }
        //public int Value { get; set; }

        //public void Inc(ref int increment)
        //{
        //    increment++;
        //    Value = increment;

        //}
        
        public SingletonService()
        {
            currentUser = new User();
            Console.WriteLine(currentUser.Name);
        }
    }
}
