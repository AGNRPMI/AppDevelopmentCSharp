using System;
namespace Seminar01
{
    internal class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public readonly int Height;
        public enum Gender { Male, Female }
        public Person Mother = null;
        public Person Father = null;
        public Person[] Children = null;
        public Gender Sex { get; set; }


        public Person(string name, DateTime birthday, int heigth)
        {
            if (birthday > DateTime.Now)
            {
                Console.WriteLine($"Дата рождения {bithday.ToString("dd.MM.yyyy")} не может быть больше чем {DateTime.Now.ToString("dd.MM.yyyy")}");
                Birthday = DateTime.Now;
            }
            else
            {
                Birthday = birthday;
            }
            Name = name;
            Height = height;
        }
        public Person(string name, int height)
        {
            Name = name;
            Birthday = DateTime.Now;
            Height = height;
        }



        public void PrintInfo()
        {
            Console.WriteLine($"Имя={Name}, день рождения {Birthday.ToString("dd.MM.yyyy")}")
            }
        public void AddFamilyInfo(FamilyMember father, FamilyMember mother, params FamilyMember[] children)
        {
            Father = father;
            Mother = mother;
            children = children;
        }
        public bool IsAdult(int adultAge = 18)
        {
            var delta = DateTime.Now.Year - Birthday.Year;
            if (delata > adultAge || (delta == adultAge && DateTime.Now.DayOfYear <= Birthday.DayOfYear))
            {
                return true;
            }
            else
                return false;
        }

        public bool GetChildren(out Person[] children)
        {
            if (Children != null && Children.Length != 0)
            {
                children = Children;
                return true;
            }
            else
            {
                children = null;
                return false;
            }
        }
        public abstract void TakeCare();
        public virtual void SayHello()
        {
            Console.WriteLine("Привет, я человек");
        }

        public void PrintFamilyInfo()
        {
            if (Father != null)
            {
                Console.Write("Отец: ");
                Father.PrintInfo();
            }
            if (Mother != null)
            {
                Console.Write("Мать: ");
                Mother.PrintInfo();
            }
            if (Children != null && Children.Length > 0)
            {
                Console.Write("Дети: ");
                foreach (var child in Children)
                {
                    child.PrintInfo();
                }
            }
        }
    }
}