namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, R, V;
            Console.WriteLine("Введiть висоту ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть радіуc");
            R = double.Parse(Console.ReadLine());
            if (R > 0)
            {
                Console.WriteLine("V = h*R^2*PI");

                V = (Math.Pow(R, 2)) * h * Math.PI;
                // V = (Math.Pow(R, 2)) * h * P; ne rabotaet(
                Console.WriteLine(V);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}