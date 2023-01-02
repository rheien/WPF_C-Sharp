using System;
namespace WPF_C_Sharp
{
	public class Schiessen
	{
		public bool HasBeenHit(string[,] matrix, int coordinateX, int coordinateY)
		{
			return matrix[coordinateX, coordinateY] == "1";
		}

		public int NumberOfOnes(string[,] matrix)
		{
			int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (HasBeenHit(matrix,i,j))
                    {
                        count++;
                    }
                }
            }
            return count;
		}

        public int getCoordinate(string text)
        {
            Console.Write(text);
            return Convert.ToInt16(Console.ReadLine());
        }

        public string[,] MatrixAfterHitting(string[,] matrix, int coordinateX, int coordinateY)
        {
            matrix[coordinateX, coordinateY] = "0";
            return matrix;
        }
	}
}

