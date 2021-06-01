using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiloids.Task
{
    public class LaserStrike
    {
        public static int SmallestPrime(int[] numbers)
        {
            int min = 2;

            while (true)
            {
                if (!numbers.Contains(min))
                    return min;
                else
                    min = NextPrimeNumber(min);
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                        return false;
                }
            }
            return true;
        }
        private static int NextPrimeNumber(int primeNumber)
        {
            while (true)
            {
                if (IsPrime(++primeNumber))
                    return primeNumber;
            }
        }
    }
}
