using System;
using System.Text;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder myString1 = new StringBuilder();
            myString1.Append("Here is some text");
            myString1.Append("Here is some more text");
            myString1.Append("Here is even more text");

            string myString2 = "Here is some text";
            myString2 = myString2 + "Here is some more text";
            myString2 = myString2 + "Here is even more text";
        }
    }
}
