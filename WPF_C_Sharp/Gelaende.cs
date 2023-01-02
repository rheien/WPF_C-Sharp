using System;
namespace WPF_C_Sharp
{
    public class Gelaende
    {
        public static void ColorBackground(string name)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), name, true);
            Console.Write("  ");
            Console.ResetColor();
        }
    }
}

