using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Calculator_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("Просто здравствуй, просто как дела?");
            while (true)
            {
                double a, b, c; char h; c = 0.0;
                Console.WriteLine("введите первое число "); a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(@"Выберите действие:
                1) Сложение 
                2) Вычетание
                3) Умножение
                4) Деление 
                5) Возвышение в степень N 
                6) Квадратный корень числа/Не доступна
                7) Найти 1 процент от числа/
                8) Найти факториал из числа"); h = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("введите второе число "); b = Convert.ToDouble(Console.ReadLine());
                switch (h)
                {
                    case '1':
                        c = a + b;
                        break;
                    case '2':
                        c = a - b;
                        break;
                    case '3':
                        c = a * b;
                        break;
                    case '4':
                        c = a / b;
                        break;
                    case '5':
                        result = Math.Pow(a, b);
                        Console.WriteLine($" {a} ^ {b} = " + result);
                        break;
                    case '6':
                        break;
                    case '7':
                        c = a / 100;
                        break;
                    case '8':
                        {
                            int num = a;
                            int result = 1;

                            for (int i = 1; i <= num; i++)
                            {
                                result = result * i;
                            }
                        }

                }
                Console.WriteLine();
                Console.WriteLine("Ответ: " + result);
                Console.WriteLine("Повторить? (Y/N)");
                ConsoleKeyInfo e = Console.ReadKey();
                if (e.KeyChar == 'n') break;
                Console.WriteLine();

            }

        }
    }
}