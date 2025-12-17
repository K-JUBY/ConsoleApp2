using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для расчета значений уравнений.");
            Console.Write("Введите значение x: ");

            // Считываем строку и пытаемся преобразовать её в число
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                Console.WriteLine($"\nВыполняем расчет для x = {x}...\n");

                // --- Уравнение 1 ---
                // Формула: y = (2x - 7) / корень(3x + 21)
                // Примечание: 3x + 21 должно быть > 0 (x > -7)
                double y1 = (2 * x - 7) / Math.Sqrt(3 * x + 21);

                // --- Уравнение 2 ---
                // Формула: y = корень( x / (x - 1) )
                // Примечание: подкоренное выражение должно быть >= 0
                double y2 = Math.Sqrt(x / (x - 1));

                // --- Уравнение 3 ---
                // Формула: y = (x + 1)/(x - 1) + корень(x^2)
                // Примечание: x не должен быть равен 1
                double y3 = ((x + 1) / (x - 1)) + Math.Sqrt(Math.Pow(x, 2));

                // --- Вывод результатов ---
                Console.WriteLine(y1);
                Console.WriteLine(y2);
                Console.WriteLine(y3); 
            }
            else
            {
                Console.WriteLine("Ошибка: Введено не число.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

       
           
        }
    }
    

