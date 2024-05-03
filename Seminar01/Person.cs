using System;

namespace AppDevelopmentCSharp.Seminar01
{
    public class Person
    {
        private string _name;
        private DateTime _dateBirth;
        private int _age;


        public Person? Father;
        public Person? Mother;
        public Person? Partner;
        public Person[]? Children;
        public int Age()
        {
            _age = DateTime.Now.Year - _dateBirth.Year;
            return _age;

        }

        public bool IsAdult()
        {
            if (_age >= 18) return true;
            else return false;
        }

        public void ChangeInfo(
            string name,
            DateTime dateBirth,
            Person father,
            Person mother,
            Person partner,
            params Person[] children
            )
        {
            this._name = name;
            this._dateBirth = dateBirth;
            this.Father = father;
            this.Mother = mother;
            this.Partner = partner;
            this.Children = children;

        }
        public Person(string name) { _name = name; }
        public Person(
            string name,
            DateTime dateBirth,
            Person father,
            Person mother,
            Person partner,
            params Person[] children)
        {
            _name = name;
            _dateBirth = dateBirth;
            Father = father;
            Mother = mother;
            Partner = partner;
            Children = children;

        }



        public void PrintInfo(Person person)
        {
            Console.Write($"ФИО: {person._name} возраст: {person.Age().ToString()} ");
        }

        public void PrintFamilyInfo()
        {
            if (Father != null && Mother != null)
            {
                Console.Write($"Отец: ");
                PrintInfo(Father);
                Console.Write("Мать: ");
                PrintInfo(Mother);
            }
            else if (Father == null && Mother != null)
            {
                Console.Write($"Отец: нет данных Мать: ");
                PrintInfo(Mother);
            }
            else if (Father != null && Mother == null)
            {
                Console.Write("Отец: ");
                PrintInfo(Father);
                Console.Write(" Мать: нет данных ");
            }
            else Console.WriteLine("Отец: нет данных Мать: нет данных");
            Console.WriteLine("|                        |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|                        |");
            Console.WriteLine("V                        V");

            if (Partner != null)
            {
                Console.Write($"ФИО: {_name} возраст: {Age().ToString()} ------> Супруг:");
                PrintInfo(Partner);
            }
            else Console.WriteLine($"ФИО: {_name} возраст: {Age().ToString()} ------> Супруг: нет данных");

            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("        V");
            if (Children != null && Children.Length > 0)
            {
                Console.WriteLine("Дети: ");
                foreach (Person child in Children)
                {
                    PrintInfo(child);
                }
            }
            else Console.WriteLine("дети: нет данных ");

        }
    }
}