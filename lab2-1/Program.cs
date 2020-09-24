using System;

namespace Нова_папка__2_
{
    public class adress{
        
        public string index {get;set;}
        public string country {get;set;}
        public string city {get;set;}
        public string street {get;set;}
        public string house {get;set;}
        public string apartment {get;set;}

        public void showAdress(){
            Console.WriteLine($"Index: {index} \nCountry: {country} \nCity: {city}\nStreet: {street}\nHouse: {house}\nApartment: {apartment}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Выделяю память
            adress myAdress = new adress();
            //Вписываю значения
            myAdress.index = "45002";
            myAdress.country = "Ukraine";
            myAdress.city = "Kovel";
            myAdress.street = "Hlinky";
            myAdress.house = "13";
            myAdress.apartment = "1";
            //Вывожу на экран
            myAdress.showAdress();
            
            

            
            
        }

    }
}
