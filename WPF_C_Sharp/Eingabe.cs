using System;
namespace WPF_C_Sharp
{
    public class Eingabe
    {
        public Eingabe()
        {

        }

        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine x-Koordinate ein: ");
            string coordinateX = Console.ReadLine();

            Console.Write("Geben Sie eine y-Koordinate ein: ");
            string coordinateY = Console.ReadLine();

            Console.WriteLine("___________");
            Console.WriteLine("Danke, dass Sie " + coordinateX + " und " +
                coordinateY + " eingegeben haben.");

            Gelaende.ColorBackground();

            Console.ResetColor();
            Farben.Ship();

            Console.WriteLine("__________");
            Console.WriteLine("Wo befindet sich die Eins?");
            Console.WriteLine("In Position 0, 1 oder 2?");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] array = Mini.Positioning();
            Mini.isHitting(array, index);
        }
    }
}

