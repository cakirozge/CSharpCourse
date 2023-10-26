// See https://aka.ms/new-console-template for more information

namespace Classes
{

    //classlar yapmak istediğimiz işlemleri gruplara ayırmamıza olanak verir.
    // bu grup üzerinden işlemlerimizi yaparız ulaşım sağlayabiliriz.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // kullanmak için bir örnek olusturduk.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Istanbul";
            customer.FirstName = "Ozge"; // bir classın propertysini esitlediğimde ---set--- blogu calısır.
            customer.LastName = "Cakir";

            Customer customer2 = new Customer()
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Ayse",
                LastName = "Cakir",
            };

            Console.WriteLine(customer2.FirstName); // --- get --- blogu calısır çünkü bunu al demek istemektedir.

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated.");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added.");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated.");
        }
    }
}