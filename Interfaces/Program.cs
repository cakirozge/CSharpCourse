// See https://aka.ms/new-console-template for more information


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            { 
                new SqlServerCustomerDal(), new OracleServerCustomerDal(), new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine(); 
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {

            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ozge",
                LastName = "Cakir",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ayse",
                LastName = "Cakir",
                Department = "Computer Science"
            };
            manager.Add(student);
            //manager.Add(customer);
        }
    }

    interface IPerson // Soyut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
    }

    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } 
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName);

        //}

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);

        }
    }


















}
