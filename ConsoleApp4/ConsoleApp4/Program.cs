using System;
using System.Text;
using System.Linq;

namespace ConsoleApp4
{
    class solution
    {
        public void Year(int year)
        {
            if(year % 4 == 0 ||year % 400 == 0 && year % 100 !=0 )
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год невисокосный");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год для проверки");
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            var sol = new solution();
            sol.Year(year);
        }
    }
}
