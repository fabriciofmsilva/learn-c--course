﻿using System;

namespace CSharp7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryLiteralsAndDigitSeparators binaryLiteralsAndDigitSeparators = new BinaryLiteralsAndDigitSeparators();
            binaryLiteralsAndDigitSeparators.Run();

            RefLocalsAndReturns refLocalsAndReturns = new RefLocalsAndReturns();
            refLocalsAndReturns.Run();

            Deconstruction descontruction = new Deconstruction();
            descontruction.Run();
        }
    }
}