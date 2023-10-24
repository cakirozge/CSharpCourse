// See https://aka.ms/new-console-template for more information



using System.Runtime.CompilerServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (isPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }else
            {
                Console.WriteLine("This is not a prime number.");
            }
            Console.ReadLine();


            //    ---- for dongüsü anlatımı -----

            //for ( int i= 100; i>= 0; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished !!!");



            // ----------- ForLoop() ----------

            //int number = 100;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);
            //Console.ReadLine();

        }

        // --- ForEach Döngüsü --- veritabanında data cekmek için kullanılır.
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

        }


        // -------------------------------------------------------------------------
        //private static void ForLoop()
        //{
        //    for (int i = 100; i >= 0; i = i - 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("Finished !");
        //}

        //----------------------------------------------------------------------------

        // ********** ASAL SAYI UYGULAMASI *************

        private static bool isPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }


    }
}
