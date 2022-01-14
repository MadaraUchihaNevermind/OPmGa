using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class solution
    {
        public void Stack( string s)
        {
            int fullness = 0;
            int lenght = s.Count();

            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < lenght; i ++)
            {
                char firstbracket = s[i];
                if(firstbracket == '(' || firstbracket =='['|| firstbracket == '{')
                {
                    stack.Push(firstbracket);
                    fullness++;
                }
                else
                {
                    char endbracket;
                    if (fullness > 0)
                    {
                        endbracket = stack.Peek();
                        stack.Pop();
                        fullness--;
                    }
                    else 
                    { 
                        Console.WriteLine("Последовательность не правильная"); 
                        break;
                    }
                    if(endbracket == '(' && firstbracket == ')'|| endbracket == '{' && firstbracket == '}'|| endbracket == '[' && firstbracket == ']')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Последовательность не правильная");
                        break;
                    }
                    
                }
            }
            if(fullness == 0)
            {
                Console.WriteLine("Правильная последовательность");
            }
            else
            {
                Console.WriteLine("Последовательность не правильная");
            }



        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var sol = new solution();
            Console.WriteLine("Напиши последовательность скобок");
            string s = Console.ReadLine();
            sol.Stack(s);
        }
    }
}
