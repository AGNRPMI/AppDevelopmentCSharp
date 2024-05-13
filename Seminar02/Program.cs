using System;
using System.Diagnostics.Metrics;
using System.Text;

namespace Seminar02
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
                    PrintTypeInfo();

                    byte b = 100;
                    int i = 1000;
                    long l = 100000000000000;



                    
                    Console.WriteLine("Проверка приведения в byte:");
                    var d = new Bits(b);
                    byte number1 = d;
                    Console.WriteLine(number1);
                    Bits bits_b = (Bits)number1;
                    Console.WriteLine(bits_b);
                    
                    
                    Console.WriteLine("Проверка приведения в int:");
                    var e = new Bits(i);
                    int number2 = e;
                    Console.WriteLine(number2);
                    Bits bits_i = (Bits)number2;
                    Console.WriteLine(bits_i);
                    
                    Console.WriteLine("Проверка приведения в long:");
                    var r = new Bits(l);
                    long number3 = r;
                    Console.WriteLine(number3);
                    Bits bits_l = (Bits)number3;
                    Console.WriteLine(bits_l);
                    
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
            Console.WriteLine("Реализуйте операторы неявного приведения из long,int,byt в Bits.");
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
        static void PrintTypeInfo()
        {
            Console.WriteLine("Типы данных и диапазон значений");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Type    Byte(s) of memory               Min                            Max");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            Console.WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            Console.WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            Console.WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            Console.WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            Console.WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            Console.WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            Console.WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            Console.WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            Console.WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            Console.WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}

