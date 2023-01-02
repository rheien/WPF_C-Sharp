using System;
namespace WPF_C_Sharp
{
	public class Raten
	{
		public bool IsTheNumberCorrect(int numberToGuess, int userInput)
		{
			if (numberToGuess == userInput) return true;

			else return false;
		}

		public void Hint(int numberToGuess, int userInput)
		{
			if(userInput == 0)
			{
				Console.WriteLine("Die geratene Zahl ist grösser!\n");
			} 
 
			if(numberToGuess < userInput)
			{
				Console.WriteLine("Die geratene Zahl ist kleiner!\n");
			}

            if (numberToGuess > userInput)
            {
                Console.WriteLine("Die geratene Zahl ist grösser!\n");
            }
        }

		public bool ValidNumber(int min, int max, int userInput)
		{
			if (userInput == 0) return false;

			if (userInput < min) return false;

			if (max < userInput) return false;

			return true;
		}
	}
}

