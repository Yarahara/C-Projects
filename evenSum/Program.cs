// See https://aka.ms/new-console-template for more information
class Program
{
    public static int evenSum(int start, int end)
    {
        int theSum = 0;
        if (start >= end)
        {
            return 0;
        }
        else
        {
            while (start < end)
            {
                if (start % 2 == 0)
                {
                    theSum += start;
                }
                start += 1;
            }
            return theSum;
        }
    }

    public static double evenSumSquared(double start, double end)
    {
        double theSum = 0;
        if (start >= end)
        {
            return 0;
        }
        else
        {
            while(start < end)
            {
                if (start % 2 == 0)
                {
                    theSum += Math.Pow(start,2);
                }
                start += 1;
            }
            return theSum;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine($"The sum of even numbers from 1-10 is {evenSum(1,10)}");
        Console.WriteLine($"The sum of even numbers from 1-1 is {evenSum(1,1)}");
        Console.WriteLine($"The sum of even numbers from 2-2 is {evenSum(2,2)}");
        Console.WriteLine($"The sum of even numbers from 5-2 is {evenSum(5,2)}");

        Console.WriteLine($"The sum of even numbers squared from 1-10 is {evenSumSquared(1,10)}");
        Console.WriteLine($"The sum of even numbers squared from 1-1 is {evenSumSquared(1,1)}");
        Console.WriteLine($"The sum of even numbers squared from 2-2 is {evenSumSquared(2,2)}");
        Console.WriteLine($"The sum of even numbers squared from 5-2 is {evenSumSquared(5,2)}");
    }
}

