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