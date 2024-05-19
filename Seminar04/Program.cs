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
                    Console.WriteLine("Введи размерность А для одномерного массива: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int[] array1D = CreateArray1D(a);

                    PrintArray1D(array1D);
                    FindSum(array1D);

                    bool isOpen2 = true;




                    while (isOpen2)
                    {
                        string _choice2 = "none";
                        Console.WriteLine("Желаете повторить поиск? (y/n) :");
                        _choice2 = Console.ReadLine();
                        switch (_choice2)
                        {
                            case "y":                                
                                isOpen2 = true;
                                break;
                            case "n":
                                
                                isOpen2 = false;
                                break;
                            default:
                                Console.WriteLine("команда не распознана, введите еще раз");
                                Console.WriteLine(" ");
                                break;
                        }

                        if (isOpen2) FindSum(array1D);
                        else break;
                    }





                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }

        static void FindSum(int[] array)
        {

            Console.WriteLine("Введи число, которое можно получить из суммы 3х чисел из массива: ");
            int? targetSum = Convert.ToInt32(Console.ReadLine());
            Array.Sort(array);
            int left = 0;
            int middle = 1;
            int right = array.Length - 1;
            try
            {
                while (left < right - 1)
                {

                    int sum = array[left] + array[middle] + array[right];

                    if (sum == targetSum)
                    {
                        Console.WriteLine($"Найдена тройка чисел: {array[left]}, {array[middle]}, {array[right]}");
                        break;
                    }
                    else if (sum < targetSum)
                    {
                        middle++;
                    }
                    else
                    {
                        right--;
                    }
                }

                if (left > right - 1)

                {
                    Console.WriteLine("Такая тройка чисел не существует");
                }
            }
            catch
            {
                Console.WriteLine("такого числа тут не может быть");
            }
        }


        static int[] CreateArray1D(int col)
        {
            int[] _array = new int[col];
            Random rand = new Random();
            for (int i = 0; i < col; i++)
            {
                _array[i] = rand.Next(-10, 11);
            }
            Console.WriteLine();

            return _array;
        }

        static void PrintArray1D(int[] _array)
        {
            int width = _array.GetLength(0);

            for (int i = 0; i < width; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();

        }

        static void PrintTaskDescription()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.");
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

