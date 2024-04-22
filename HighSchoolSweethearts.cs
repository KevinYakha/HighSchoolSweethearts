using System;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        string sweethearts = studentA + " ♡ " + studentB;
        sweethearts = sweethearts.PadLeft(32 + studentB.Length);
        sweethearts = sweethearts.PadRight(61);
        return sweethearts;
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        throw new NotImplementedException($"Please implement the (static) HighSchoolSweethearts.DisplayBanner() method");
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        throw new NotImplementedException($"Please implement the (static) HighSchoolSweethearts.DisplayGermanExchangeStudents() method");
    }
}
