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
                    Console.WriteLine("Введи количество строк: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введи количество столбцов: ");
                    int col = Convert.ToInt32(Console.ReadLine());
                    int[,] array = CreateArray(row, col);
                    Console.WriteLine("Сгенерированный массив: ");
                    PrintArray(array);
                    Console.WriteLine("Сортировка отдельных строк по возрастанию: ");
                    int[,] sortArray = SortingSingleRow(array, row, col, true);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка отдельных по убыванию: ");
                    sortArray = SortingSingleRow(array, row, col, false);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка всех элементов по возрастанию: ");
                    sortArray = SortingAllRow(array, row, col, true);
                    PrintArray(sortArray);
                    Console.WriteLine("Сортировка всех элементов по убыванию: ");
                    sortArray = SortingAllRow(array, row, col, false);
                    PrintArray(sortArray);
                }
            }
            Console.Write("Нажмите любую клавишу для завершения ...");
            Console.ReadKey();
            Console.Clear();
        }
        static int[,] CreateArray(int row, int col)
        {
            int[,] _array = new int[row, col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    _array[i, j] = rand.Next(-100, 101);
            }
            Console.WriteLine();

            return _array;
        }
        static void PrintArray(int[,] _array)
        {
            int width = _array.GetLength(0);
            int heigth = _array.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                    Console.Write(_array[i, j] + " ");
                Console.WriteLine();
            }

        }
        static int[,] SortingAllRow(int[,] array2D, int row, int col, bool upOrDown)
        {
            int[] tempArray = new int[row * col];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    tempArray[i * col + j] = array2D[i, j];
                }
            }
            Array.Sort(tempArray);
            if (upOrDown == false) Array.Reverse(tempArray);
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = tempArray[i * col + j];
                }
            }
            return array2D;
        }

        static int[,] SortingSingleRow(int[,] array2D, int row, int col, bool upOrDown)
        {
            int[] tempArray = new int[col];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    tempArray[j] = array2D[i, j];
                }
                Array.Sort(tempArray);
                if (upOrDown == false) Array.Reverse(tempArray);
                for (int k = 0; k < array2D.GetLength(0); k++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        array2D[i, j] = tempArray[j];
                    }
                }
            }


            return array2D;
        }
        static void PrintTaskDescription()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Дан двумерный массив." +
                                "\n732" +
                                "\n496" +
                                "\n185" +
                                "\nОтсортировать данные в нем по возрастанию." +
                                "\n123" +
                                "\n456" +
                                "\n789" +
                                "\nВывести результат на печать.");


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
