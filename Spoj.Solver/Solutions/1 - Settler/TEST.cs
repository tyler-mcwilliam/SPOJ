using System;

// https://www.spoj.com/problems/TEST/
// Reads and prints input until 42 is found.
public static class TEST
{
    public static void Solve()
    {
        string line;
        while ((line = Console.ReadLine()) != "42")
        {
            Console.WriteLine(line);
        }
    }
}

public static class Program
{
    public static void Main()
        => TEST.Solve();
}