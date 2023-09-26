using ClassIntro;
using System.Linq.Expressions;

Class1 class1 = new Class1();
class1.KursAdi = "C#";
class1.Egitmen = "Ali HAYDAR";
class1.IzlenmeOranı =  68 ;


Class1 class2 = new Class1();
class2.KursAdi = "Java";
class2.Egitmen = "Yunus";
class2.IzlenmeOranı = 312;


Class1 class3 = new Class1();
class3.KursAdi = "Python";
class3.Egitmen = "Berkay";
class3.IzlenmeOranı = 12;


Console.WriteLine(class3.KursAdi);

//Console.WriteLine(class1.KursAdi + " " + class2.KursAdi + " " + class3.KursAdi + " ");

Class1[] classlar = new Class1[] {class1,class2,class3};


foreach(var clas in classlar)
{
    Console.WriteLine(clas.KursAdi);
}

//SwitchCase Yapısı

int dayOfWeek = 3;
string dayName;

switch (dayOfWeek)
{
    case 1:
        dayName = "Pazartesi";
        break;
    case 2:
        dayName = "Salı";
        break;
    case 3:
        dayName = "Çarşamba";
        break;
    case 4:
        dayName = "Perşembe";
        break;
    case 5:
        dayName = "Cuma";
        break;
    case 6:
        dayName = "Cumartesi";
        break;
    case 7:
        dayName = "Pazar";
        break;
    default:
        dayName = "Geçersiz Gün";
        break;
}

Console.WriteLine($"Bugün {dayName}");


//Ternary operatörünün genel yapısı şu şekildedir



int number = -5;
string result = (number > 0) ? "Pozitif" : "Negatif";
Console.WriteLine(result); // Bu, "Negatif" yazdıracaktır.


// WHİLE

int sayi = 1;

while (sayi <= 5)
{
    Console.WriteLine(sayi);
    sayi++;
}