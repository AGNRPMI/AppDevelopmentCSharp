namespace Seminar06
{
    public class Calculator
    {

        public double numberA;
        public double numberB;
        public string _action = "n";

        private void SetNumbers()
        {
            Console.Write("Введи число А:");
            numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введи число B:");
            numberB = Convert.ToDouble(Console.ReadLine());
        }
        public void Action()
        {
            string _action = "n";

            while (_action != "exit")
            {
                SetNumbers();
                Console.Write("Введите символ арифметического действия (+, -, *, / или n для выхода)");
                _action = Console.ReadLine();
                switch (_action)
                {
                    case "+":
                        Sum(numberA, numberB);
                        _action = "exit";
                        break;
                    case "-":
                        Sub(numberA, numberB);
                        _action = "exit";
                        break;
                    case "*":
                        Multy(numberA, numberB);
                        _action = "exit";
                        break;
                    case "/":
                        Divide(numberA, numberB);
                        _action = "exit";

                        break;
                    case "n":
                        Console.WriteLine("Завершение программы... Нажмите Enter");
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.WriteLine("команда не распознана, попробуйте заново");
                        Console.WriteLine(" ");
                        break;
                }
            }
        }
        private void Sum(double a, double b)
        {
            double c = a + b;
            Console.WriteLine($"сумма {a}+{b} равна = {c}");

        }
        private void Sub(double a, double b)
        {
            double c = a - b;
            Console.WriteLine($"разность {a}-{b} равна = {c}");
        }
        private void Multy(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"произведение {a}*{b} равна = {c}");
        }
        private void Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("на ноль делить нельзя, попробуйте заново");
            }

            else
            {
                double c = a / b;
                Console.WriteLine($"частное {a}/{b} равна = {c}");
            }
        }


    }
}
