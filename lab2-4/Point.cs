using System;

namespace lab2_4
{
    public class Point{
        private int X;
        private int Y;
        

        public int x {get{return X;} }
        public int y {get{return Y;} }
        public string pointName;

        public Point(int x, int y, string pName){
            this.X = x;
            this.Y = y;
            this.pointName = pName;
        }

    }
}        
    


