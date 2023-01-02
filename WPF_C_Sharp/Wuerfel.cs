using System;
namespace WPF_C_Sharp
{
	public class Wuerfel
	{
		public List<int> DiceGame()
		{
			List<int> rolledDices = new List<int>();

			for (int i = 0; i < 4; i++)
			{
                Random random = new Random();
                rolledDices.Add(random.Next(1,6 +1));
			}

			return rolledDices;
		}


		public bool HasRolledASix(List<int> dices)
		{
			bool rolledSix = false;
			foreach (int rolledDices in dices)
			{
				Console.Write(rolledDices.ToString() + " ");
				if (rolledDices == 6)
				{
					rolledSix = true;
				}
			}
			Console.WriteLine();
            return rolledSix;
		}
	}
}

