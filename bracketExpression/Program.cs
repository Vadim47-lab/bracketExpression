using System;

namespace bracketExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Программа скобочное выражение:");

            char openingBracket = '(';
            char closingBracket = ')';
            string expression;
            int maximumDepth = 0;
            int currentDepth = 0;

            Console.Write(" Введите скобочное выражение |Пример ((()))|: ");
            expression = Console.ReadLine();

            if (expression.Length == 0)
            {
                Console.WriteLine("Ошибка!");
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    currentDepth++;

                    if (currentDepth > maximumDepth)
                    {
                        maximumDepth = currentDepth;
                    }
                }

                else if (expression[i] == ')')
                {
                    currentDepth--;

                    if (currentDepth < 0)
                    {
                        break;
                    }
                }
            }

            if (currentDepth == 0)
            {
                Console.WriteLine("\n Скобочное выражение является корректным!");
            }
            else
            {
                Console.WriteLine("\n Скобочное выражение не является корректным! В нем присутствует лишная скобка!");
            }

            Console.WriteLine("\n Максимальная глубина вложенности скобок maximumDepth = " + maximumDepth + ".");
        }
    }
}