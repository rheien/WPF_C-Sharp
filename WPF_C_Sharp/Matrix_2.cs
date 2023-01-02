using System;
namespace WPF_C_Sharp
{
    public class Matrix_2
    {
        public string[,] randomShipPosition(string[,] matrix, string shipColor, int shipLength)
        {
            Random random = new Random();

            int matrixSize = matrix.GetLength(1);
            int randomIndexX = random.Next(0, matrixSize);
            int randomIndexY = random.Next(0, matrixSize);

            while ( matrix[randomIndexX, randomIndexY] == shipColor)
            {
                randomIndexX = random.Next(0, matrixSize);
                randomIndexY = random.Next(0, matrixSize);
            }

            if (randomIndexX + shipLength <= matrixSize)
            {
                while (shipLength > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexX = randomIndexX + 1;
                    shipLength--;
                }
            }
            else if (randomIndexX - shipLength > 0)
            {
                while (shipLength > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexX = randomIndexX - 1;
                    shipLength--;
                }
            }
            else if (randomIndexY + shipLength  <= matrixSize)
            {
                while (shipLength > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexY = randomIndexY + 1;
                    shipLength--;
                }
            }

            else if (randomIndexY - shipLength > 0)
            {
                while (shipLength > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexY = randomIndexY - 1;
                    shipLength--;
                }
            }
            return matrix;
        }
    }
}

