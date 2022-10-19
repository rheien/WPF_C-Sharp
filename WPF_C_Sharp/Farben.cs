using System;
namespace WPF_C_Sharp
{
    public class Farben
    {

        public static void Ship()
        {
            Console.Write("Geben Sie eine Zahl von 1 bis 5: ");
            string inputNumber = Console.ReadLine();

            string color;
            switch(inputNumber)
            {
                case "1":
                    color = "green";
                    break;

                case "2":
                    color = "red";
                    break;

                case "3":
                    color = "yellow";
                    break;

                case "4":
                    color = "blue";
                    break;

                case "5":
                    color = "black";
                    break;

                default:
                    color = "not found";
                    break;
            }

            Console.WriteLine(color);
        }

        
    }
}

