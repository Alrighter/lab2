using System;

namespace lab2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.Write("1 - USD\n2 - EUR\n3 - RUB\n\n\nПеревести гривну в: ");
            int answer = Int32.Parse(Console.ReadLine());

            Console.Write("Сколько грн перевести: ");
            converter.hrn = Convert.ToDouble(Console.ReadLine());

            switch (answer){
                case 1:
                converter.usdConverter();
                break;
                case 2:
                converter.eurConverter();
                break;
                case 3:
                converter.rubConverter();
                break;
            }

            Converter toconverter = new Converter();
            Console.Write("1 - USD\n2 - EUR\n3 - RUB\n\n\nКакую валюту перевести: ");
            int answerto = Int32.Parse(Console.ReadLine());

            Console.Write("Перевести валюты: ");
            toconverter.hrn = Convert.ToDouble(Console.ReadLine());

            switch (answer){
                case 1:
                toconverter.usdtouahConverter();
                break;
                case 2:
                toconverter.eurtouahConverter();
                break;
                case 3:
                toconverter.rubtouahConverter();
                break;
            }

        }
    }
}
