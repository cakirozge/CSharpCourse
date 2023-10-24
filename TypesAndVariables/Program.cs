// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.ReadLine();

bool condition = false; // şart bloklarında kullanılır .

// Tam sayı 
int number1 = 2147483647;
long number2 = 9223372036854775807; // long kapsar int .
short number3 = 32767;
byte number4 = 255;
char character = 'A';

//Ondalıklı sayı
double number5 = 15.8;
decimal number6 = 15.8M;

string days = "Sunday";

var number7 = 10;
number7 = 'A';



Console.WriteLine("Number1 is {0}",number1); // {0} "," den sonraki ilk değeri almak için kullanıldı.
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Character is : {0}", (int)character);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.ReadLine();

enum Days
{
    Monday, Tuesday,Wednesday,Friday,Saturday, Sunday
}

