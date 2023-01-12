public class Reverse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, reverseint = 0, rem;
            Console.Write("Введiть число: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverseint = reverseint * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Перевернуте число: " + reverseint);




            string str = "", reversestr = "";
            int Length = 0;
            Console.WriteLine("Введiть слово");

            str = Console.ReadLine();

            Length = str.Length - 1;
            while (Length >= 0)
            {
                reversestr = reversestr + str[Length];
                Length--;
            }

            Console.WriteLine("Перевернуте слово {0}", reversestr);


            Console.WriteLine("Масив");
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Перевернутий масив");


            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();



        }
    }

}