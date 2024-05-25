using System;

class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double total;
        char op;

        Console.WriteLine("Введите 1-ое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию:");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите 2-ое число:");
        b = Convert.ToDouble(Console.ReadLine());

        if (op == '+')
        {
            total = a + b;
            Console.WriteLine("Сумма " + a + " и " + b + " = " + total);
        }
        else if (op == '-')
        {
            total = a - b;
            Console.WriteLine("Разность " + a + " и " + b + " = " + total);
        }
        else if (op == '*')
        {
            total = a * b;
            Console.WriteLine("Произведение " + a + " и " + b + " = " + total);
        }
        else if (op == '/')
        {
            if (b != 0)
            {
                total = a / b;
                Console.WriteLine("Частное " + a + " и " + b + " = " + total);
            }
            else
            {
                Console.WriteLine("Деление на ноль! ОТМЕНА");
            }
        }
        else
        {
            Console.WriteLine("Неизвестная операция!");
        }
    }
}
