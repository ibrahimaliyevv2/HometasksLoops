using System;
class program5 {
	static int getSum(int n)
	{
		int sum = 0;

		while (n != 0) {
			sum = sum + n % 10;
			n = (n -(n%10))/ 10;
		}
		return sum;
	}

	public static void Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		Console.Write(getSum(n));
	}
}
