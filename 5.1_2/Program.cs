using System;

namespace _5._1_2
{
    internal class Program
    {
        static string DivideWord(string s)
        {
            string[] subs = s.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($" {sub}");
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();

            DivideWord(text);
            Console.ReadLine();
        }
    }
}
