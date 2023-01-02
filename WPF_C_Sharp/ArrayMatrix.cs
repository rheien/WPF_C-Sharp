using System;
namespace WPF_C_Sharp
{
	public class ArrayMatrix
	{
		public string[,] FillMatrixWithZerosAndOnes(string[,] matrix)
		{
			Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0,2).ToString();
                }
            }

            return matrix;
		}

        public void ColorMatrixWithZerosAndOnes(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == "0")
                    {
                        Gelaende.ColorBackground("Green");
                        Console.Write("  ");
                    }
                    if (matrix[i, j] == "1")
                    {
                        Gelaende.ColorBackground("Red");
                        Console.Write("  ");
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
	}
}

