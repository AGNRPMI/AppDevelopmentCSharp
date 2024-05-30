using Seminar07;
using System;
using System.Reflection;
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
                    // Task();
                    Task2();
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
            Console.WriteLine("Разработайте атрибут позволяющий методу ObjectToString сохранять поля классов с использованием произвольного имени.\r\n\r\nМетод StringToObject должен также уметь работать с этим атрибутом для записи значение в свойство по имени его атрибута.\r\n\r\n[CustomName(“CustomFieldName”)]\r\npublic int I = 0.\r\n\r\nЕсли использовать формат строки с данными использованной нами для предыдущего примера то пара ключ значение для свойства I выглядела бы CustomFieldName:0\r\n\r\nПодсказка:\r\n\r\nЕсли GetProperty(propertyName) вернул null то очевидно свойства с таким именем нет и возможно имя является алиасом заданным с помощью CustomName. Возможно, если перебрать все поля с таким атрибутом то для одного из них propertyName = совпадает с таковым заданным атрибутом.");
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


        static object StringToObject(string s)
        {
            string[] arrayInfo = s.Split("\n");

            Console.WriteLine($"{arrayInfo[0]} - {arrayInfo[1]}");

            var t4 = Activator.CreateInstance(null, arrayInfo[1]).Unwrap();

            if (t4 != null && arrayInfo.Length > 2)
            {
                Type type = t4.GetType();

                for (int i = 2; i < arrayInfo.Length; i++)
                {
                    string[] arrayInfo2 = arrayInfo[i].Split("=");
                    var prop = type.GetProperty(arrayInfo2[0]);

                    if (prop == null) continue;
                    if (prop.PropertyType == typeof(int))
                    {
                        prop.SetValue(t4, int.Parse(arrayInfo2[1]));
                    }
                    else if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(t4, arrayInfo2[1]);
                    }
                    else if (prop.PropertyType == typeof(char[]))
                    {
                        prop.SetValue(t4, arrayInfo2[1].ToCharArray());
                    }
                    else if (prop.PropertyType == typeof(decimal))
                    {
                        prop.SetValue(t4, decimal.Parse(arrayInfo2[1]));
                    }
                }
            }
            return t4;
        }

        static string ObjectToString(object o)
        {
            StringBuilder sb = new StringBuilder();

            Type type = o.GetType();

            sb.Append(type.Assembly + "\n");
            sb.Append(type.FullName + "\n");

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                if (prop.GetCustomAttribute<DontSaveAttribute>() != null) continue;
                sb.Append(prop.Name + "=");
                var val = prop.GetValue(o);

                if (prop.PropertyType == typeof(char[]))
                {
                    sb.Append(new string(val as char[]) + "\n");
                }
                else
                {
                    sb.Append(val + "\n");
                }
            }

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                var attribute = field.GetCustomAttribute<CustomNameAttribute>();
                if (attribute != null)
                {
                    sb.Append(attribute.CustomName + "=");
                    var fieldVal = field.GetValue(o);
                    sb.Append(fieldVal + "\n");
                }
            }
            return sb.ToString();
        }

        public static void Task()
        {
            Type type = typeof(TestClass);
            var t1 = Activator.CreateInstance(type);

            var t2 = Activator.CreateInstance(type, (10));

            var t3 = Activator.CreateInstance(type, 10, new[] { 'A', 'B', 'C' }, "Hello", 10.01m);
        }

        public static void Task2()
        {
            Type type = typeof(TestClass);

            var t3 = Activator.CreateInstance(type, 10, new[] { 'A', 'B', 'C' }, "Hello", 10.01m, "Hi");

            string objectToString = ObjectToString(t3);
            Console.WriteLine(objectToString);
            var obj = StringToObject(objectToString);
        }


    }
}

