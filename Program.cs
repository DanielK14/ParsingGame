using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder stringBuilder = new StringBuilder("");
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\danie\Repo\ParsingGame\Assets\input.txt");

        foreach (string line in lines)
        {
            if (line.Contains("split"))
            {
                stringBuilder.Append(line.Split()[4] + " ");
            }
        }
        string outputString = stringBuilder.ToString();
        Console.WriteLine(outputString);

        File.WriteAllText(@"C:\Users\danie\Repo\ParsingGame\Assets\output.txt", outputString);
        
        // Part 2
        StringBuilder stringBuilder2 = new StringBuilder("");
        string pattern = @"\d{2,3}";
        List<string> matches = new List<string>();
        List<int> foundNumbers = new List<int>();
        string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\danie\Repo\ParsingGame\Assets\input2.txt");

        foreach (string line in lines2)
        {
            MatchCollection matchCollection = Regex.Matches(line, pattern);
            foreach (Match match in matchCollection)
            {
                matches.Add(match.Value.ToString());
            }
        }
        
        foreach (string match in matches)
        {
            if (int.TryParse(match, out int result))
            {
                foundNumbers.Add(result);
            }
        }

        foreach (int  result in foundNumbers)
        {
            char letter = (char)result;
            stringBuilder2.Append(letter);
        }

        Console.WriteLine(stringBuilder2.ToString());
        
    }
}