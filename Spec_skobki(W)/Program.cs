class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        string outputString = HighlightRepeatedWords(inputString);

        Console.WriteLine(outputString);
        Console.ReadLine();
    }

    static string HighlightRepeatedWords(string input)
    {
        string[] words = input.Split(' ');
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        string result = "";
        foreach (string word in words)
        {
            if (wordCount[word] > 1)
            {
                result += $"<strong>{word}</strong> ";
            }
            else
            {
                result += $"{word} ";
            }
        }

        return result.TrimEnd();
    }
}
