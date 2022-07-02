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

            Console.Write(" Введите скобочное выражение |Пример ((()))|: ");
            expression = Console.ReadLine();

            if (expression.Length == 0)
            {
                Console.WriteLine("Ошибка!");
            }

            for (int i = 0; i < expression.Length; i++)
            {
                if ((expression[i] == openingBracket) && (expression[expression.Length - 1] == closingBracket))
                {
                    maximumDepth++;
                }

                else if ((expression[i] != openingBracket) || (expression[expression.Length - 1] != closingBracket))
                {
                    Console.WriteLine("\n Скобочное выражение не является корректным! В нем присутствует лишная скобка!");
                }
            }

            Console.WriteLine("\n Максимальная глубина вложенности скобок maximumDepth = " + maximumDepth + ".");
        }
    }
}
