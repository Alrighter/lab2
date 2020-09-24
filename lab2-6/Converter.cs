using System;

namespace lab2_6
{
    public class Converter
    {
        private double usd = 28.0003f;
        private double eur = 33.2476f;
        private double rub = 0.3710f;

        public double hrn;

        public void usdConverter(){
            Console.WriteLine($"UAH: {this.hrn * this.usd}");
        }
        public void eurConverter(){
            Console.WriteLine($"UAH: {this.hrn * this.eur}");
        }
        public void rubConverter(){
            Console.WriteLine($"UAH: {this.hrn * this.rub}");
        }

        public void usdtouahConverter(){
            Console.WriteLine($"UAH: {this.hrn / this.usd}");
        }
        public void eurtouahConverter(){
            Console.WriteLine($"UAH: {this.hrn / this.eur}");
        }
        public void rubtouahConverter(){
            Console.WriteLine($"UAH: {this.hrn / this.rub}");
        }
    }
}