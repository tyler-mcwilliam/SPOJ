using System;
using System.Linq;

// https://www.spoj.com/problems/ADDREV/
// Returns the reversed sum of two reversed integers
public static class ADDREV
{
    public static int Solve(int a, int b)
        => Reverse(Reverse(a) + Reverse(b));

    private static int Reverse(int a)
        => int.Parse(new string(a.ToString().Reverse().ToArray()));
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            string[] numbers = Console.ReadLine().Split();
            Console.WriteLine(
                ADDREV.Solve(a: int.Parse(numbers[0]), b: int.Parse(numbers[1])));
        }
    }
}