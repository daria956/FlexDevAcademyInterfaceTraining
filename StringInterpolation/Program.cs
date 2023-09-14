// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string memberAcademy = "FlexDev Academy";
//Console.WriteLine($"Witaj {memberAcademy}! Mamy dzisiaj {DateTime.Now}");

string string1 = "A";
string string2 = "B";
string string3 = "B";
string string4 = "B";
string string5 = "B";

String PlusOperator()
{
    //return string1 + string2 + string3 + string4 + string5;
    return $"{string1} {string2} {string3}";
  
}
String StringConcatenate()
{
    return string.Concat(string1, " ", string2, " ", string3);
}
//string StringFormat()
//    return string.Format("{0} {1} {2} [3}", string1, string2, string3, string4);
//}
//string wynik = StringFormat();
//static int LosowaLiczba()
//{
//    return new Random().Next(1, 10);
//}
//Console.WriteLine($"Losowa liczba to {LosowaLiczba()}");
//int Liczba = 6;
//Console.WriteLine($"{Liczba} do kwadratu to {Math.Pow(Liczba, 2)}");

//int cenaKsiazki = 55;Console.WriteLine($"Cena ksiązki to {(cenaKsiazki < 50 ? "50" :"45")} zl.");

//string imie = "Daria";
//int ulubionaLiczba = 7;
//Console.WriteLine($"Hej! Jestem {imie}. Moja ulubiona liczba to {ulubionaLiczba}. Podniesiona do kwadratu {Math.Pow(ulubionaLiczba, 2)}");