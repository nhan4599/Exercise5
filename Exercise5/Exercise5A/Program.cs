using System;

namespace Exercise5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a to z :");
            Print_a_z();
            Console.WriteLine();

            Console.WriteLine("z to a :");
            Print_z_a();
            Console.WriteLine();

            Console.WriteLine("A to Z :");
            Print_A_Z();
            Console.WriteLine();

            Console.Write("Input character which you want to show ASCII Code : ");
            char c = Char.Parse(Console.ReadLine());
            Console.WriteLine("ASCII Code in decimal : {0}", (int)c);
            Console.WriteLine("ASCII Code in hexa : {0}", "0x" + Convert.ToString((int)c, 16));
            Console.WriteLine("ASCII Code in binary : {0}", Convert.ToString((int)c, 2));
            Console.WriteLine("Is upper ? : {0}", IsUpper(c));
            Console.WriteLine("Is lower ? : {0}", IsLower(c));
            Console.WriteLine("To upper : {0}", ToUpper(c));
            Console.WriteLine("To lower : {0}", ToLower(c));
        }

        private static void Print_A_Z()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i + "\t");
            }
        }

        private static void Print_z_a()
        {
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.Write(i + "\t");
            }
        }

        public static void Print_a_z()
        {
            for (char i = 'a'; i < 'z'; i++)
            {
                Console.Write(i + "\t");
            }
        }

        private static bool IsUpper(char c)
        {
            return c >= 'A' && c <= 'Z' ? true : false;
        }

        private static bool IsLower(char c)
        {
            return c >= 'a' && c <= 'z' ? true : false;
        }

        private static char ToUpper(char c)
        {
            return IsLower(c) ? (char)(c - ('a' - 'A')) : c;
        }

        private static char ToLower(char c)
        {
            return IsUpper(c) ? (char)(c + ('a' - 'A')) : c;
        }
    }
}
