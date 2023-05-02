string text = File.ReadAllText($@"{Environment.CurrentDirectory}\some.txt");

char[] symbols = text.ToCharArray();

//var symbols = text.ToList();

int numberOfSymbols = 0;

foreach(char symbol in symbols)
{
    if (Char.IsPunctuation(symbol))
    {
        numberOfSymbols++;
    }
}

Console.WriteLine(numberOfSymbols);