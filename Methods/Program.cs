// See https://aka.ms/new-console-template for more information

//Add();
//Add();
//Add();

//var result = Add2(20);

//int number1 = 20;
//int number2 = 100;

//var result2 = Add3(ref number1, number2);


//Console.WriteLine(result2);
//Console.WriteLine(number1); // ref eklenmeden önce 20 olur çünkü bu durum değer veri tipleri ile ilgilidir. --* Ref ile number1 = 30 yazdırır.--*
//Console.ReadLine();

//static void Add()
//{
//    Console.WriteLine("Added !!!");
//}

//---**       parametreli methodlarla çalışmak    ---**

//static int Add2(int number1, int number2)
//{
//    var result = number1 + number2;
//    return result;
//}

//---**      default parametreli metotlarla calısmak..    --**
//static int Add2(int number1=20, int number2=30) // default parametre konulduğunda her zaman en son değer için atanmalıdır.
//{
//    var result = number1 + number2;
//    return result;
//}

//---** Challenge : Ref Keyword ile çalışmak

// --** Ref Keyword : Değer tiplerini referans tip gibi kullanmamızı sağlar 
//static int Add3( ref int number1, int number2)
//{
//    number1 = 30;
//    return number1 + number2;
//}


//---* Out Keyword : Ref ile gösterdiği tüm özellikler aynıdır set etmeye gerek yoktur.

//int x ;
//int y = 300;

//var resultAdd4 = Add4(out x,y);


//Console.WriteLine(resultAdd4);
//Console.WriteLine(x); // ref eklenmeden önce 20 olur çünkü bu durum değer veri tipleri ile ilgilidir. --* Ref ile number1 = 30 yazdırır.--*
//Console.ReadLine();

//static int Add4(out int x, int y)
//{
//    x = 45;
//    return x + y;
//}

// ---**            Method overloading         ---**


 
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 10));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        // params keyword ile çalışmak
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}


  



