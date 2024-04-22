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
        return string.Format(@"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {0} +  {1}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *", studentA, studentB);
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
        return $"{studentA} and {studentB} have been dating since {start:d} - that's {hours:N2} hours";
    }
}
