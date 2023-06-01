try
{
    if (args.Length < 2)
    {
        Console.WriteLine("Please provide the file path and case sensitivity (Y/N) as command line arguments.");
        return;
    }

    string filePath = args[0];
    bool isCaseSensitive = args[1].Trim().ToUpper() == "Y";


    string text = File.ReadAllText(filePath);
    List<CharacterFrequencyModel> frequencies = AnalyzeFrequencies(text, isCaseSensitive);

    Console.WriteLine($"Total characters: {frequencies.Sum(c => c.Frequency)}");
    Console.WriteLine("Top 10 most frequent characters:");

    foreach (var entry in GetTopFrequencies(frequencies, 10))
    {
        Console.WriteLine($"{entry.Character} ({entry.Frequency})");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

static List<CharacterFrequencyModel> AnalyzeFrequencies(string text, bool isCaseSensitive)
{
    var frequencies = new List<CharacterFrequencyModel>();

    foreach (char c in text)
    {
        if (char.IsWhiteSpace(c))
            continue;

        char charToCheck = isCaseSensitive ? c : char.ToLower(c);

        var existingEntry = frequencies.FirstOrDefault(entry => entry.Character == charToCheck);
        if (existingEntry != null)
        {
            existingEntry.Frequency++;
        }
        else
        {
            frequencies.Add(new CharacterFrequencyModel { Character = charToCheck, Frequency = 1 });
        }
    }

    return frequencies;
}


IEnumerable<CharacterFrequencyModel> GetTopFrequencies(List<CharacterFrequencyModel> frequencies, int count)
{
    return frequencies
        .OrderByDescending(entry => entry.Frequency)
        .Take(count);
}
