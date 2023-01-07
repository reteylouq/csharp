namespace lab4
    // це програма, що створює другий масив, з якого видаляються елементи, що повторюются поруч один з іншим в першому масиві
{
    class program
    {
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(3);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    RemoveAt(ref arr, i);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
            }
        }
    }
}