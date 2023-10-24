// See https://aka.ms/new-console-template for more information

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Ozge Cakir";


            // Length; Kaç karakterden oluştugunu verir.
           
            var result = sentence.Length;

            // Clone: BİR TANE DAHA DEGİSKEN OLUSTURURUZ.

            var result2 = sentence.Clone();


            // EndsWith bitiyor mu? diye sorar sonucu true false döndürür.

            bool result3 = sentence.EndsWith("r");

            // StarsWith başlıyor mu diye sorgu yapar.

            bool result4 = sentence.StartsWith("M");

            //IndexOf bir string de belirli bir ifadeyi veya karakteri aramak için kulanılır.

            var result5 = sentence.IndexOf("Ozge");
            var result6 = sentence.IndexOf(" ");

            //LastIndexOf aramaya sondan baslar.
            var result7 = sentence.LastIndexOf(" ");

            // Insert bir ifadeye onun basına bir seyler yerlestırmek ıcın kulanılır.

            var result8 = sentence.Insert(0, "Hello, ");

            // Substring metni parçalamak için kullanılır.

            // --var result9 = sentence.Substring(3,4);

            // ToLower tüm karakterleri küçük harfe çevirir.

            var result10 = sentence.ToLower();

            // ToUpper tüm karakterleri büyük harfe dönüştürür.

            var result11 = sentence.ToUpper();

            //Replace belirli karakterleri değiştirmek için kullanılır.

            var result12 = sentence.Replace(" ", "-");

            //remove belirli bir index sonrasında bakamka içiin kullanılır.


            var result13 = sentence.Remove(2);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            //Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara"; // string char arraydir.
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = " İstanbul";
            //string result = city + city2;

            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
        
    }
}