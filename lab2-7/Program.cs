using System;

namespace lab2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            employee employee1 = new employee();

            employee1.profileInfo("Roman", "Zhykhor", 2, 1);
            employee1.salaryCalc();

            employee1.showInfo();
        }
    }
}
