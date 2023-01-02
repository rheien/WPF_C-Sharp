using System;
namespace WPF_C_Sharp
{
	public class Matrixvergleich
	{
        public string[,] ZeroMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = "0";
                }
            }

            return matrix;
        }

        public void CompareMatrices(string[,] matrix, string[,] zeroMatrix)
		{
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != zeroMatrix[i, j])
                    {
                        Console.WriteLine("In der Koordinate: [ " + i + ", " + j + "] gab es eine 1.");
                    }
                }
            }
        }
	}
}

