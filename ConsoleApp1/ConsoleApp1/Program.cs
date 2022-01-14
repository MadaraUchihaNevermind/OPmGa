using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    class Solution
    {
       public  void IsPolindrome(string s)
        {
            bool check = true;
            var pal = s.ToLower();
            pal = System.Text.RegularExpressions.Regex.Replace(pal, @"[/.!,\s:;?]", "");
            int lengh = pal.Count();
            for(int i = 0; i < lengh/2;i++)
            {
                if(pal[i]!=pal[lengh-i-1])
                {
                    Console.WriteLine("Строка не палиндром");
                    check = false;
                    break;
                }
                else if(pal[i]==pal[lengh-i-1])
                {
                    continue;
                }
            }
            if(check == true)
            {
                Console.WriteLine("Строка палиндром");
            }
            

            
           
        }

    }
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string palindrome = Console.ReadLine();
            var sol = new Solution();
            sol.IsPolindrome(palindrome);


            
        }
    }
}
