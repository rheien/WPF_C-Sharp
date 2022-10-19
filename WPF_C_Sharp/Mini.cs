using System;
namespace WPF_C_Sharp
{
    public class Mini
    {
        static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0,3);
        }

        public static int[] Positioning()
        {
            int[] array = new int[3];
            int index = RandomNumber();

            array[index] = 1;

            return array;
        }

        public static void isHitting(int[] array, int index)
        {
            if (array[index] == 1)
            {
                Console.WriteLine("Getroffen");
            }
            else
            {
                Console.WriteLine("Daneben");
            }
        }
    }
}

