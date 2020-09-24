using System;

namespace lab2_2
{
        public class Rectangle{
        public double side1, side2;

        public Rectangle(double side1, double side2){
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(){
            double a = this.side1 * this.side2;
            return a;
        }
        public double PerCalc(){
            double a = (this.side1 + this.side2) * 2;
            return a;
        }
        public void showAdress(){
            double a = AreaCalculator();
            double b = PerCalc();
            Console.WriteLine($"Площа: {a}\nПериметр: {b}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 сторону: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2 сторону: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle newRectangle = new Rectangle(side1,side2);

            newRectangle.showAdress();
            
            

        }
    }
}
