namespace Laba3
{
    // мій номер за списком 21, але я не розумію завдання №21, тому вирішив зробити завдання, що вважаю простіше - №6
    class Program
    {
        static void Main(string[] args)
        {
            double x, res;
            string num;
            Console.WriteLine("Перевірка на непарність трьохзначнього числа:");
            num = Console.ReadLine();
            x = Double.Parse(num);
            res = x % 2;
            if (x > 99 && x < 1000 && res == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}