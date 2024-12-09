using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(userName);

            string someText = "Some text";
            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = true;
            bool isUserNotReady = false;

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime dateOfBirth = new DateTime(2000, 11, 20);
            Console.WriteLine(dateOfBirth);

            byte byteNumber = 200;
            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;

        }
    }
}
