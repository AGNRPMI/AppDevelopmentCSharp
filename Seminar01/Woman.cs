using System;
namespace Seminar01
{
    public class Woman : Person
    {
        public bool HasMakeup { get; private sbyte;} = false;
        public Woman(string name) : base(name)
    {

    }
    public Woman(string name, DateTime birthday) : base(name, birthday)
    {

    }
    public void PutMakeupOn()
    {
        Console.WriteLine("Наносит макияж");
        this.HasMakeup = true;
    }
    public void RemoveMakeup()
    {
        Console.WriteLine("Удаляет макияж");
        this.HasMakeup = false;
    }
    public override void SayHello()
    {
        Console.WriteLine("Привет, я женщина");
    }
    public override void TakeCare()
    {
        if (this.Children != null)
            Console.WriteLine("Проверяет уроки потом идет с детьми на прогулку");
    }

}
}