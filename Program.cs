using System;

namespace ProjeVariable
{
    internal class Degiskenler
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Lütfen adinizi girin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " +name);

            //Değişkenleri tanımlama ve ekrana bastırma
            byte a = 1;     // 1 byte
            sbyte b = 2;    // 1 byte
            short c = 14;   // 2 byte
            ushort d = 12;  // 2 byte
            int i = 1548;   // 4 byte
            long l = 8;     // 8 byte
            float f = 25;   // 4 byte
            double e = 84;  // 8 byte
            decimal g = 5;  // 16 byte
            char ch = '2';  // 2 byte
            string str = "Zehra Çakır";     // Sınırsız
            bool b1 = true;     // 1 byte
            bool b2 = false;    // 1 byte

            DateTime dt = DateTime.Now;
            Console.WriteLine("Tarih: "+dt);

            object x = 16;
            Console.WriteLine(x);
            object y = "Merhaba";
            Console.WriteLine(y);
            object z = 6.3;
            Console.WriteLine(z);

            string str1 = string.Empty;
            str1 = "Ugur";
            Console.WriteLine(str1);

            int number1 = 2;
            int number2 = 4;

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number1 / number2);

            bool bool1 = 3 > 1;
            Console.WriteLine(bool1);

            string number3 = "456";
            int number4 = 789;
            string newStringNumber = number3 + number4.ToString();
            Console.WriteLine("string - new number = " + newStringNumber);
            int newIntNumber = Convert.ToInt32(number3) + number4;
            Console.WriteLine("int - new number = " + newIntNumber);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Date: "+datetime);

            string hour = DateTime.Now.ToString("HH/mm");
            Console.WriteLine("Hour: "+hour);

        }
    }
}