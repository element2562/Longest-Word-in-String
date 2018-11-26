using System;

class MainClass
{
    public static string LongestWord(string sen)
    {

        // code goes here  
        /* Note: In C# the return type of a function and the 
           parameter types being passed are defined, so this return 
           call must match the return type of the function.
           You are free to modify the return type. */
        string[] SeparatedWords = sen.Split(' ');
        string staticWord = SeparatedWords[0];
        for (int i = 0; i < SeparatedWords.Length; i++)
        {
            string Iteration = SeparatedWords[i];
            if (Iteration.Length > staticWord.Length)
            {
                staticWord = Iteration;
            }

        }
        sen = staticWord;
        return sen;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(LongestWord(Console.ReadLine()));
    }

}
