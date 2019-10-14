using System;
using System.Linq;

// https://www.spoj.com/problems/ARMY/
// Determines the winner of a hypothetical battle
// between the armies of Godzilla and MechaGodzilla.
public static class ARMY
{
    public static string Solve(int[] godzillaStrengths, int[] mechaGodzillaStrengths)
        => godzillaStrengths.Max() >= mechaGodzillaStrengths.Max()
        ? "Godzilla" : "MechaGodzilla";
}

public static class Program
{
    private static void Main()
    {
        int remainingTestCases = int.Parse(Console.ReadLine());
        while (remainingTestCases-- > 0)
        {
            Console.ReadLine();
            Console.ReadLine();

            int[] godzillaStrengths = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] mechaGodzillaStrengths = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            Console.WriteLine(
                ARMY.Solve(godzillaStrengths, mechaGodzillaStrengths));
        }
    }
}