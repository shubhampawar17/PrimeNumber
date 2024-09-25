using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.model
{
    internal class Prime
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            return count == 2;
        }
    }
}
