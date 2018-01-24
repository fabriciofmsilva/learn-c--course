using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // comparison
            string someText = "Here is some text";
            string someOtherText = "Here is some other text";

            someText.Equals(someOtherText);
            bool isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);

            someOtherText = "Here is some text";

            isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);

            someText = "Here is Some text";
            isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);

            isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);

            // concatenation
            string addedText = someText + " " + someOtherText + " here is some more text.";
            string formattedString = string.Format("{0} {1} here is some more text.", someText, someOtherText);

            Console.WriteLine(addedText);
            Console.WriteLine(formattedString);

            // lengths and indexes
            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);

            // substring
            Console.WriteLine(someText.Substring(8, 4));

            // uppercase and lowercase
            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());

            string anotherText = string.Empty; // string anotherText = "";

            string replacedText = someText.Replace("text", "string");

            Console.WriteLine(replacedText);
        }
    }
}
