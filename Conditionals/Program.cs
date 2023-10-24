// See https://aka.ms/new-console-template for more information


var number = 95;
//if (number == 10)
//{
//    Console.WriteLine("Number is 10.");
//}
//else if(number == 20)
//{
//    Console.WriteLine("Number is 20.");
//}
//else
//{
//    Console.WriteLine("Number is not 10.");
//}

//switch (number)
//{
//    case 10:
//        Console.WriteLine("Number is 10");
//        break;
//    case 20:
//        Console.WriteLine("Number is 20");
//        break;
//    default:
//        Console.WriteLine("Number is not 10 or 20.");
//        break;
//}

// Bir sayının 100lük birimlerde nereye geldiğini bulan uygulama

//if (number >= 0 && number <= 100) 
//{
//    Console.WriteLine("Number is between 0-100");
//}
//else if (number >100 && number <= 200 )
//{
//    Console.WriteLine("Number is between 101-200");
//}
//else if (number > 200 || number <0)
//{
//    Console.WriteLine("Number is less than 0 or greater than 200.");
//}

if (number < 100 )
{
    if (number >= 90 && number <95)
    {
        Console.WriteLine("Sayı 100den küçük if bloguna girdi 90 ve üstü için değerlendirme alındı.");
    }
    else
    {
        Console.WriteLine("Sayı aranılan aralık içinde değil.");
    }
}        

Console.ReadLine();