using System.Text;

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
    }
}