namespace AdventOfCode2023.obj;

public class AdventUtils
{
    public static List<string> ReadTextFile(string fileName, int day)
    {
        List<string> lines = new List<string>();

        try
        {
            string? callingFilePath = new System.Diagnostics.StackTrace(true).GetFrame(0)?.GetFileName();
            string? directory = Path.GetDirectoryName(callingFilePath);

            if (directory != null)
            {
                string filePath = Path.Combine(directory, "day" + day, fileName);

                lines.AddRange(File.ReadAllLines(filePath));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return lines;
    }
}