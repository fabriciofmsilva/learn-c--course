using System;

namespace WordUnscambler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref need initialize and don't neet to assign in method
            int a = 10;
            ChangeNumber(ref a);
            // out not need initialize and need to assign in method
            // int a;
            // ChangeNumber(out a);
            Console.WriteLine(a);
        }

        static void ChangeNumber(ref int a)
        {
            a = 90;
        }
    }
}
