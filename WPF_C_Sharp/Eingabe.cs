using System;
namespace WPF_C_Sharp
{
    public class Eingabe
    {
    
        static void Main(string[] args)
        {
            //Aufgabe 1:
            Console.Write("Geben Sie eine x-Koordinate ein: ");
            string coordinateX = Console.ReadLine();

            Console.Write("Geben Sie eine y-Koordinate ein: ");
            string coordinateY = Console.ReadLine();

            Console.WriteLine("___________");
            Console.WriteLine("Danke, dass Sie " + coordinateX + " und " +
                coordinateY + " eingegeben haben.");

            //Aufgabe 2:
            Gelaende.ColorBackground("Blue");
            Console.WriteLine("");

            //Aufgabe 3:
            Farben.Ship();

            //Aufgabe 4:
            Console.WriteLine("__________");
            Console.WriteLine("Wo befindet sich die Eins?");
            Console.WriteLine("In Position 0, 1 oder 2?");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] array = Mini.Positioning();
            Mini.isHitting(array, index);

            //Aufgabe 5:
            Console.WriteLine("----------");
            Matrix_1 matrix_1 = new Matrix_1();
            string[,] matrix = new string[9, 9];
            matrix_1.FillMatrix(matrix,"Green");
            matrix_1.RandomThreeChain(matrix, "Red");
            matrix_1.Battlefield(matrix);

            //Aufgabe 6:
            Console.WriteLine("----------");
            matrix_1.FillMatrix(matrix, "Green");

            Matrix_2 matrix_2 = new Matrix_2();
            matrix_2.randomShipPosition(matrix, "Red", 2);
            matrix_2.randomShipPosition(matrix, "Red", 3);
            matrix_2.randomShipPosition(matrix, "Red", 4);
            matrix_1.Battlefield(matrix);

            //Aufgabe 7:
            Console.WriteLine("----------");
            Wuerfel dices = new Wuerfel();
            List<int> rolledDices = dices.DiceGame();
            int attempts = 1;
            while (!dices.HasRolledASix(rolledDices))
            {
                rolledDices = dices.DiceGame();
                attempts++;
            }
            Console.WriteLine(attempts);

            //Aufgabe 8:
            Console.WriteLine("----------");

            int min = 1;
            int max = 10;
            Random random = new Random();
            int setNumberForGuessing = random.Next(min, max + 1);

            Raten guess = new Raten();
            Console.Write("Rate die Zahl zwischen 1 und 10: ");
            int input = Convert.ToInt16(Console.ReadLine());
            while (!guess.ValidNumber(min, max, input))
            {
                Console.WriteLine("Ungueltige Zahl!");
                Console.Write("Rate die Zahl zwischen 1 und 10: ");
                input = Convert.ToInt16(Console.ReadLine());
            }
            
            while (!guess.IsTheNumberCorrect(setNumberForGuessing, input))
            {
                guess.Hint(setNumberForGuessing, input);
                Console.Write("Rate die Zahl zwischen 1 und 10: ");
                input = Convert.ToInt16(Console.ReadLine());
                while (!guess.ValidNumber(min, max, input))
                {
                    Console.WriteLine("Ungueltige Zahl!");
                    Console.Write("Rate die Zahl zwischen 1 und 10: ");
                    input = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine("Richtig geraten!");

            //Aufgabe 9:
            Console.WriteLine("----------");

            string[,] arrayMatrix = new string[10, 10];
            ArrayMatrix arrayMatrix1 = new ArrayMatrix();

            arrayMatrix1.FillMatrixWithZerosAndOnes(arrayMatrix);
            arrayMatrix1.ColorMatrixWithZerosAndOnes(arrayMatrix);

            //Aufgabe 10:
            Console.WriteLine("----------");

            Matrixvergleich compare = new Matrixvergleich();
            string[,] zeroMatrix = new string[10, 10];
            compare.ZeroMatrix(zeroMatrix);
            compare.CompareMatrices(arrayMatrix, zeroMatrix);

            //Aufgabe 11:
            Console.WriteLine("----------");

            Console.WriteLine("Schiesse mindestens drei Einsen ab.");
            Schiessen shoot = new Schiessen();
            int numberOfOnes = shoot.NumberOfOnes(arrayMatrix);
            int hasHit = 0;
            int coordiX;
            int coordiY;
            while (hasHit < 3)
            {
                coordiX = shoot.getCoordinate("Geben Sie eine x-Koordinate ein: ");
                coordiY = shoot.getCoordinate("Geben Sie eine y-Koordinate ein: ");
                if (shoot.HasBeenHit(arrayMatrix, coordiX, coordiY))
                {
                    shoot.MatrixAfterHitting(arrayMatrix, coordiX, coordiY);
                    hasHit++;
                    Console.WriteLine("Getroffen!");
                }
                else
                {
                    Console.WriteLine("Daneben!!!");
                }
                Console.WriteLine();
                Console.WriteLine("Anzahl Einsen in der Matrix: " + numberOfOnes);
                Console.WriteLine("Anzahl Einsen gefunden: " + hasHit);
            }
        }
    }
}

