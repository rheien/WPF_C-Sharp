using System;
namespace WPF
{
    public class Features
    {
        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

