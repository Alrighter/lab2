using System;

namespace lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            user user1 = new user();
            user1.profileFill("user1", "Roman", "Zhykhor", 18, "15.09.2020");
            user1.showProfile();
        }
    }
}
