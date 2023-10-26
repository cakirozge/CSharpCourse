// See https://aka.ms/new-console-template for more information


namespace Inheritance // Kalıtım 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirstName = "Test";    

            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Test"}, new Student{FirstName="Test"}, new Person{FirstName="Test" } 
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();

        }


        // * classların tek basına bir anlamı vardır.
        // * interfacelerin tek başına bir anlamı yoktur.

        // ------------------ nasıl Interface ve Inheritance kullanımına karar verilir ?  ----------------------
        //* interface inheritance gibi kullanılabilir bu gibi projelerde tercih edilebilir. zorunluluk yoksa interface kullan.
        //* abstract classlar da inheritance kullanılabilir. 
        class Person
        {
            public int Id { get; set; } 
            public string FirstName { get; set; }
            public string LastName { get; set; }
          
        }

        

        class Customer:Person
        {
          public string City { get; set; }  
        }

        class Student : Person
        {
            public string Department { get; set; }  
        }
    }
}
