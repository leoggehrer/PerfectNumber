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
	}
}
