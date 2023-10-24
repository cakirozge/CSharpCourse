// See https://aka.ms/new-console-template for more information

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[] {"Engin", "Derin", "Salih"};
            ////students[0] = "Engin";
            ////students[1] = "Derin";
            ////students[2] = "Ahmet";
        

            //string[] students2 = { "Özge", "Ömer", "Emre"};
           


            //foreach(var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine();
            //Console.ReadLine();

            //    -------* ÇOK BOYUTLU DİZİ OLUŞTURMA *-------

            string[,] regions = new string[7, 3] //7 satır 3 kolon demektir.
            {
                {"İstanbul","Bursa","Balıkesir" },
                {"Ankara","Eskişehir","Konya" },
                { "İzmir","Aydın","Muğla"},
                {"Gaziantep","Mardin","Diyarbakır" },
                {"Giresun","Samsun","Artvin" },
                {"Erzurum","Kars","Ağrı" },
                {"Antalya","Mersin","Adana" },
            };
            // satırları alabilmek için ---- en üst değerini yakalama: GetUpperBound ile yapılır. 
            for (int i =0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j= 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**************************");
            }

            Console.WriteLine();
            Console.ReadLine();



        }



    }
}

