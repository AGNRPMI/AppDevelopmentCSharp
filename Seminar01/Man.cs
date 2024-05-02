using System;
namespace Seminar01
{
    public class Man : Person
    {
        public bool HasBeard { get; private set; } = true;
        public Man(string name) : base(name)
        {

        }
        public Man(string name, DateTime birthday) : base(name, birthday)
        {

        }
        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = false;
        }
        public override void SayHello()
        {
            Console.WriteLine("Привет, я мужчина");
        }
        public override void TakeCare()
    {
        if (this.Children != null)
            Console.WriteLine("Кормит ужином и укладывает спать");
    }
    }
}