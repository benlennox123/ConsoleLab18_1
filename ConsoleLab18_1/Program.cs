using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"([]{})[]";
            char[] strArray = str.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (char item in strArray)
            {
                try
                {
                    if (item == ')' && stack.Peek() == ')')
                    {
                        stack.Pop();
                    }
                    if (item == '}' && stack.Peek() == '}')
                    {
                        stack.Pop();
                    }
                    if (item == ']' && stack.Peek() == ']')
                    {
                        stack.Pop();
                    }
                }
                catch
                {
                    Console.WriteLine("Скобки расствлены НЕ корректно! Стек пуст");
                    Console.WriteLine();
                    Console.WriteLine("Для завершения нажмите любую клавишу");
                    Console.ReadKey();
                    return;
                }
                
                if (item=='(')
                {
                    stack.Push(')');
                }
                if (item == '{')
                {
                    stack.Push('}');
                }
                if (item == '[')
                {
                    stack.Push(']');
                }
            }
            Console.WriteLine(strArray);
            Console.WriteLine();
            if (stack.Count()==0)
            {
                Console.WriteLine("Скобки расствлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расствлены НЕ корректно");
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
