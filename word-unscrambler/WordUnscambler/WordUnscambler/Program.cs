using System;
using System.IO;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            File.WriteAllLines("FormattedFile.txt", FormattedLines(lines));

            string[] otherLines = { "Another first line", "Another second line", "Another third line" };
            File.WriteAllLines("AnotherFormattedFile.txt", FormattedLines(otherLines));
        }

        static string[] FormattedLines(String[] unformattedLines)
        {
            string[] formattedLines = new string[unformattedLines.Length];

            for (int i = 0; i < formattedLines.Length; i++)
            {
                formattedLines[i] = String.Format("{0} {1} {2}", "---", unformattedLines[i], "---");
            }

            return formattedLines;
        }
    }
}
