using System;
using System.Text;

namespace CSharpExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            while (isOpen)
            {
                isOpen = WorkingProcess(isOpen);
                if (isOpen)
                {
                    PrintTaskDescription();
                    // блок кода для исполнения программы
                    System.Console.Write("Введи число А:");
                    double numberA = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Введи число B:");
                    double numberB = Convert.ToDouble(Console.ReadLine());
                    double numberC = 0;
                    string _action = "n";

                    while (_action != "exit")
                    {
                        System.Console.Write("Введите символ арифметического действия (+, -, *, / или n для выхода)");
                        _action = Console.ReadLine();
                        switch (_action)
                        {
                            case "+":
                                numberC = numberA + numberB;
                                Console.WriteLine($"сумма {numberA}+{numberB} равна = {numberC}");
                                _action = "exit";
                                Console.WriteLine(" ");
                                break;
                            case "-":
                                numberC = numberA - numberB;
                                Console.WriteLine($"разность {numberA}-{numberB} равна = {numberC}");
                                _action = "exit";
                                Console.WriteLine(" ");
                                break;
                            case "*":
                                numberC = numberA * numberB;
                                Console.WriteLine($"произведение {numberA}*{numberB} равна = {numberC}");
                                _action = "exit";
                                Console.WriteLine(" ");
                                break;
                            case "/":
                                if (numberB == 0)
                                {
                                    Console.WriteLine("на ноль делить нельзя, попробуйте заново");
                                }

                                else
                                {
                                    numberC = numberA / numberB;
                                    Console.WriteLine($"частное {numberA}/{numberB} равна = {numberC}");
                                    Console.WriteLine(" ");
                                    _action = "exit";
                                }
                                break;
                            case "n":
                                Console.WriteLine("Завершение программы... Нажмите Enter");
                                Console.WriteLine(" ");
                                break;
                            default:
                                Console.WriteLine("команда не распознана, попробуйте заново");
                                Console.WriteLine(" ");
                                break;
                        }

                    }



                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static void PrintTaskDescription()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }


        static bool WorkingProcess(bool _isOpen)
        {
            string _choice = "none";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Желаете выполнить алгоритм? (y/n)");

            while (_choice != "y" || _choice != "n")
            {
                Console.WriteLine("введите команду: ");
                _choice = Console.ReadLine();
                switch (_choice)
                {
                    case "y":
                        Console.WriteLine("Выполняется функция ...");
                        Console.WriteLine(" ");
                        _isOpen = true;
                        break;
                    case "n":
                        Console.WriteLine("Завершение программы... Нажмите Enter");
                        Console.WriteLine(" ");
                        _isOpen = false;
                        break;
                    default:
                        Console.WriteLine("команда не распознана, введите еще раз");
                        Console.WriteLine(" ");
                        break;
                }
                if (_choice == "y" || _choice == "n") break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            return _isOpen;
        }
    }
}

