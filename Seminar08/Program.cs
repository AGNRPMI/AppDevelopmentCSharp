using Seminar08;
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
                    List<string> list = new List<string>();

                    Reader.FindFiles("F:\\Рабочая папка\\Project_CSharp\\GB\\AppDevelopmentCSharp\\Seminar08", "*.txt", list);

                    foreach (string file in list)
                    {
                        if (Reader.FindWord(file, "инкапсуляция") == true)
                        {
                            Console.WriteLine(file);
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
            Console.WriteLine("Объедините две предыдущих работы (практические работы 2 и 3): поиск файла и поиск текста в файле написав утилиту которая ищет файлы определенного расширения с указанным текстом. Рекурсивно. Пример вызова утилиты: utility.exe txt текст.");
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

