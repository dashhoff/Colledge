using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShalyapinD.A
{
    internal class Program
    {
        private static float num_1, num_2;
        private static float result;

        private static string operation;
        private static string choiceContinue;

        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Введите первое число");
                num_1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                num_2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Введите операцию");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num_1 + num_2;
                        Console.WriteLine("Результат: " + result);
                        break;

                    case "-":
                        result = num_1 - num_2;
                        Console.WriteLine("Результат: " + result);
                        break;

                    case "/":
                        if (num_2 != 0)
                        {
                            result = num_1 / num_2;
                            Console.WriteLine("Результат: " + result);
                        }
                        else Console.WriteLine("Делить на 0 нельзя");
                        break;

                    case "*":
                        result = num_1 * num_2;
                        Console.WriteLine("Результат: " + result);
                        break;

                }

                Console.Write("Хотите продолжить? (y/n): ");
                choiceContinue = Console.ReadLine();

            }
            while (choiceContinue == "y" || choiceContinue == "Y");
        }
    }
}
