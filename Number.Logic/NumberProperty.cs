using System;

namespace Number.Logic
{
	public static class NumberProperty
	{
		public static bool IsPerfect(long number)
		{
			long sum = 1;

			for (int i = 2; i <= number / 2; i++)
			{
				if (number % i == 0)
				{
					sum += i;
				}
			}

			return sum == number;
		}

		public static bool IsPrime(long number)
		{
			bool isPrime = number == 2 || (number > 2 && number % 2 != 0);

			for (int i = 3; isPrime && i <= number / 2; i += 2)
			{
				if (number % i == 0)
					isPrime = false;
			}
			return isPrime;
		}
	}
}
