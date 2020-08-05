using System;

namespace T2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            T2L4_1();
            T2L4_2();
            T2L4_3();
            T2L4_4();
            T2L4_5();
            Console.ReadLine();
        }

        public static void T2L4_1()
        {
            string name;
            string surname;
            int age;
            char gender;
            string nationalId;
            int id;
            string address;
        }
        public static void T2L4_2()
        {
            char zm1 = 'a';
            char zm2 = 'b';
            char zm3 = 'c';
            Console.WriteLine($"{zm3} {zm2} {zm1}");
        }
        public static void T2L4_3()
        {
            double width, length;
            Console.WriteLine("Enter the width...");
            double.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("Enter the length...");
            double.TryParse(Console.ReadLine(), out length);
            Console.WriteLine($"Result is: {Math.Sqrt(Math.Pow(width,2) + Math.Pow(length,2))}");
        }
        public static void T2L4_4()
        {
            int a = 10;
            string b = "Szkoła Dotneta";
            double c = 12.5;
        }
        public static void T2L4_5()
        {
            string name;
            string surname;
            int age;
            char gender;
            string nationalId;
            string address;

            Console.WriteLine("Enter Your name...");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your surname...");
            surname = Console.ReadLine();
            Console.WriteLine("Enter Your age...");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Enter Your gender...");
            char.TryParse(Console.ReadLine(), out gender);
            Console.WriteLine("Enter Your national id...");
            nationalId = Console.ReadLine();
            Console.WriteLine("Enter Your address...");
            address = Console.ReadLine();

            Console.WriteLine($"Your's data:\n{name}, \n{surname}, \n{age}, \n{gender}, \n{nationalId}, \n{address}.");
        }
    }
}
