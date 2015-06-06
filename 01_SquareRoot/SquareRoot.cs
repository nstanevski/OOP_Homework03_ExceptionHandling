using System;

/*
 * Write a program that reads an integer number and calculates and prints 
 * its square root. 
 * If the number is invalid or negative, print "Invalid number". 
 * In all cases finally print "Good bye". Use try-catch-finally.
 */

class SquareRoot
{
    static void Main()
    {
        string str = Console.ReadLine();
        try
        {
            int n = int.Parse(str);
            double d = Math.Sqrt((double)n);
            if (double.IsNaN(d))
                throw new ArgumentException();
            Console.WriteLine("Number: {0} square root: {1:f8}", n, d);
        }
        catch (Exception eX)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}