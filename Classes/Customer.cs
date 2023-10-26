using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        // musterinin özelliklerini belirlemek icin propertyler kullanılır.


        public int Id { get; set; }

        // Encapsulation

        //private string _firstName; //field
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mrs." + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value; //value set etmeye calistigimiz degere karsilik gelir.
        //    }

        //}

        public int FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
