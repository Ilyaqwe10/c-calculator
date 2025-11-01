using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Калькулятор\n");
                Console.Write("Введите число 1: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число 2: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выбирите действие: + - * /");
                string c = Console.ReadLine();

                if (c == "+")
                {
                    double result = a + b;
                    Console.WriteLine(result);
                }

                else if(c == "-")
                {
                    double result = a - b;
                    Console.WriteLine(result);
                }

                else if (c == "*")
                {
                    double result = a * b;
                    Console.WriteLine(result);
                }

                else if (c == "/")
                {
                    double result = a / b;
                    Console.WriteLine(result);

                    if(b == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                    }
                }

            }

            catch
            {
                Console.WriteLine("Введите число");
            }

            
        }
    }
}

