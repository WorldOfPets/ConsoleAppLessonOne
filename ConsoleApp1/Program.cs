using System;

class Program
{
    static void Main()
    {
        int intLiteral = 24;
        double doubleLiteral = 3.14;
        char charLiteral = 'A';
        string stringLiteral = "Hello, World!";
        bool boolLiteral = true;

        Console.WriteLine($"Integer Literal: {intLiteral}, Type: {intLiteral.GetType()}");
        Console.WriteLine($"Double Literal: {doubleLiteral}, Type: {doubleLiteral.GetType()}");
        Console.WriteLine($"Char Literal: {charLiteral}, Type: {charLiteral.GetType()}");
        Console.WriteLine($"String Literal: {stringLiteral}, Type: {stringLiteral.GetType()}");
        Console.WriteLine($"Bool Literal: {boolLiteral}, Type: {boolLiteral.GetType()}");
    }
}
