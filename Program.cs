using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Public //nachher Tokenizer nach zusammenfügen mit Abbas code?
{
    public static List<string> Tokenize(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b\w+\b");

        List<string> words = new List<string>();
        foreach (Match match in matches)
        {
            words.Add(match.Value);
        }

        return words;
    }

 
    static void Main()
    {
        string sentence = Console.ReadLine();
        List<string> tokens = Tokenize(sentence);
        Console.WriteLine("Tokens:");
        foreach (string token in tokens)
        {
            Console.WriteLine(token);
        }
    }
}
