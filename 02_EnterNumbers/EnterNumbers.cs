using System;

class EnterNumbers
{
    private static void ReadNumber(int start, int end, out int number)
    {
        Console.WriteLine("Enter a number in range [{0} .. {1}]", start, end);
        string str = Console.ReadLine();
        try
        {
            number = int.Parse(str);
        }
        catch (Exception)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }
    }


    static void Main()
    {
        int start = 1;
        int end = 100;
        int count = 10;
        bool successfulSequence = true;
        int[] sequence = new int[10];
        for(int i=0; i<count; i++){
            //allow the user up to 3 tries to enter the number in valid range:
            bool successfulEntry = false;
            int numTries = 3;
            while (!successfulEntry && numTries>0)
            {
                try
                {
                    int num = 0;
                    ReadNumber(start + 1, end - count + i, out num);
                    start = num;
                    successfulEntry = true;
                    sequence[i] = num;
                }
                catch (ArgumentOutOfRangeException)
                {
                    numTries--;
                }
            }
            if (!successfulEntry && numTries == 0)
            {
                Console.WriteLine("Sorry, you failed after 3 tries to enter a number in specified range");
                successfulSequence = false;
                break;
            }     
        }
        if (successfulSequence)
            Console.WriteLine('['+string.Join(", ", sequence) + ']');
    }
}