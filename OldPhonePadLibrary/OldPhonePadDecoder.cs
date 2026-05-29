namespace OldPhonePadLibrary;

public static class OldPhonePadDecoder
{
    private static readonly Dictionary<char, string> Keypad = new()
    {
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" }
    };
/// <summary>
/// Decodes old phone keypad input into readable text.
/// </summary>
/// <param name="input">Keypad sequence ending with #</param>
/// <returns>Decoded text output</returns>
    public static string Decode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        var result = new List<char>();

        string[] groups = input.Replace("#", "").Split(' ');

        foreach (var group in groups)
        {
            if (string.IsNullOrEmpty(group))
                continue;

            int i = 0;

            while (i < group.Length)
            {
                char current = group[i];

                if (current == '*')
                {
                    if (result.Count > 0)
                    {
                        result.RemoveAt(result.Count - 1);
                    }

                    i++;
                    continue;
                }

                int count = 0;

                while (i < group.Length && group[i] == current)
                {
                    count++;
                    i++;
                }

                if (Keypad.ContainsKey(current))
                {
                    string letters = Keypad[current];

                    int index = (count - 1) % letters.Length;

                    result.Add(letters[index]);
                }
            }
        }

        return new string(result.ToArray());
    }
}