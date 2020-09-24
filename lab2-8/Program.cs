using System;

namespace lab2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            invoice check1 = new invoice();
            check1.login(54235, "Roman", "Vitaliy");
            check1.fillItem("Ice cream", 2, 30);

            check1.display();
        }
    }
}
