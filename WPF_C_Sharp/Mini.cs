using System;
namespace WPF_C_Sharp
{
    public class Mini
    {
        static int minimum = 0;

        static int maximum = 2;

        public static int[] Positioning()
        {
            Random random = new Random();

            int[] array = new int[3];;
            int index = random.Next(minimum, maximum);

            array[index] = 1;

            return array;
        }

        public static void isHitting(int[] array, int index)
        {
            if (array[index] == 1)
            {
                Console.WriteLine("Getroffen");
                Console.WriteLine(String.Join(" ", array));
            }
            else
            {
                Console.WriteLine("Daneben");
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}

