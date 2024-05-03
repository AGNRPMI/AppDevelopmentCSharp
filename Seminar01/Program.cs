using System;
using System.Text;

namespace AppDevelopmentCSharp.Seminar01
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
                    Person person1 = new Person("new");
                    Person person2 = new Person("new");
                    Person person3 = new Person("new");
                    Person person4 = new Person("new");
                    Person person5 = new Person("new");
                    Person person6 = new Person("new");
                    Person person7 = new Person("new");

                    person1.ChangeInfo(
                        "олег",
                        DateTime.Parse("01.01.1960"),
                        null,
                        null,
                        person2,
                        person3, person4

                    );

                    person2.ChangeInfo(
                        "марина",
                        DateTime.Parse("01.01.1965"),
                        null,
                        null,
                        person1,
                        person3, person4

                    );
                    person3.ChangeInfo(
                        "виктор",
                        DateTime.Parse("01.01.1985"),
                        person1,
                        person2,
                        person5,
                        person6, person7

                    );
                    person4.ChangeInfo(
                        "татьяна",
                        DateTime.Parse("01.01.1987"),
                        person1,
                        person2,
                        null,
                        null

                    );
                    person5.ChangeInfo(
                        "анна",
                        DateTime.Parse("01.01.1990"),
                        null,
                        null,
                        person3,
                        person6, person7

                    );
                    person6.ChangeInfo(
                        "сергей",
                        DateTime.Parse("01.01.2015"),
                        person3,
                        person5,
                        null,
                        null

                    );
                    person7.ChangeInfo(
                        "екатерина",
                        DateTime.Parse("01.01.2016"),
                        person3,
                        person5,
                        null,
                        null

                    );










                    person3.PrintInfo(person3);
                    Console.WriteLine();
                    person3.PrintFamilyInfo();

                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
                    // блок кода для исполнения программы
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
            Console.WriteLine("Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа). Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.");
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

