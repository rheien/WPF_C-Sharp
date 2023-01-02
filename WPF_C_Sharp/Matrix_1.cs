using System;
namespace WPF_C_Sharp
{
    class Matrix_1
    {
        public string[,] RandomThreeChain(string[,] matrix, string shipColor)
        {
            Random random = new Random();

            int matrixSize = matrix.GetLength(1);
            int randomIndexX = random.Next(0, matrixSize);
            int randomIndexY = random.Next(0, matrixSize);

            int size3 = 3;

            //down
            if(randomIndexX + size3 <= matrixSize)
            {
                while (size3 > 0)
                {
                    matrix[randomIndexX , randomIndexY] = shipColor;
                    randomIndexX = randomIndexX + 1;
                    size3--;
                }
            }
            //up
            else if (randomIndexX - size3 > 0)
            {
                while (size3 > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexX = randomIndexX - 1;
                    size3--;
                }
            }
            //right
            else if(randomIndexY + size3 <= matrixSize)
            {
                while (size3 > 0)
                {
                    matrix[randomIndexX, randomIndexY ] = shipColor;
                    randomIndexY = randomIndexY + 1;
                    size3--;
                }
            }
            //left
            else if (randomIndexY - size3 > 0)
            {
                while (size3 > 0)
                {
                    matrix[randomIndexX, randomIndexY] = shipColor;
                    randomIndexY = randomIndexY - 1;
                    size3--;
                }
            }
            return matrix;
        }

        public string[,] FillMatrix(string[,] matrix, string background)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = background;
                }
            }

            return matrix;
        }

        public void Battlefield(string[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for( int j = 0; j < matrix.GetLength(1); j++)
                {
                    Gelaende.ColorBackground(matrix[i,j]);
                    Console.Write("  ");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}