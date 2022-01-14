using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{

    class solution
    {

        public bool SameAlpha(string[] s, int n)
        {

            char[] clone;
            for (int i = 0; i < n; i++)
            {
                clone = s[i].ToArray();
                Array.Sort(clone);
                s[i] = new string(clone);

            }
            for (int i = 1; i < n; i++)
            {
                if (s[0] != s[i])
                {
                    return false;
                }
            }

            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            Console.WriteLine("Введите массив слов");
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            var sol = new solution();

            bool answer = sol.SameAlpha(s, n);
            if (answer == true)
            {
                Console.WriteLine("Слова состоят из одинаковых символов");
            }
            else { Console.WriteLine("Слова состоят из разных символов"); }





        }
    }
}