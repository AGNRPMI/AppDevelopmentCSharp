using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar03
{
    public class Labirint
    {
        public int[,]? array;
        public int[,] ChooseLabirint()
        {
            Console.WriteLine("выбери лабиринт 1, 2, 3 или 4");
            int type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                default:
                case 1:
                    array = new int[,]
                    {
                        {1, 1, 1, 1, 1, 1, 1 },
                        {1, 0, 0, 0, 0, 0, 1 },
                        {1, 0, 1, 1, 1, 0, 1 },
                        {2, 0, 0, 0, 1, 0, 2 },
                        {1, 1, 0, 0, 1, 1, 1 },
                        {1, 1, 1, 0, 1, 1, 1 },
                        {1, 1, 1, 2, 1, 1, 1 }
                    };
                    return array;
                case 2:
                    array = new int[,]
                    {
                        {1, 1, 1, 2, 1, 1, 1 },
                        {1, 0, 0, 0, 0, 0, 1 },
                        {1, 0, 1, 1, 1, 0, 1 },
                        {2, 0, 0, 0, 1, 0, 2 },
                        {1, 1, 0, 0, 1, 1, 1 },
                        {1, 1, 1, 0, 1, 1, 1 },
                        {1, 1, 1, 2, 1, 1, 1 }
                    };
                    return array;
                case 3:
                    array = new int[,]
                    {
                        {1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
                        {1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 },
                        {1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 },
                        {2, 0, 0, 0, 1, 0, 1, 0, 0, 0, 2 },
                        {1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1 },
                        {1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1 },
                        {1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 2 },
                        {1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
                        {1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1 },
                        {1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 },
                        {1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1 }
                    };
                    return array;
                case 4:
                    array = new int[,]
                    {
                        {1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 },
                        {1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 },
                        {1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 },
                        {2, 0, 0, 0, 1, 0, 1, 0, 0, 0, 2 },
                        {1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1 },
                        {1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1 },
                        {1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 2 },
                        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                        {1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1 },
                        {1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 },
                        {1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1 }
                    };
                    return array;
            }
        }

        public void PrintArray()
        {
            int width = array.GetLength(0);
            int heigth = array.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public bool HasExit()
        {
            Console.WriteLine("Стартовая точка в центре массива");
            int startI = array.GetLength(0)/2;
            int startJ = array.GetLength(1)/2 ;
            Stack<Tuple<int, int>> stack = new();
            stack.Push(new(startI, startJ));
            int i = 0;
            
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                if (array[temp.Item1, temp.Item2] == 2)
                {
                    Console.WriteLine($"Выход найден! в точке {temp.Item1+1},{temp.Item2+1}");
                    //return true;
                    i++;
                }
                array[temp.Item1, temp.Item2] = 1;
                try
                {
                    if (temp.Item2 >= 0 && array[temp.Item1, temp.Item2 - 1] != 1)
                        stack.Push(new(temp.Item1, temp.Item2 - 1)); // вверх

                    if (temp.Item2 + 1 < array.GetLength(1) && array[temp.Item1, temp.Item2 + 1] != 1)
                        stack.Push(new(temp.Item1, temp.Item2 + 1)); // низ

                    if (temp.Item1 >= 0 && array[temp.Item1 - 1, temp.Item2] != 1)
                        stack.Push(new(temp.Item1 - 1, temp.Item2)); // влево

                    if (temp.Item1 + 1 < array.GetLength(0) && array[temp.Item1 + 1, temp.Item2] != 1)
                        stack.Push(new(temp.Item1 + 1, temp.Item2)); // вправо
                }
                catch
                {
                    startI = array.GetLength(0) / 2;
                    startJ = array.GetLength(1) / 2;
                }
            }
            Console.WriteLine($"Количество выходов: {i}"); 
            return false;
        }

    }
}
