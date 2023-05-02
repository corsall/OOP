string text = File.ReadAllText($@"{Environment.CurrentDirectory}\some.txt");

char[] symbols = text.ToCharArray();
//var symbols = text.ToList();

Console.WriteLine(Calculate(symbols));

int Calculate(char[] text){
    int numberOfSymbols = 0;

    foreach(char symbol in symbols)
    {
        if (Char.IsPunctuation(symbol))
        {
            numberOfSymbols++;
        }
    }

    return numberOfSymbols;
}