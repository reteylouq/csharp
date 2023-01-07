namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nn, nk, k;
            double res = 0;
            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());

            for (k = nn; k < nk; k++)
            {
                if (0 <= nn & nn <= nk)
                {
                   res += (Math.Pow(-1, (Math.Pow(k, 2)) + 1) * Math.Pow(k, 2) - 2) / (3 * Math.Pow(k, 2) - 2 * k);
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            Console.WriteLine(res);
        }
    }
}