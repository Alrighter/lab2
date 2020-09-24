using System;

namespace lab2_4
{
    class Figure{

        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public string Fname;

        public Figure(Point A, Point B, Point C){
            this.A = A;
            this.B = B;
            this.C = C;
            this.Fname = "Трикутник";
        }
        public Figure(Point A, Point B, Point C, Point D){
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.Fname = "Чотирикутник";
        }
        public Figure(Point A, Point B, Point C, Point D, Point E){
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            this.Fname = "Пятикутник";
        }

        public double LengthSide(Point A, Point B){
            double length = Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow(A.y - B.y, 2));
            return length;
        }
        
        public void PerimeterCalculator(){
            if (E != null) {
                Console.WriteLine($"Периметр: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) + LengthSide(D, E) + LengthSide(E, A))}");
            }
            else if (D != null) {
                Console.WriteLine($"Периметр: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A))}");
            }
            else {
                 Console.WriteLine($"Периметр: {(LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A))}");
            }
        
        
        }
    }
}